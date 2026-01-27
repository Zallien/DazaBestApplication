using Bunifu.UI.WinForms;
using DazaBestApplication.Modals;
using DazaBestApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class ItemInventory : Form
    {
        private ItemServices itemservices = new ItemServices(new BackEndDBContext());
        private Form Mainform;
        private Panel ContainerPanel;
        private List<Items> _allitem;
        private ItemModal _itemmodal = new ItemModal();
        private DecisionModel _decision = new DecisionModel();
        private int _pagenumber = 1;
        private int _itemperpage = 12;
        private int _totalitems = 0;
        private int _maxpagenumber;
        private bool DesicionResult;
        private Panel Loadingpanel;
        private BunifuLoader bunifuLoader;
        private string searchvalue = "";
        private NotificationModel _notificationmodel;

        //Constructor
        public ItemInventory(Form _MainForm, Panel containerPanel)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }

            ContainerPanel = containerPanel;
        }
        //ShowAddItemModal
        private void ShowAddItemModal()
        {
            _itemmodal = new ItemModal()
            {
                Action = "AddItem",
                EditItem = null
            };
            OpenModal();
        }
        private async Task ShowloadingScreeen()
        {
            // ✅ 1. Create the panel
            Loadingpanel = new Panel()
            {
                Location = new Point(0, 0),
                Size = ContainerPanel.Size,
                BackColor = Color.FromArgb(20, 0, 0, 0),
                Visible = false
            };

            
            this.Controls.Add(Loadingpanel);
            Loadingpanel.BringToFront();
            Loadingpanel.Visible = true;

            
            bunifuLoader = new BunifuLoader()
            {
                Size = new Size(200, 200),
                BackColor = Color.BlanchedAlmond,
                Visible = true
            };

            
            Loadingpanel.Controls.Add(bunifuLoader);

            
            bunifuLoader.Location = new Point(
                (Loadingpanel.Width - bunifuLoader.Width) / 2,
                (Loadingpanel.Height - bunifuLoader.Height) / 2
            );

        }
        private async Task HideLoadingScreen()
        {
            bunifuLoader.Dispose();
            Loadingpanel.Dispose();
        }


        //Main Load
        private async void ItemInventory_Load(object sender, EventArgs e)
        {
            await ShowloadingScreeen();
            await GetData();
            await GetAllItemCount();
            HookEvents();
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            CheckPageNumber();
            await HideLoadingScreen();
            Setfilterpanel();
        }



        //Hook Events
        private void HookEvents()
        {
            ItemEventHandlers.ItemInventoryChanged += GetData;
            deletetoolstrip.Click += DeleteusingDelToolstrip; //Delete using Del Toolstrip
            edittoolstrip.Click += EditusingEditToolstrip; //Edit using Edit Toolstrip
            ItemEventHandlers.ChangeItemDisplayed += GetAllItemCount; //Update Item Count
        }
        //Get All item Count
        private async Task GetAllItemCount()
        {
            _pagenumber = 1;
            PaginationLabel.Text = $"{_pagenumber}";//Pagination Label
            SearchItem Bypage = new SearchItem()
            {
                SearchValue = SearchBoxTextBox.Text,
                PageNumber = _pagenumber,
                ItemperPage = _itemperpage
            };
            _totalitems = await itemservices.GetItemsCount(Bypage);
            _maxpagenumber = _totalitems % _itemperpage != 0 ? (_totalitems / _itemperpage) + 1
                                                        : _totalitems / _itemperpage;
            await CheckPageNumber();
        }
        //Get Data
        private async Task GetData()
        {
            SearchItem Bypage = new SearchItem()
            {
                SearchValue = searchvalue,
                PageNumber = _pagenumber,
                ItemperPage = _itemperpage
            };
            _allitem = new List<Items>();
            itemservices = new ItemServices(new BackEndDBContext());
            _allitem = await itemservices.GetAllItemsByPagination(Bypage);
            await PopulatAllItemDataGrid(_allitem);
        }
        //Pagination Next
        private async void NextButton_Click()
        {

            if (_pagenumber < _maxpagenumber)
            {
                _pagenumber++;
                await CheckPageNumber();
                await GetData();
                PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton_Click()
        {
            if (_pagenumber > 1)
            {
                _pagenumber--;
                await CheckPageNumber();
                await GetData();
                PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            }
        }
        //Check Page Number
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (_pagenumber == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (_pagenumber >= _maxpagenumber)
            {
                PaginationNext.Enabled = false;
            }
            else
            {
                PaginationNext.Enabled = true;
            }
        }
        //Delete Item Validation
        private async Task<Boolean> DeleteItems(List<ItemID> AllSelectedID)
        {
            try
            {
                foreach (var item in AllSelectedID)
                {
                    if (!await itemservices.ToggleIsactiveItem(item.ID))
                    {
                        return false;
                    }
                }
                await ItemEventHandlers.InvokeItemChanged();
                await ItemEventHandlers.InvokeChangeItemDisplayed();
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }
        //Populate DataGrid
        private async Task PopulatAllItemDataGrid(List<Items> _allitemparam)
        {
            _allitem = new List<Items>();
            AllItemsDatagrid.Rows.Clear();
            CultureInfo phCulture = new CultureInfo("en-PH");
            foreach (var item in _allitemparam)
            {
                int rowindex = AllItemsDatagrid.Rows.Add();
                DataGridViewRow row = AllItemsDatagrid.Rows[rowindex];
                row.Cells["RowCol"].Value = item.Row;
                row.Cells["IdCol"].Value = item.ItemID;
                row.Cells["ItemCodeCol"].Value = item.ItemCode;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["StocksCol"].Value = item.BalanceStocks;
                row.Cells["PriceCol"].Value = "₱" + item.ItemPrice.ToString();
            }
        }
        //Open Item Modal
        private void OpenModal()
        {
            Form ModalBackgorund = new();
            using (ItemModalForm modalcontent = new(_itemmodal))
            {
                var mainBounds = Mainform.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = Mainform.Size;
                ModalBackgorund.Location = Mainform.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(Mainform);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }
        //Open Decision Modal
        private bool OpenDecisionModal()
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
            {
                var mainBounds = Mainform.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = Mainform.Size;
                ModalBackgorund.Location = Mainform.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(Mainform);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }
        //Set FilterPanel
        private void Setfilterpanel()
        {
            bunifuShadowPanel1.Location = new Point(filterbutton.Location.X - (bunifuShadowPanel1.Width - filterbutton.Width), filterbutton.Location.Y + filterbutton.Height);

            //Set Defult value of filter
            productperpagetxt.Text = _itemperpage.ToString();
        }
        //Save Filter
        private async Task SaveFilter()
        {

            _itemperpage = int.Parse(productperpagetxt.Text);
            await GetAllItemCount();
            await CheckPageNumber();
            await GetData();
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            bunifuShadowPanel1.Visible = false;
        }
        //Open Notification Modal
        private void OpenNotificationModal()
        {
            Form ModalBackgorund = new();
            using (NotificationModal modalcontent = new(_notificationmodel))
            {
                var mainBounds = Mainform.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = Mainform.Size;
                ModalBackgorund.Location = Mainform.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(Mainform);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }








        //Events
        private void EditusingEditToolstrip(object? sender, EventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedrow = AllItemsDatagrid.SelectedRows[0];
                _itemmodal = new ItemModal()
                {
                    Action = "EditItem",
                    EditItem = new EditItem()
                    {
                        ItemID = Guid.Parse(selectedrow.Cells["IdCol"].Value.ToString()),
                        ItemName = selectedrow.Cells["ItemNameCol"].Value.ToString(),
                        ItemPrice = decimal.Parse(selectedrow.Cells["PriceCol"].Value.ToString().Replace("₱", ""))
                    }
                };
                OpenModal();
            }
        }
        private void AllItemsDatagrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (AllItemsDatagrid.SelectedRows.Count > 1)
                {
                    edittoolstrip.Visible = false;
                    sep1.Visible = false;
                }
                else
                {
                    edittoolstrip.Visible = true;
                    sep1.Visible = true;
                }
                MenustripforItems.Show(Cursor.Position);
            }
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ShowAddItemModal();
        }
        private async void SearchBox(object sender, EventArgs e)
        {
            searchvalue = SearchBoxTextBox.Text;
            _allitem = new List<Items>();
            _allitem = await itemservices.SearchItems(new SearchItem()
            {
                SearchValue = searchvalue,
                PageNumber = 1,
                ItemperPage = 10
            });
            await PopulatAllItemDataGrid(_allitem);
            await ItemEventHandlers.InvokeChangeItemDisplayed();
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label

        } //Search
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton_Click();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton_Click();
        }
        private async void AllItemsDatagrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count > 0)
            {
                if (e.Control && e.KeyCode == Keys.D)
                {
                    _decision = new DecisionModel()
                    {
                        DecisionTitle = "Delete Item(s)",
                        DecisionQuestion = "Are you sure you want to delete the selected item(s)?"
                    };
                    var decision = OpenDecisionModal();
                    if (decision)
                    {
                        List<ItemID> AllSelectedID = new List<ItemID>();
                        foreach (DataGridViewRow row in AllItemsDatagrid.SelectedRows)
                        {
                            if (row.Cells["IdCol"].Value != null)
                            {
                                Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                                AllSelectedID.Add(new ItemID { ID = id });
                            }
                        }

                        if (await DeleteItems(AllSelectedID))
                        {
                            _notificationmodel = new NotificationModel()
                            {
                                Title = "Item Deletion",
                                Details = "The selected item(s) have been successfully deleted."
                            };
                            OpenNotificationModal();
                        }
                        else
                        {
                            _notificationmodel = new NotificationModel()
                            {
                                Title = "Item Deletion",
                                Details = "The selected item(s) could not be deleted. Please try again."
                            };
                            OpenNotificationModal();
                        }
                    }
                }
            }
        } //Control + D Key For Deleting Item
        private async void DeleteusingDelToolstrip(object sender, EventArgs e)
        {

            _decision = new DecisionModel()
            {
                DecisionTitle = "Delete Item(s)",
                DecisionQuestion = "Are you sure you want to delete the selected item(s)?"
            };

            var decision = OpenDecisionModal();

            if (decision)
            {
                List<ItemID> AllSelectedID = new List<ItemID>();
                foreach (DataGridViewRow row in AllItemsDatagrid.SelectedRows)
                {
                    if (row.Cells["IdCol"].Value != null)
                    {
                        Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllSelectedID.Add(new ItemID { ID = id });
                    }
                }

                if (await DeleteItems(AllSelectedID))
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Item Deletion",
                        Details = "The selected item(s) have been successfully deleted."
                    };
                    OpenNotificationModal();
                }
                else
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Item Deletion",
                        Details = "The selected item(s) could not be deleted. Please try again."
                    };
                    OpenNotificationModal();
                }
            }
        } //Delete using Del Toolstrip
        private async void bunifuButton21_Click(object sender, EventArgs e)
        {
            _decision = new DecisionModel()
            {
                DecisionTitle = "Delete Item(s)",
                DecisionQuestion = "Are you sure you want to delete the selected item(s)?"
            };

            var decision = OpenDecisionModal();

            if (decision)
            {
                List<ItemID> AllSelectedID = new List<ItemID>();
                foreach (DataGridViewRow row in AllItemsDatagrid.SelectedRows)
                {
                    if (row.Cells["IdCol"].Value != null)
                    {
                        Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllSelectedID.Add(new ItemID { ID = id });
                    }
                }

                if (await DeleteItems(AllSelectedID))
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Item Deletion",
                        Details = "The selected item(s) have been successfully deleted."
                    };
                    OpenNotificationModal();
                }
                else
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Item Deletion",
                        Details = "The selected item(s) could not be deleted. Please try again."
                    };
                    OpenNotificationModal();
                }
            }
        }
        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedrow = AllItemsDatagrid.SelectedRows[0];
                _itemmodal = new ItemModal()
                {
                    Action = "EditItem",
                    EditItem = new EditItem()
                    {
                        ItemID = Guid.Parse(selectedrow.Cells["IdCol"].Value.ToString()),
                        ItemName = selectedrow.Cells["ItemNameCol"].Value.ToString(),
                        ItemPrice = decimal.Parse(selectedrow.Cells["PriceCol"].Value.ToString().Replace("₱", ""))
                    }
                };
                OpenModal();
            }
        }
        private void AllItemsDatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SaveFilter();
        }
        private void filterbutton_Click(object sender, EventArgs e)
        {
            bunifuShadowPanel1.Visible = !bunifuShadowPanel1.Visible;
        }
        private void productperpagetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
