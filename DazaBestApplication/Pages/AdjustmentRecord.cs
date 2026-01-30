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
using SystemBackEnd.ServiceModels;
using SystemBackEnd;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{

    public partial class AdjustmentRecord : Form
    {
        List<AdjustmentReportDetails> AllAdjustmentDetails = new List<AdjustmentReportDetails>();
        List<AdjustmentReportDetails> forprinting = new List<AdjustmentReportDetails>();
        List<AdjustmentReportDetailsforPrint> adjustmentReportDetailsforPrints = new();
        AdjusmentReportServices adjustmentreportservice;
        RecordsFilterSearch recordsFilterSearch;
        private Form MainForm;
        private DateTime datenow = DateTime.Now.Date;


        #region Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 1;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Today;
        private DateTime ToDateFilter = DateTime.Now;
        private int totalpages = 0;

        #endregion
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

        //Contrutor
        public AdjustmentRecord(Form mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }

        //Get AdjustmentDetails
        private async Task GetAdjustmentDetails()
        {
            try
            {
                recordsFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };
                adjustmentreportservice = new AdjusmentReportServices(new BackEndDBContext());
                AllAdjustmentDetails = await adjustmentreportservice.GetAdjustmentDetails(recordsFilterSearch);
            }
            catch (Exception e)
            {

            }
        }
        //Populate Datagrid
        private async Task PopulateAlldjustDetailsDatagrid()
        {
            await GetAdjustmentDetails();

            // Datagrid AllsaleDatagrid
            AllAdjustmentRecordsDatagrid.Rows.Clear();
            foreach (var item in AllAdjustmentDetails)
            {
                int rowindex = AllAdjustmentRecordsDatagrid.Rows.Add();
                DataGridViewRow row = AllAdjustmentRecordsDatagrid.Rows[rowindex];
                row.Cells["IdCol"].Value = item.ReferenceDetailsId;
                row.Cells["ReferenceNumberCol"].Value = item.ReferenceNumber;
                row.Cells["ItemNameCol"].Value = item.ItemName;
                row.Cells["QuantityCol"].Value = item.Quantity;
                row.Cells["ReasonCol"].Value = item.Reason;
            }
        }
        //Search Box Text Changed
        private async Task SearchSaleRecords()
        {
            SearchValue = SearchBox.Text.Trim();
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateAlldjustDetailsDatagrid();
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
                    ToDateFilter = DateTime.Now.Date;
                    break;
                case "This Month":
                    FromDateFilter = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    ToDateFilter = DateTime.Now.Date;
                    break;
                case "This Year":
                    FromDateFilter = new DateTime(DateTime.Now.Year, 1, 1);
                    ToDateFilter = DateTime.Now.Date;
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
            await PopulateAlldjustDetailsDatagrid();
            await GetTotalPages();
            await CheckPageNumber();
            
            PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label
        }




        #region pagination Logic
        private async Task GetTotalPages()
        {
            try
            {
                var db = new BackEndDBContext();
                var adjustmentservice = new AdjusmentReportServices(db);

                recordsFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate =  FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };

                totalpages = await adjustmentservice.GetTotalPages(recordsFilterSearch);
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
                await PopulateAlldjustDetailsDatagrid();
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
                await PopulateAlldjustDetailsDatagrid();
                PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label

            }
        }
        //Change the Date Filter
        private async Task ChangeDateFilter()
        {
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
                await PopulateAlldjustDetailsDatagrid();
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
        private async void AdjustmentRecord_Load(object sender, EventArgs e)
        {
            //Set DatePickers
            fromdatetxt.MaxDate = DateTime.Now;
            fromdatetxt.MinDate = DateTime.Now.AddYears(-10);
            todatetxt.MaxDate = DateTime.Now;
            fromdatetxt.Value = FromDateFilter;
            todatetxt.Value = ToDateFilter;
            daterangepanel.Visible = false;
            await GetTotalPages();
            await CheckPageNumber();
            await PopulateAlldjustDetailsDatagrid();
            await PopulateDateFilter();
            await ReportFilterChanged();
            PaginationLabel.Text = $"{PageNumber} / {totalpages}";//Pagination Label

        }

        #region Form Events
        private async void PrintBtn_Click(object sender, EventArgs e)
        {
            //print for report
            try
            {
                forprinting = new List<AdjustmentReportDetails>();
                adjustmentReportDetailsforPrints = new List<AdjustmentReportDetailsforPrint>();
                adjustmentreportservice = new AdjusmentReportServices(new BackEndDBContext());
                recordsFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = 0,
                    ItemperPage = 99999
                };
                forprinting = await adjustmentreportservice.GetAdjustmentDetails(recordsFilterSearch);
                AdjustmentReportForm adjustmentReportForm = new AdjustmentReportForm(forprinting, FromDateFilter, ToDateFilter);
                adjustmentReportForm.Show();

            }
            catch (Exception ex)
            {

            }
        }
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }
        private void todatetxt_ValueChanged(object sender, EventArgs e)
        {
            ChangeDateFilter();
        }
        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            SearchSaleRecords();
        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            todatetxt.Value = datenow;
            fromdatetxt.Value = datenow;
        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            daterangepanel.Visible = false;
        }

        private void RecordFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            ReportFilterChanged();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            daterangepanel.Visible = true;
        }

        private void fromdatetxt_MouseEnter(object sender, EventArgs e)
        {
            Prevfrommonth = fromdatetxt.Value.Month;
            Prevtomonth = todatetxt.Value.Month;
        }
    }
}
