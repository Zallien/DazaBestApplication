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

namespace DazaBestApplication.Pages
{
    public partial class ItemInventory : Form
    {
        private ItemServices itemservices = new ItemServices();
        private Form Mainform;
        private List<Items> Allitems;
        private BunifuTransition bunifuTransition = new();
        private ItemModal itemmodal = new ItemModal();

        //Constructor
        public ItemInventory(Form _MainForm)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }
            typeof(DataGridView).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null,
                AllItemsDatagrid,
                new object[] { true }
            );
        }

        //ShowAddItemModal
        private void ShowAddItemModal()
        {
            itemmodal = new ItemModal()
            {
                Action = "AddItem",
                EditItem = null
            };
            Form ModalBackgorund = new();
            using (ItemModalForm modalcontent = new(itemmodal))
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

        //Main Load
        private async void ItemInventory_Load(object sender, EventArgs e)
        {
            await GetData();
            ItemEventHandlers.ItemInventoryChanged += GetData;
            deletetoolstrip.Click += DeleteusingDelToolstrip; //Delete using Del Toolstrip
            edittoolstrip.Click += EditusingEditToolstrip; //Edit using Edit Toolstrip
        }

        private void EditusingEditToolstrip(object? sender, EventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedrow = AllItemsDatagrid.SelectedRows[0];
                itemmodal = new ItemModal()
                {
                    Action = "EditItem",
                    EditItem = new EditItem()
                    {
                        ItemID = Guid.Parse(selectedrow.Cells["IdCol"].Value.ToString()),
                        ItemName = selectedrow.Cells["ItemNameCol"].Value.ToString(),
                        ItemPrice = decimal.Parse(selectedrow.Cells["PriceCol"].Value.ToString())
                    }
                };
                Form ModalBackgorund = new();
                using (ItemModalForm modalcontent = new(itemmodal))
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
        }

        //Get Data
        private async Task GetData()
        {
            Allitems = new List<Items>();
            Allitems = await itemservices.GetAllItems();
            AllItemsDatagrid.Rows.Clear();
            foreach (var item in Allitems)
            {
                int rowindex = AllItemsDatagrid.Rows.Add();
                DataGridViewRow row = AllItemsDatagrid.Rows[rowindex];

                row.Cells["RowCol"].Value = item.Row;
                row.Cells["IdCol"].Value = item.ItemID;
                row.Cells["ItemCodeCol"].Value = item.ItemCode;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["StocksCol"].Value = item.BalanceStocks;
                row.Cells["PriceCol"].Value = item.ItemPrice;
                row.Cells["StatusCol"].Value = item.IsActive == true ? "Active" : "Not active";
            }
        }

        //Control + D Key For Deleting Item
        private async void AllItemsDatagrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (AllItemsDatagrid.SelectedRows.Count > 0)
            {
                if (e.Control && e.KeyCode == Keys.D)
                {
                    if (MessageBox.Show("Do you want to delete the selected item(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
        }
        //Delete using Del Toolstrip
        private async void DeleteusingDelToolstrip(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected item(s)?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                return true;
            }
            catch (Exception e)
            {

                return false;
            }
        }

        //Events
        private void AllItemsDatagrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (AllItemsDatagrid.SelectedRows.Count > 1)
                {
                    edittoolstrip.Visible = false;
                    sep1.Visible = false;
                }
                MenustripforItems.Show(Cursor.Position);
            }
        }
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ShowAddItemModal();
        }

        private async void bunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            
            Allitems = new List<Items>();
            Allitems = await itemservices.SearchItems(new SearchItem()
                        {
                            SearchValue = bunifuTextBox1.Text,
                            PageNumber = 1,
                            ItemperPage = 10
                        });
            AllItemsDatagrid.Rows.Clear();
            foreach (var item in Allitems)
            {
                int rowindex = AllItemsDatagrid.Rows.Add();
                DataGridViewRow row = AllItemsDatagrid.Rows[rowindex];

                row.Cells["RowCol"].Value = item.Row;
                row.Cells["IdCol"].Value = item.ItemID;
                row.Cells["ItemCodeCol"].Value = item.ItemCode;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["StocksCol"].Value = item.BalanceStocks;
                row.Cells["PriceCol"].Value = item.ItemPrice;
                row.Cells["StatusCol"].Value = item.IsActive == true ? "Active" : "Not active";
            }

        }
    }
}
