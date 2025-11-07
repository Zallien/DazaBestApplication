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
    public partial class AdjustmentReportForm : Form
    {
        private Size Hsize;
        private List<AdjustmentReportDetailsforPrint> adjustmentReportDetails = new List<AdjustmentReportDetailsforPrint>();
        private readonly ReportViewer reportViewer;
        private DateTime startdate;
        private DateTime enddate;
        public AdjustmentReportForm(List<AdjustmentReportDetailsforPrint> AdjustData, DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            adjustmentReportDetails = AdjustData;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            startdate = startDate;
            enddate = endDate;
            this.Controls.Add(reportViewer);
            Hsize = Program.WorkspaceSize;
            this.Height = Hsize.Height;
        }

        private void AdjustmentReportForm_Load(object sender, EventArgs e)
        {
            List<DataforAdjustment> datasource = new List<DataforAdjustment>();
            foreach (var data in adjustmentReportDetails)
            {
                datasource.Add(new DataforAdjustment
                {
                    ReferenceNo = data.ReferenceNumber,
                    Date = data.Date.ToString("MM/dd/yyyy"),
                    itemName = data.ItemName,
                    Quantity = data.Quantity,
                    Reason = data.Reason
                });

            }
            var parameters = new List<ReportParameter>
            {
                new ReportParameter("Datestart", startdate.ToString("MMMM dd, yyyy")),
                new ReportParameter("DateEnd", enddate.ToString("MMMM dd, yyyy"))
            };

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //Name ng report inside the project folder structure
            string resourceName = "DazaBestApplication.Reports.Report3.rdlc";
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
