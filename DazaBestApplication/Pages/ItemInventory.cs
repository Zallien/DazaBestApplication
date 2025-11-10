using Bunifu.UI.WinForms;
using DazaBestApplication.Modals;
using DazaBestApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;
using SystemBackEnd;

namespace DazaBestApplication.Pages
{
    public partial class ItemInventory : Form
    {
        private ItemServices itemservices = new ItemServices(new BackEndDBContext());
        private Form Mainform;
        private List<Items> _allitem;
        private ItemModal _itemmodal = new ItemModal();
        private DecisionModel _decision = new DecisionModel();
        private int _pagenumber = 1;
        private int _itemperpage = 12;
        private int _totalitems = 0;
        private int _maxpagenumber;
        private bool DesicionResult;

        //Constructor
        public ItemInventory(Form _MainForm)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }
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

        //Main Load
        private async void ItemInventory_Load(object sender, EventArgs e)
        {
            await GetData();
            await GetAllItemCount();
            HookEvents();
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            CheckPageNumber();
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
                SearchValue = "",
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
            foreach (var item in _allitemparam)
            {
                int rowindex = AllItemsDatagrid.Rows.Add();
                DataGridViewRow row = AllItemsDatagrid.Rows[rowindex];
                row.Cells["RowCol"].Value = item.Row;
                row.Cells["IdCol"].Value = item.ItemID;
                row.Cells["ItemCodeCol"].Value = item.ItemCode;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["StocksCol"].Value = item.BalanceStocks;
                row.Cells["PriceCol"].Value = item.ItemPrice;
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










        //Events
        private void EditusingEditToolstrip(object? sender, EventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = AllItemsDatagrid.SelectedRows[0];
                _itemmodal = new ItemModal()
                {
                    Action = "EditItem",
                    EditItem = new EditItem()
                    {
                        ItemID = Guid.Parse(selectedrow.Cells["IdCol"].Value.ToString()),
                        ItemName = selectedrow.Cells["ItemNameCol"].Value.ToString(),
                        ItemPrice = decimal.Parse(selectedrow.Cells["PriceCol"].Value.ToString())
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

            _allitem = new List<Items>();
            _allitem = await itemservices.SearchItems(new SearchItem()
            {
                SearchValue = SearchBoxTextBox.Text,
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
                            MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Deleted Unsuccessfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }//Control + D Key For Deleting Item
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
                    MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Unsuccessfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }//Delete using Del Toolstrip
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
                    MessageBox.Show("Deleted Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deleted Unsuccessfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = AllItemsDatagrid.SelectedRows[0];
                _itemmodal = new ItemModal()
                {
                    Action = "EditItem",
                    EditItem = new EditItem()
                    {
                        ItemID = Guid.Parse(selectedrow.Cells["IdCol"].Value.ToString()),
                        ItemName = selectedrow.Cells["ItemNameCol"].Value.ToString(),
                        ItemPrice = decimal.Parse(selectedrow.Cells["PriceCol"].Value.ToString())
                    }
                };
                OpenModal();
            }
        }
        private void AllItemsDatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
