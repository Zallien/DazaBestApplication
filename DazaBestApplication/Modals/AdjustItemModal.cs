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
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class AdjustItemModal : Form
    {
        private List<AdjustItemDisplay> _pickedItems = new List<AdjustItemDisplay>();
        private GetAvailableItemswithpagination _getavailableitemswithpagination;
        private PurchaseitemServices PurchaseitemServices;
        private List<Guid> AllSelectedProducts;
        private AdjustItemModalViewModel adjustItemModalViewModel;


        //for Products Pagination
        private int Productcurrentpage = 1;
        private int Productitemperpage = 12;
        private int Producttotalpage = 0;
        private int Producttotalitem = 0;


        //Constructor
        public AdjustItemModal(AdjustItemModalViewModel _AdjustItemModalViewModel)
        {
            InitializeComponent();
            adjustItemModalViewModel = _AdjustItemModalViewModel;
        }
        //Open All Product Panel
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



        //Main Load
        private void AdjustItemModal_Load(object sender, EventArgs e)
        {
            AllPickedItems.RowTemplate.Height = 24;
        }


        private void AllPickedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void letters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AllPickedItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;
            const int LETTER_COLUMN_INDEX = 3;

            if (AllPickedItems.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
                else if (AllPickedItems.CurrentCell.ColumnIndex == LETTER_COLUMN_INDEX)
                {
                    TextBox textBox1 = e.Control as TextBox;
                    if (textBox1 != null)
                    {
                        textBox1.KeyPress -= new KeyPressEventHandler(letters_KeyPress);
                        textBox1.KeyPress += new KeyPressEventHandler(letters_KeyPress);
                    }
                }
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            await OpenAllProductsPanel();
        }
    }
}
