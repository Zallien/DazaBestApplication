using Bunifu.UI.WinForms;
using DazaBestApplication.Reports;
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
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class InventoryRecord : Form
    {
        private Form MainForm;
        private List<ItemsReportDetails> itemsReportDetailsList = new List<ItemsReportDetails>();
        private List<ItemsReportDetails> itemsReportDetailsforPrints = new();
        private ItemReportServices ItemReportServices;
        private SearchItem searchItem;

        //Pagination
        private string SearchValue = "";
        private int PageNumber = 0;
        private int ItemPerPaeg = 12;

        public InventoryRecord(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Get Items Report Details
        private async Task GetItemsReportDetails()
        {
            try
            {
                searchItem = new SearchItem()
                {
                    SearchValue = SearchValue,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                itemsReportDetailsList = new List<ItemsReportDetails>();
                ItemReportServices = new ItemReportServices(new SystemBackEnd.BackEndDBContext());
                itemsReportDetailsList = await ItemReportServices.GetItemsReportDetails(searchItem);

            }
            catch (Exception e)
            {
                
            }
        }
        //Populate Data Grid
        private async Task PopulateDataGrid()
        {
            try
            {
                await GetItemsReportDetails();

                // Datagrid AllsaleDatagrid
                AllItemDatagrid.Rows.Clear();
                foreach (var item in itemsReportDetailsList)
                {

                    int rowindex = AllItemDatagrid.Rows.Add();
                    DataGridViewRow row = AllItemDatagrid.Rows[rowindex];
                    row.Cells["IdCol"].Value = item.ItemId;
                    row.Cells["ItemNameCol"].Value = item.ItemName;
                    row.Cells["ItemCodeCol"].Value = item.ItemCode;
                    row.Cells["DateCol"].Value = item.DateCreated.Date;
                    row.Cells["StockCol"].Value = item.BalanceStock;
                    row.Cells["ItemPriceCol"].Value = item.Price;
                }
            }
            catch (Exception e)
            {
                
            }
        }
        

        //Events
        private async void PrintBtn_Click(object sender, EventArgs e)
        {
            //for printing
            try {
                searchItem = new SearchItem()
                {
                    SearchValue = SearchValue,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                itemsReportDetailsList = new List<ItemsReportDetails>();
                ItemReportServices = new ItemReportServices(new SystemBackEnd.BackEndDBContext());
                itemsReportDetailsList = await ItemReportServices.GetItemsReportDetails(searchItem);
                //call the form for the report
                InventoryReportForm inventoryReportForm = new InventoryReportForm(itemsReportDetailsList);
                inventoryReportForm.Show();

            }
            catch (Exception ex)
            {

            }
            
           

        }


        //Main Load
        private async void InventoryRecord_Load(object sender, EventArgs e)
        {
            await PopulateDataGrid();
        }
    }
}
