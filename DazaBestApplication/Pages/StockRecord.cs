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
    public partial class StockRecord : Form
    {
        private Form MainForm;
        private List<StockInReportsDetails> stockindetailslist = new List<StockInReportsDetails>();
        private StockInReportServices StockInReportServices;
        private RecordsFilterSearch RecordFilterSearch;

        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 0;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Now;
        private DateTime ToDateFilter = DateTime.Now;

        public StockRecord(Form mainForm)
        {

            InitializeComponent();
            MainForm = mainForm;

            PrintPanel.Visible = false;
            PrintBtn.MouseEnter += ShowDropdown;
            PrintBtn.MouseLeave += HideDropdown_Check;
            PrintPanel.MouseEnter += ShowDropdown;
            PrintPanel.MouseLeave += HideDropdown_Check;
            foreach (Control ctrl in PrintPanel.Controls)
            {
                ctrl.MouseEnter += ShowDropdown;
                ctrl.MouseLeave += HideDropdown_Check;
                ctrl.Click += (s, e) => { PrintPanel.Visible = false; };
            }

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





        //Events
        private void ShowDropdown(object sender, EventArgs e)
        {
            PrintPanel.Visible = true;
        }
        private async void HideDropdown_Check(object sender, EventArgs e)
        {
            await Task.Delay(100);
            if (this.IsDisposed || panel2.IsDisposed || PrintBtn.IsDisposed)
                return;

            if (!PrintBtn.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !PrintPanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                PrintPanel.Visible = false;
            }
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }



        //Main Load
        private async void StockRecord_Load(object sender, EventArgs e)
        {
            await PopulateDatagrid();
        }
    }
}
