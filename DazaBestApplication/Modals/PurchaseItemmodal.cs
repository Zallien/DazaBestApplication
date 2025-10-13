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
            }
        }
        //Main Load
        private async void PurchaseItemmodal_Load(object sender, EventArgs e)
        {
            AllPickedItems.ColumnHeadersHeight = 30; //Set the height of the column headers to 30 pixels
            AllSelectedProducts = new List<Guid>();
            await CheckModalAction();
        }
        //OpenAllProductsPanel
        private async Task OpenAllProductsPanel()
        {
            await PopulatAllItemDataGrid();

            //Set Datagrid Properties
            AllItemDatagridview.ColumnHeadersHeight = 24;
            Size _allppanelsize = AllProductsContainer.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            AllProductsContainer.Location = _allproductlocation;
            AllProductsContainer.Visible = true;

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
                    int.Parse(row.Cells["ItemQuantityCol"].Value.ToString() ?? "1"),
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
                AllPickedItems.SelectionMode = DataGridViewSelectionMode.CellSelect;
                AllPickedItems.AllowUserToAddRows = false;
                AllPickedItems.AllowUserToDeleteRows = true;
            }
        }
        //Close AllItems Panel
        private void CloseAllItemsPanel()
        {
            AllProductsContainer.Visible = false;

        }
        //Update The Total Amount for each Picked Item --First Time Load or when the datagridview value changed
        private async Task<decimal> UpdateTotalAmount(int quantity, decimal unitprice)
        {
            decimal _thetotal = quantity * unitprice;
            return _thetotal;
        }
        //Update the Total Amount of Selected Row by rowindex
        private async Task UpdateTheTotalAmountofSelectedRow(int rowindex, DataGridViewCellEventArgs e)
        {
            try
            {
                AllPickedItems.Rows[e.RowIndex].Cells["ItemTotalCol"].Value = UpdateTotalAmount(
                    int.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemQuantityCol"].Value.ToString() ?? "1"),
                    decimal.Parse(AllPickedItems.Rows[e.RowIndex].Cells["ItemPriceCol"].Value.ToString() ?? "0.00")
                    ).Result.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                                       Quantity = int.Parse(row.Cells["ItemQuantityCol"].Value.ToString()),
                                       Unitprice = decimal.Parse(row.Cells["ItemPriceCol"].Value.ToString())
                                   }).ToList();


            InsertPurchaseItem _newpurchaseitem = new InsertPurchaseItem()
            {
                Addedby = Guid.NewGuid(), //Replace with actual user ID
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
            if(AllPickedItems.Focused)
            {
                AllPickedItems.EndEdit();
            }
            await AddPurchaseItem();
        }
    }
}
