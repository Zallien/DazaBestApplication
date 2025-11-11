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
        private int PageNumber = 1;
        private int ItemPerPaeg = 12;
        private int totalpages = 0;


        public InventoryRecord(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Main Load
        private async void InventoryRecord_Load(object sender, EventArgs e)
        {
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateDataGrid();
            PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
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
        //Search Function
        private async Task SearchFunction()
        {

            SearchValue = SearchBox.Text.Trim();
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateDataGrid();
        }


        #region Pagination Methods
        private async Task GetTotalPages()
        {
            try
            {
                var db = new BackEndDBContext();
                var inventoryrecordservice = new ItemReportServices(db);

                searchItem = new SearchItem()
                {
                    SearchValue = SearchValue,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                totalpages = await inventoryrecordservice.GetTotalPages(ItemPerPaeg);
            }
            catch (Exception ex)
            {

            }
        }
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (PageNumber == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (PageNumber >= totalpages)
            {
                PaginationNext.Enabled = false;
            }
            else
            {
                PaginationNext.Enabled = true;
            }
        }
        //Pagination Next
        private async void NextButton()
        {

            if (PageNumber < totalpages)
            {
                PageNumber++;
                await CheckPageNumber();
                await PopulateDataGrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton()
        {
            if (PageNumber > 1)
            {
                PageNumber--;
                await GetTotalPages();
                await CheckPageNumber();
                await PopulateDataGrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label

            }
        }
        #endregion


        #region Form Events
        private async void PrintBtn_Click(object sender, EventArgs e)
        {
            //for printing
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
                //call the form for the report
                InventoryReportForm inventoryReportForm = new InventoryReportForm(itemsReportDetailsList);
                inventoryReportForm.Show();

            }
            catch (Exception ex)
            {

            }



        }
        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            SearchFunction();
        }
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }
        #endregion
    }
}
