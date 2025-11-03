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
        AdjusmentReportServices adjustmentreportservice;
        RecordsFilterSearch recordsFilterSearch;


        //Search and Filterations
        private string SearchValue = "";
        private int PageNumber = 0;
        private int ItemPerPaeg = 12;
        private DateTime FromDateFilter = DateTime.Parse("2025-10-27 14:04:35.161");
        private DateTime ToDateFilter = DateTime.Now;

        private Form MainForm;
        public AdjustmentRecord(Form mainForm)
        {
            InitializeComponent();

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
        private async void AdjustmentRecord_Load(object sender, EventArgs e)
        {
            await PopulateAlldjustDetailsDatagrid();
        }
    }
}
