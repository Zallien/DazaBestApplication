using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class PurchaseItemmodal : Form
    {
        private PurchaseItemModal _purchaseitemmodal;
        private PurchaseitemServices PurchaseitemServices;
        private GetAvailableItemswithpagination _getavailableitemswithpagination;
        private List<Guid> AllSelectedProducts;
        private List<PurcahseItemDisplay> _allpickeditems = new List<PurcahseItemDisplay>();
        private bool AllowCalculating = true;
        private decimal? _Grandtotal = 0;
        private Panel overlay;
        private LoggedinAccount _loggedinaccount;

        //for Products Pagination
        private int Productcurrentpage = 1;
        private int Productitemperpage = 12;
        private int Producttotalpage = 0;
        private int Producttotalitem = 0;



        //Constructor
        public PurchaseItemmodal(PurchaseItemModal purchaseitemmodal)
        {
            InitializeComponent();
            _purchaseitemmodal = purchaseitemmodal;
            _loggedinaccount = Program.theLoggedInAccount;
        }
        //Checks Modal Action
        private async Task CheckModalAction()
        {
            _allpickeditems = new List<PurcahseItemDisplay>();
            if (_purchaseitemmodal.Action == "AddItemStock")
            {
                this.Text = "Add Purchase Item";
                AddPurchaseItemButton.Text = "Add Purchase Item";
                removeitempickedbutton.Visible = true;
                preparedbylbl.Text = Program.theLoggedInAccount.Fullname;
            }
            else if (_purchaseitemmodal.Action == "ViewPurcahseItem")
            {
                this.Text = "Edit Purchase Item";
                AddPurchaseItemButton.Text = "Update Purchase Item";
                foreach (var item in _purchaseitemmodal.ForViewOnly._PurchaseItemDetails)
                {
                    _allpickeditems.Add(new PurcahseItemDisplay()
                    {
                        ItemName = item.ItemName,
                        ItemID = item.ItemID,
                        Unitprice = item.Priceperunit,
                        Quantity = item.Quantity,
                        GrandTotal = item.Priceperunit * item.Quantity
                    });
                }
                await PopulateAllPickedItemsDatagrid();
                Modaltitle.Text = _purchaseitemmodal.ForViewOnly._PurcahseItemHeader.Purchasenumber;
                removeitempickedbutton.Visible = false;
                preparedbylabel.Text = _purchaseitemmodal.Operatedby;
                bunifuButton1.Visible = false;
            }
        }
        //Main Load
        private async void PurchaseItemmodal_Load(object sender, EventArgs e)
        {
            AllPickedItems.ColumnHeadersHeight = 30; //Set the height of the column headers to 30 pixels
            AllSelectedProducts = new List<Guid>();
            await CheckModalAction();
            Grandtotalvaluelabel.Text = _Grandtotal.ToString();
        }
        //OpenAllProductsPanel
        private async Task OpenAllProductsPanel()
        {
            await PopulatAllItemDataGrid();
            //Generate a Overlay Panel
            overlay = new Panel();
            overlay.Location = new Point(0, 0);
            overlay.Parent = this;
            overlay.Size = this.Size;
            overlay.BackColor = Color.FromArgb(77, 0, 0, 0);
            overlay.BringToFront();

            //Set Datagrid Properties
            AllItemDatagridview.ColumnHeadersHeight = 26;
            Size _allppanelsize = AllProductsContainer.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            AllProductsContainer.Location = _allproductlocation;
            AllProductsContainer.Visible = true;
            AllProductsContainer.BringToFront();
        }
        //Populate All Item DataGrid
        private async Task PopulatAllItemDataGrid()
        {
            //Load All Available Products
            List<Items> _allproducts = await GetAllAvailableProducts();

            AllItemDatagridview.Rows.Clear();
            foreach (var item in _allproducts)
            {
                int rowindex = AllItemDatagridview.Rows.Add();
                DataGridViewRow row = AllItemDatagridview.Rows[rowindex];
                row.Cells["ALLI_ItemIdCol"].Value = item.ItemID;
                row.Cells["ALLI_ItemNameCol"].Value = item.ItemName;
                row.Height = 24;
                row.Cells["ALLI_ItemCodeCol"].Value = item.ItemCode;
            }
        }
        //Get All Available Products
        private async Task<List<Items>> GetAllAvailableProducts()
        {
            _getavailableitemswithpagination = new GetAvailableItemswithpagination()
            {
                Pagenumber = Productcurrentpage,
                Itemperpage = Productitemperpage,
                Searchvalue = "",
                AllSelectedItem = AllSelectedProducts
            };


            PurchaseitemServices = new PurchaseitemServices(new BackEndDBContext());
            var _allproducts = await PurchaseitemServices.GetAllActiveProducts(_getavailableitemswithpagination);
            return _allproducts;
        }
        //Get the Picked Item
        private async Task<PurcahseItemDisplay> GetThePickedItem(Guid ItemID)
        {
            PurchaseitemServices = new PurchaseitemServices(new BackEndDBContext());
            var _pickeditem = await PurchaseitemServices.GetPickedItem(ItemID);
            return _pickeditem;
        }
        // Display it in the All item datagridview
        private async Task AddPickedItemtoList(Guid ItemID)
        {
            PurcahseItemDisplay _newPickedItem = await GetThePickedItem(ItemID);
            _allpickeditems.Add(_newPickedItem);
            await PopulateAllPickedItemsDatagrid();

        }
        //Populate All Picked Item DataGrid
        private async Task PopulateAllPickedItemsDatagrid()
        {
            AllPickedItems.Rows.Clear();
            foreach (var item in _allpickeditems)
            {
                int _rowindex = AllPickedItems.Rows.Add();
                DataGridViewRow row = AllPickedItems.Rows[_rowindex];
                row.Cells["IdCol"].Value = item.ItemID;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["ItemQuantityCol"].Value = _purchaseitemmodal.Action == "AddItemStock" ? "1" : item.Quantity.ToString();
                row.Cells["ItemPriceCol"].Value = item.Unitprice?.ToString("0.00") ?? "0.00";
                row.Cells["ItemTotalCol"].Value = UpdateTotalAmount(
                    decimal.Parse(row.Cells["ItemQuantityCol"].Value.ToString() ?? "1"),
                    decimal.Parse(row.Cells["ItemPriceCol"].Value.ToString() ?? "0.00")
                    ).Result.ToString();
            }
            if (_purchaseitemmodal.Action == "ViewPurcahseItem")
            {
                AllPickedItems.ReadOnly = true;
                AllPickedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AllPickedItems.AllowUserToAddRows = false;
                AllPickedItems.AllowUserToDeleteRows = false;
            }
            else
            {
                AllPickedItems.ReadOnly = false;
                AllPickedItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AllPickedItems.AllowUserToAddRows = false;
                AllPickedItems.AllowUserToDeleteRows = true;
            }
            await CalculateGrandtotal();
        }
        //Close AllItems Panel
        private void CloseAllItemsPanel()
        {
            AllProductsContainer.Visible = false;
            if (overlay != null)
            {
                overlay.Dispose();
            }
        }
        //Update The Total Amount for each Picked Item --First Time Load or when the datagridview value changed
        private async Task<decimal> UpdateTotalAmount(decimal quantity, decimal unitprice)
        {
            decimal _thetotal = quantity * unitprice;
            return _thetotal;
        }
        //Update the Total Amount of Selected Row by rowindex
        private async Task UpdateTheTotalAmountofSelectedRow(int rowindex, DataGridViewCellEventArgs e)
        {
            try
            {
                if (AllPickedItems.Rows.Count > 0 && AllowCalculating == true)
                {
                    AllPickedItems.Rows[e.RowIndex].Cells["ItemTotalCol"].Value = UpdateTotalAmount(
                    decimal.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemQuantityCol"].Value.ToString() ?? "1"),
                    decimal.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value.ToString() ?? "0.00")
                    ).Result.ToString("0.00");

                    //Update quantiy and priceperunit
                    Guid ItemId = Guid.Parse(AllPickedItems.Rows[e.RowIndex].Cells["IdCol"].Value.ToString());
                    var item = _allpickeditems.FirstOrDefault(e => e.ItemID == ItemId);
                    item.Quantity = decimal.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemQuantityCol"].Value.ToString() ?? "1");
                    item.Unitprice = decimal.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value.ToString() ?? "0.00");
                    await CalculateGrandtotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        //prevents letters
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }


        //Add Purchase Item
        private async Task AddPurchaseItem()
        {
            List<InsertPurchaseItem_Details> _allpurchasedetails = new List<InsertPurchaseItem_Details>();
            _allpurchasedetails = (from DataGridViewRow row in AllPickedItems.Rows
                                   select new InsertPurchaseItem_Details()
                                   {
                                       ItemID = Guid.Parse(row.Cells["IdCol"].Value.ToString()),
                                       Quantity = decimal.Parse(row.Cells["ItemQuantityCol"].Value.ToString()),
                                       Unitprice = decimal.Parse(row.Cells["ItemPriceCol"].Value.ToString())
                                   }).ToList();
            InsertPurchaseItem _newpurchaseitem = new InsertPurchaseItem()
            {
                Addedby = _loggedinaccount.AccountId,
                PurchaseItemDetails = _allpurchasedetails
            };

            //Call the service to add the purchase item
            PurchaseitemServices = new PurchaseitemServices(new BackEndDBContext());
            bool isadded = await PurchaseitemServices.AddPurchaseItem(_newpurchaseitem);
            if (isadded)
            {
                await PurchaseItemEventHandlers.InvokePurchaseItemChanged();
                MessageBox.Show("Purchase Item Added Successfully!");
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Failed to Add Purchase Item.");
            }


        }
        //Remove Selected Item
        private async Task<bool> RemovedSelectedItem()
        {
            bool isDeletedSuccessfully = false;
            try
            {
                if (AllPickedItems.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in AllPickedItems.SelectedRows)
                    {
                        //int index = row.Index;
                        Guid Id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllPickedItems.Rows.Remove(row);
                        AllSelectedProducts.Remove(Id);

                        var theadjusteditem = _allpickeditems.Where(x => x.ItemID == Id).FirstOrDefault();
                        if (theadjusteditem != null)
                        {
                            _allpickeditems.Remove(theadjusteditem);
                        }

                    }
                    isDeletedSuccessfully = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return isDeletedSuccessfully;
        }
        //Remove Item from PickedItems
        private async Task<bool> RemoveItemfrompickeditems(List<Guid> AllselecteditemsId)
        {
            try
            {
                var selectedidset = new HashSet<Guid>(AllselecteditemsId);
                _allpickeditems.RemoveAll(picked => selectedidset.Contains(picked.ItemID));


                await PopulateAllPickedItemsDatagrid();
                CalculateGrandtotal();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Remove Function
        private async Task RemoveItem()
        {

            //List<Guid> allselecteditems = new();
            //foreach (DataGridViewRow _row in AllPickedItems.SelectedRows)
            //{
            //    if (_row.Cells["IdCol"].Value != null)
            //    {
            //        allselecteditems.Add(Guid.Parse(_row.Cells["IdCol"].Value.ToString()));
            //    }
            //}
            //bool isRemoveSuccess = await RemoveItemfrompickeditems(allselecteditems);
            //if (isRemoveSuccess)
            //{
            //    MessageBox.Show("Successfully Removed", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if (!AllowCalculating)
            //{
            //    AllowCalculating = true;
            //}

            bool isDeletedSuccessfully = await RemovedSelectedItem();
            if (isDeletedSuccessfully == true)
            {
                MessageBox.Show("Removed Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Calculate GrandTotal
        private async Task CalculateGrandtotal()
        {
            _Grandtotal = 0;
            foreach (var item in _allpickeditems)
            {
                decimal? totalperitem = item.Quantity * item.Unitprice;
                _Grandtotal += totalperitem;
            }
            Grandtotalvaluelabel.Text = _Grandtotal.ToString();
        }

        //Pagination for Items
        //Get Total Pages
        private async Task Gettotalpages()
        {
            using (var context = new BackEndDBContext())
            {
                PurchaseitemServices = new PurchaseitemServices(context);
                Producttotalpage = await PurchaseitemServices.GettotalPages(Productitemperpage);
            }
        }
        //Check Page Number
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            //await Gettotalpages();
            if (Productcurrentpage == 1)
            {
                buttonprev.Enabled = false;
            }
            else
            {
                buttonprev.Enabled = true;
            }
            if (Productcurrentpage >= Producttotalpage)
            {
                buttonnext.Enabled = false;
            }
            else
            {
                buttonnext.Enabled = true;
            }
            pagenumberindicator.Text = $"{Productcurrentpage} / {Producttotalpage}";
        }


        //Press Prev Button
        private async Task PressPrevButton()
        {
            await Gettotalpages();
            if (Productcurrentpage > 0)
            {
                Productcurrentpage--;
                await CheckPageNumber();
                await PopulatAllItemDataGrid();
            }
        }
        //Press Next Buttons
        private async Task PressNextButton()
        {
            await Gettotalpages();
            if (Productcurrentpage < Producttotalpage)
            {
                Productcurrentpage++;
                await CheckPageNumber();
                await PopulatAllItemDataGrid();
            }
        }







        //----Event Handlers----//
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenAllProductsPanel();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private async void AllItemDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AllItemDatagridview.Columns[e.ColumnIndex].Name == "ALLI_ActionCol")
            {
                AllSelectedProducts.Add(Guid.Parse(AllItemDatagridview.Rows[e.RowIndex].Cells["ALLI_ItemIdCol"].Value.ToString()));
                AddPickedItemtoList(Guid.Parse(AllItemDatagridview.Rows[e.RowIndex].Cells["ALLI_ItemIdCol"].Value.ToString()));
                await PopulatAllItemDataGrid();
            }
        }
        private void CloseAllPModal_Click(object sender, EventArgs e)
        {
            CloseAllItemsPanel();
        }
        private async void AllPickedItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AllProductsContainer.Visible == false && _purchaseitemmodal.Action == "AddItemStock" &&
                    (AllPickedItems.Columns[e.ColumnIndex].Name == "ItemQuantityCol" || AllPickedItems.Columns[e.ColumnIndex].Name == "ItemPriceCol"))
            {
                await UpdateTheTotalAmountofSelectedRow(e.RowIndex, e);
            }

            if (e.RowIndex >= 0 && AllPickedItems.Columns[e.ColumnIndex].Name == "ItemPriceCol")
            {
                if (decimal.TryParse(AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value?.ToString(), out decimal value))
                {
                    value = Math.Round(value, 2, MidpointRounding.AwayFromZero);
                    AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value = value.ToString("0.00");
                }
                else
                {
                    AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value = "0.00";
                }
            }
        }
        private async void AddPurchaseItemButton_Click(object sender, EventArgs e)
        {
            if (AllPickedItems.Rows.Count == 0)
            {
                MessageBox.Show("Please pick at least one item to proceed.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (AllPickedItems.Focused)
                {
                    AllPickedItems.EndEdit();
                }
                await AddPurchaseItem();
            }

        }
        private async void removeitempickedbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Delete All Selected Item/s?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AllowCalculating = false;
                await RemoveItem();
            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        private void AllPickedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void AllPickedItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int COl1 = 2;
            const int COl2 = 3;
            TextBox textBox = e.Control as TextBox;
            if (textBox != null)
            {
                if (AllPickedItems.CurrentCell.ColumnIndex == COl1 || AllPickedItems.CurrentCell.ColumnIndex == COl2)
                {
                    textBox.KeyPress -= NumbersOnly_KeyPress;
                    textBox.KeyPress += NumbersOnly_KeyPress;
                }
                else
                {
                    textBox.KeyPress -= NumbersOnly_KeyPress;
                }
            }
        }
        private void buttonprev_Click(object sender, EventArgs e)
        {
            PressPrevButton();
        }
        private void buttonnext_Click(object sender, EventArgs e)
        {
            PressNextButton();
        }
    }
}
