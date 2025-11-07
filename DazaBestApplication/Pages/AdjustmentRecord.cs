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
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    
    public partial class AdjustmentRecord : Form
    {
        List<AdjustmentReportDetails> AllAdjustmentDetails = new List<AdjustmentReportDetails>();
        List<AdjustmentReportDetailsforPrint>  adjustmentReportDetailsforPrints= new();
        AdjusmentReportServices adjustmentreportservice;
        RecordsFilterSearch recordsFilterSearch;


        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 0;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Now;
        private DateTime ToDateFilter = DateTime.Now;

        private Form MainForm;
        public AdjustmentRecord(Form mainForm)
        {
            InitializeComponent();

            MainForm = mainForm;
        }
        //Get A djustmentDetails
        private async Task GetAdjustmentDetails()
        {
            try
            {
                recordsFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
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




        private async void PrintBtn_Click(object sender, EventArgs e)
        {
            //print for report
            try
            {
                adjustmentReportDetailsforPrints = new List<AdjustmentReportDetailsforPrint>();
                adjustmentreportservice = new AdjusmentReportServices(new BackEndDBContext());
                recordsFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter
                };
                adjustmentReportDetailsforPrints = await adjustmentreportservice.GetAdjustmentDetailsForPrinting(recordsFilterSearch);
                AdjustmentReportForm adjustmentReportForm = new AdjustmentReportForm(adjustmentReportDetailsforPrints, bunifuDatePicker1.Value, bunifuDatePicker2.Value);
                adjustmentReportForm.Show();

            }
            catch (Exception ex)
            {

            }
        }


        //Main Load
        private async void AdjustmentRecord_Load(object sender, EventArgs e)
        {
            await PopulateAlldjustDetailsDatagrid();
        }
    }
}
