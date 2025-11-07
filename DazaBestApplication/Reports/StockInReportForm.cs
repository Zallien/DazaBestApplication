using Microsoft.Reporting.WinForms;
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

namespace DazaBestApplication.Reports
{
    public partial class StockInReportForm : Form
    {
        private Size Hsize;
        private List<StockInReportsDetails> StockInReportsDetails = new();
        private readonly ReportViewer reportViewer;
        private DateTime startdate;
        private DateTime enddate;
        private decimal GrandTotal;
        private string ItemStatus;
        public StockInReportForm(List<StockInReportsDetails> stockdetails, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            StockInReportsDetails = stockdetails;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);
            Hsize = Program.WorkspaceSize;
            this.Height = Hsize.Height;
            startdate = startDate;
            enddate = endDate;
        }

        private void StockInReportForm_Load(object sender, EventArgs e)
        {
            List<DataforStockIn> datasource = new List<DataforStockIn>();
            foreach (var data in StockInReportsDetails)
            {
                GrandTotal += data.TotalPrice;
                datasource.Add(new DataforStockIn
                {
                    PurchaseNo = data.PurchaseItemNumber,
                    Date = data.Date.ToString("MM/dd/yyyy"),
                    ItemName = data.ItemName,
                    ItemQty = data.Quantity,
                    ItemPrice = data.UnitPrice,
                    ItemTotal = data.TotalPrice
                });
                
            }
            var parameters = new List<ReportParameter>
            {
                new ReportParameter("Datestart", startdate.ToString("MMMM dd, yyyy")),
                new ReportParameter("Dateend", enddate.ToString("MMMM dd, yyyy")),
                new ReportParameter("GrandTotal", GrandTotal.ToString("N2"))
            };
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //Name ng report inside the project folder structure
            string resourceName = "DazaBestApplication.Reports.Report5.rdlc";
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    throw new Exception($"Could not find embedded resource: {resourceName}. Check Build Action and spelling. ₱");
                }
                reportViewer.LocalReport.LoadReportDefinition(stream);
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.SetParameters(parameters);

                //name ng dataset nasa report
                reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", datasource));
                reportViewer.RefreshReport();
            }

        }
    }
}
