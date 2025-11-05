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

namespace DazaBestApplication.Pages
{
    public partial class SalesRecord : Form
    {
        private Form MainForm;
        private List<SaleReportDetails> SaleReportHeaders;
        private RecordsFilterSearch saleRecordFilterSearch;
        private SaleReportServices SaleReportServices = new SaleReportServices(new BackEndDBContext());


        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 0;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Now;
        private DateTime ToDateFilter = DateTime.Now;


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


        //Events
      
        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }

        //Main Load
        private async void SalesRecord_Load(object sender, EventArgs e)
        {
            await PopulateAllSaleReportDatagrid();
        }

        private void AllsaleDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {

        }
    }
}
