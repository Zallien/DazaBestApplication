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
        private List<SaleReportHeader> SaleReportHeaders;
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
        //Load Headers
        private async Task LoadAllSaleHeaders()
        {

            try
            {
                SaleReportHeaders = new List<SaleReportHeader>();
                saleRecordFilterSearch = new RecordsFilterSearch()
                {
                    SearchValue = SearchValue,
                    FromDate = (FromDateFilter.Date == DateTime.Now.Date) ? null : FromDateFilter,
                    ToDate = ToDateFilter,
                    PageNumber = PageNumber,
                    ItemperPage = ItemPerPaeg
                };

                SaleReportServices = new SaleReportServices(new BackEndDBContext());
                SaleReportHeaders = await SaleReportServices.GetSaleReportHeaders(saleRecordFilterSearch);
            }
            catch (Exception e)
            {
                
            }
        }
        //Populate AllSaleReportHeader Datagrid
        private async Task PopulateAllSaleReportDatagrid()
        {
            await LoadAllSaleHeaders();

            // Datagrid AllsaleDatagrid
            AllsaleDatagrid.Rows.Clear();
            foreach (var item in SaleReportHeaders)
            {
                int rowindex = AllsaleDatagrid.Rows.Add();
                DataGridViewRow row = AllsaleDatagrid.Rows[rowindex];
                row.Cells["IdCol"].Value = item.TransactionHeaderId;
                row.Cells["PurchaseNumberCol"].Value = item.TransactionNumber;
                row.Cells["PurchaseDateCol"].Value = item.TransactionDate;
                row.Cells["CashierCol"].Value = item.Cashier;
                row.Cells["TotalCol"].Value = item.Total;
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
        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }

        //Main Load
        private async void SalesRecord_Load(object sender, EventArgs e)
        {
            await PopulateAllSaleReportDatagrid();
        }
    }
}
