using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.ServiceModels;
using SystemBackEnd;
using SystemBackEnd.Services;
using DazaBestApplication.Reports;
using System.Drawing.Printing;


namespace DazaBestApplication.Pages
{
    public partial class StockRecord : Form
    {
        private Form MainForm;
        private List<StockInReportsDetails> stockindetailslist = new List<StockInReportsDetails>();

        private StockInReportServices StockInReportServices;
        private List<StockInReportsDetails> stockindetailsforPrints = new();
        private RecordsFilterSearch RecordFilterSearch;

        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 1;
        private int ItemPerPaeg = 12;
        private int totalpage = 0;
        private DateTime FromDateFilter = DateTime.Now;
        private DateTime ToDateFilter = DateTime.Now;

        public StockRecord(Form mainForm)
        {

            InitializeComponent();
            mainForm = mainForm;
            MainForm = mainForm;
        }
        //Load Stocks In Records
        private async Task LoadStockInDetails()
        {
            try
            {
                stockindetailslist = new List<StockInReportsDetails>();
                StockInReportServices = new StockInReportServices(new BackEndDBContext());
                RecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };

                stockindetailslist = await StockInReportServices.GetStockInDetails(RecordFilterSearch);
            }
            catch (Exception e)
            {

            }
        }
        //Populate Datagrid
        private async Task PopulateDatagrid()
        {
            try
            {
                await LoadStockInDetails();

                // Datagrid AllsaleDatagrid
                AllPurchaseItemDetailsRecordsDatagrid.Rows.Clear();
                foreach (var item in stockindetailslist)
                {

                    int rowindex = AllPurchaseItemDetailsRecordsDatagrid.Rows.Add();
                    DataGridViewRow row = AllPurchaseItemDetailsRecordsDatagrid.Rows[rowindex];
                    row.Cells["IdCol"].Value = item.PurchaseItemDetailsId;
                    row.Cells["PurchaseItemNumberCol"].Value = item.PurchaseItemNumber;
                    row.Cells["DateCol"].Value = item.Date;
                    row.Cells["ItemCol"].Value = item.ItemName;
                    row.Cells["QuantityCol"].Value = item.Quantity;
                    row.Cells["TotalCol"].Value = item.TotalPrice;
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
            await PopulateDatagrid();
            PaginationLabel.Text = $"{PageNumber} / {totalpage}";//Pagination Label
        }



        #region Pagination Function
        private async Task GetTotalPages()
        {
            try
            {
                var db = new BackEndDBContext();
                var stockinreportservies = new StockInReportServices(db);

                RecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                totalpage = await stockinreportservies.Gettotalpage(RecordFilterSearch);
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
            if (PageNumber >= totalpage)
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

            if (PageNumber < totalpage)
            {
                PageNumber++;
                await CheckPageNumber();
                await PopulateDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpage}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton()
        {
            if (PageNumber > 1)
            {
                PageNumber--;
                await CheckPageNumber();
                await PopulateDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpage}";//Pagination Label

            }
        }
        //Change the Date Filter
        private async Task ChangeDateFilter()
        {
            if (fromdatetxt.Value < todatetxt.Value)
            {
                FromDateFilter = fromdatetxt.Value;
                ToDateFilter = todatetxt.Value;
                await GetTotalPages();
                await CheckPageNumber();
                await PopulateDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpage}";//Pagination Label
            }
            else
            {
                MessageBox.Show("Invalid Date Range. Please ensure that the 'From' date is earlier than or equal to the 'To' date.", "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fromdatetxt.Value = FromDateFilter;
                todatetxt.Value = ToDateFilter;
            }
        }
        #endregion



        //Events

        private async void PrintBtn_Click(object sender, EventArgs e)
        {
            ///for printing
            stockindetailslist = new List<StockInReportsDetails>();
            StockInReportServices = new StockInReportServices(new BackEndDBContext());
            RecordFilterSearch = new RecordsFilterSearch()
            {
                SearchValue = SearchValue,
                FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                ToDate = ToDateFilter,
                PageNumber = PageNumber,
                ItemperPage = ItemPerPaeg
            };

            stockindetailslist = await StockInReportServices.GetStockInDetails(RecordFilterSearch);
            StockInReportForm stockInReportForm = new StockInReportForm(stockindetailslist, fromdatetxt.Value, todatetxt.Value);
            stockInReportForm.Show();

        }



        //Main Load
        private async void StockRecord_Load(object sender, EventArgs e)
        {
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateDatagrid();
            PaginationLabel.Text = $"{PageNumber} / {totalpage}";//Pagination Label
        }

        private void fromdatetxt_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateFilter();
        }

        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }

        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            SearchFunction();
        }
    }
}
