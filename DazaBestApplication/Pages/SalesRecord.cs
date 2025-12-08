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
using SystemBackEnd.Services;
using SystemBackEnd;
using DazaBestApplication.Reports;

namespace DazaBestApplication.Pages
{
    public partial class SalesRecord : Form
    {
        private Form MainForm;
        private List<SaleReportDetails> SaleReportHeaders;
        private List<SaleReportDetailsforPrint> SaleReportDetailsforPrints;
        private RecordsFilterSearch saleRecordFilterSearch;
        private SaleReportServices SaleReportServices = new SaleReportServices(new BackEndDBContext());
        private DateTime datenow = DateTime.Now.Date;


        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 1;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Now;
        private DateTime ToDateFilter = DateTime.Now;
        private int totalpages = 0;



        public SalesRecord(Form mainForm)
        {
            InitializeComponent();
            mainForm = mainForm;

            MainForm = mainForm;
        }
        //Load Headers
        private async Task LoadSaleReportDetails()
        {
            try
            {

                SaleReportHeaders = new List<SaleReportDetails>();
                saleRecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                SaleReportServices = new SaleReportServices(new BackEndDBContext());
                SaleReportHeaders = await SaleReportServices.GetSaleReportDetails(saleRecordFilterSearch);
                /*MonthlySalesReportForm monthlySalesReportForm = new MonthlySalesReportForm();*/



            }
            catch (Exception e)
            {

            }
        }
        //Populate AllSaleReportHeader Datagrid
        private async Task PopulateAllSaleReportDatagrid()
        {
            await LoadSaleReportDetails();

            // Datagrid AllsaleDatagrid
            AllsaleDatagrid.Rows.Clear();
            foreach (var item in SaleReportHeaders)
            {

                int rowindex = AllsaleDatagrid.Rows.Add();
                DataGridViewRow row = AllsaleDatagrid.Rows[rowindex];
                row.Cells["IdCol"].Value = item.TransactionDetailsId;
                row.Cells["PurchaseNumberCol"].Value = item.TransactionNumber;
                row.Cells["ProductNameCol"].Value = item.ProductName;
                row.Cells["DateCol"].Value = item.Date;
                row.Cells["CashierCol"].Value = item.CashierName;


            }
        }
        //Search Function
        private async Task SearchSaleRecords()
        {
            SearchValue = SearchBox.Text.Trim();
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateAllSaleReportDatagrid();
        }

        #region pagination
        private async Task GetTotalPages()
        {
            try
            {
                var db = new BackEndDBContext();
                var saleReportServices = new SaleReportServices(db);

                SaleReportHeaders = new List<SaleReportDetails>();
                saleRecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                totalpages = await saleReportServices.GetTotalPages(saleRecordFilterSearch);
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
                await PopulateAllSaleReportDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton()
        {
            if (PageNumber > 1)
            {
                PageNumber--;
                await CheckPageNumber();
                await PopulateAllSaleReportDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label

            }
        }
        //Change the Date Filter
        private async Task ChangeDateFilter()
        {
            if (fromdatetxt.Value.Date <= todatetxt.Value.Date)
            {
                FromDateFilter = fromdatetxt.Value;
                ToDateFilter = todatetxt.Value;
                await GetTotalPages();
                await CheckPageNumber();
                await PopulateAllSaleReportDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
            }
            else
            {
                MessageBox.Show("Invalid Date Range. Please ensure that the 'From' date is earlier than or equal to the 'To' date.", "Date Range Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fromdatetxt.Value = FromDateFilter;
                todatetxt.Value = ToDateFilter;
            }
        }
        #endregion

        //Main Load
        private async void SalesRecord_Load(object sender, EventArgs e)
        {
            fromdatetxt.MaxDate = DateTime.Now;
            todatetxt.MaxDate = DateTime.Now;
            fromdatetxt.Value = FromDateFilter;
            todatetxt.Value = ToDateFilter;
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateAllSaleReportDatagrid();
            PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
        }

        #region Form Events
        private async void bunifuButton22_Click(object sender, EventArgs e)
        {
            //print the report
            try
            {
                SaleReportDetailsforPrints = new List<SaleReportDetailsforPrint>();
                SaleReportServices = new SaleReportServices(new BackEndDBContext());
                saleRecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = 99999
                };
                SaleReportDetailsforPrints = await SaleReportServices.GetSaleReportforPrinting(saleRecordFilterSearch);
                MonthlySalesReportForm monthlySalesReportForm = new MonthlySalesReportForm(SaleReportDetailsforPrints, fromdatetxt.Value, todatetxt.Value);
                monthlySalesReportForm.Show();
            }
            catch (Exception ex)
            {

            }
        }
        private void AllsaleDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            todatetxt.Value = datenow;
            fromdatetxt.Value = datenow;
        }
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }
        private void fromdatetxt_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateFilter();
        }
        private void todatetxt_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateFilter();
        }
        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            SearchSaleRecords();
        }
        #endregion
    }
}
