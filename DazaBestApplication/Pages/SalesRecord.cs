using Bunifu.UI.WinForms.BunifuButton;
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
        private DateTime FromDateFilter = DateTime.Today;
        private DateTime ToDateFilter = DateTime.Now;
        private int totalpages = 0;

        private List<string> ReportFilter = new List<string>()
        {
            "Today",
            "This Week",
            "This Month",
            "This Year",
            "All",
            "Custom"
        };
        private int Prevfrommonth;
        private int Prevtomonth;


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
                    FromDate = FromDateFilter,
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
            AllsaleDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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
                    FromDate = FromDateFilter,
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
            try
            {
                if (RecordFilter.Text != "Custom")
                {
                    return;
                }

                int newfrommonth = fromdatetxt.Value.Month;
                int newtomonth = todatetxt.Value.Month;
                if (newfrommonth != Prevfrommonth)
                {
                    Prevfrommonth = newfrommonth;
                    int lastDay = DateTime.DaysInMonth(fromdatetxt.Value.Year, newfrommonth);
                    fromdatetxt.Value = new DateTime(fromdatetxt.Value.Year, newfrommonth, lastDay);
                }
                if (newtomonth != Prevtomonth)
                {
                    Prevtomonth = newtomonth;
                    int lastDay = DateTime.DaysInMonth(todatetxt.Value.Year, newtomonth);
                    todatetxt.Value = new DateTime(todatetxt.Value.Year, newtomonth, lastDay);

                }


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
            catch (Exception ex)
            {

            }
        }
        //Populate Date Filter
        private async Task PopulateDateFilter()
        {
            RecordFilter.Items.Clear();
            foreach (var filter in ReportFilter)
            {
                RecordFilter.Items.Add(filter);
            }
            RecordFilter.SelectedIndex = 0;
            await ReportFilterChanged();
        }






        private async Task ReportFilterChanged()
        {
            bunifuButton2.Visible = false;
            switch (RecordFilter.Text)
            {
                case "Today":
                    FromDateFilter = DateTime.Today;
                    ToDateFilter = DateTime.Now;
                    break;
                case "This Week":
                    int diff = (7 + (DateTime.Now.DayOfWeek - DayOfWeek.Monday)) % 7;
                    FromDateFilter = DateTime.Now.AddDays(-1 * diff).Date;
                    ToDateFilter = DateTime.Now;
                    break;
                case "This Month":
                    FromDateFilter = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    ToDateFilter = DateTime.Now;
                    break;
                case "This Year":
                    FromDateFilter = new DateTime(DateTime.Now.Year, 1, 1);
                    ToDateFilter = DateTime.Now;
                    break;
                case "All":
                    FromDateFilter = fromdatetxt.MinDate;
                    ToDateFilter = DateTime.Now.Date;
                    break;
                case "Custom":
                    fromdatetxt.Value = datenow;
                    todatetxt.Value = datenow;
                    bunifuButton2.Visible = true;
                    daterangepanel.Parent = this;
                    daterangepanel.Location = new Point((this.Width - daterangepanel.Width) / 2, (this.Height - daterangepanel.Height) / 2);
                    daterangepanel.BringToFront();
                    break;
                default:
                    break;
            }
            PageNumber = 1;
            await PopulateAllSaleReportDatagrid();
            await GetTotalPages();
            await CheckPageNumber();
            PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
        }


        #endregion

        //Main Load
        private async void SalesRecord_Load(object sender, EventArgs e)
        {
            fromdatetxt.MaxDate = DateTime.Now;
            fromdatetxt.MinDate = DateTime.Now.AddYears(-10);
            todatetxt.MaxDate = DateTime.Now;
            fromdatetxt.Value = FromDateFilter;
            todatetxt.Value = ToDateFilter;
            daterangepanel.Visible = false;
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateAllSaleReportDatagrid();
            await PopulateDateFilter();
            await ReportFilterChanged();
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
                    FromDate = FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = 99999
                };
                SaleReportDetailsforPrints = await SaleReportServices.GetSaleReportforPrinting(saleRecordFilterSearch);
                MonthlySalesReportForm monthlySalesReportForm = new MonthlySalesReportForm(SaleReportDetailsforPrints, FromDateFilter, ToDateFilter);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            daterangepanel.Visible = false;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }

        private void RecordFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            ReportFilterChanged();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            daterangepanel.Visible = true;
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
