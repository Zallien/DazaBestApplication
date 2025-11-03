using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Reporting.WinForms;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.ServiceModels;

namespace DazaBestApplication.Reports
{
    public partial class ReceiptForm : Form
    {
        private RecieptData RecieptData = new RecieptData();
        private readonly ReportViewer reportViewer;
        public ReceiptForm(RecieptData therecieptdata)
        {
            InitializeComponent();
            RecieptData = therecieptdata;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            List<RecieptItemDataSet> dataSource = new List<RecieptItemDataSet>();
            List<RecieptData> sourceData = new List<RecieptData>();

            foreach (var data in RecieptData.AllItemsReciepts)
            {
                dataSource.Add(new RecieptItemDataSet
                {

                    ItemName = data.ItemName,
                    ItemQuantity = data.ItemQuantity,
                    ItemPrice = data.ItemPrice,
                    ItemTotal = data.ItemQuantity * data.ItemPrice
                });
            }
            var parameters = new List<ReportParameter>
            {
                new ReportParameter("ORno", RecieptData.ORnumber),
                new ReportParameter("DateTime", RecieptData.Date.ToString("MM/dd/yyyy HH:mm")),
                new ReportParameter("EmployeeName", RecieptData.Cashier),
                new ReportParameter("GrandTotal", RecieptData.Total.ToString("N2"))
            };

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            // 2. Define the full resource name (usually AssemblyName.Folder.FileName.rdlc)
            //    - This string MUST match the full resource path for your file.
            string resourceName = "DazaBestApplication.Reports.Report1.rdlc";

            // 3. Use the assembly to get the file as a stream (this finds the report inside the DLL)
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    // Handle the case where the resource name is wrong or the Build Action is not set
                    throw new Exception($"Could not find embedded resource: {resourceName}. Check Build Action and spelling.");
                }

                // **Corrected Line:** Load the report definition from the stream
                reportViewer.LocalReport.LoadReportDefinition(stream);

                // Continue with your existing data and parameter setup
                reportViewer.LocalReport.DataSources.Clear();
                reportViewer.LocalReport.SetParameters(parameters);

                // Make sure "iteminfo" here matches the DataSet name inside the RDLC file
                reportViewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSource));

                reportViewer.RefreshReport();
            }
        }

        private async Task GetRecieptInformation()
        {

        }
    }
}
