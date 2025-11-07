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
    public partial class InventoryReportForm : Form
    {
        private Size Hsize;
        private List<ItemsReportDetails> itemsReportDetailsforPrints = new();
        private readonly ReportViewer reportViewer;
        private string ItemStatus;
        public InventoryReportForm(List<ItemsReportDetails> itemsReportDetails)
        {
            InitializeComponent();
            itemsReportDetailsforPrints = itemsReportDetails;
            reportViewer = new ReportViewer();
            reportViewer.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer);
            Hsize = Program.WorkspaceSize;
            this.Height = Hsize.Height;
        }

        private void InventoryReportForm_Load(object sender, EventArgs e)
        {
            List<DataforInventory> datasource = new List<DataforInventory>();
            foreach (var data in itemsReportDetailsforPrints)
            {
                if (data.BalanceStock <= 0)
                {
                    ItemStatus = "Out of Stock";
                }
                else if (data.BalanceStock >0 && data.BalanceStock <3){
                    ItemStatus = "Crititcal";
                }
                else if (data.BalanceStock>=3 && data.BalanceStock <10)
                {
                    ItemStatus = "Normal";
                }
                else
                {
                    ItemStatus = "Overstock";
                }
                datasource.Add(new DataforInventory
                {
                    ItemName = data.ItemName,
                    ItemCode = data.ItemCode,
                    ItemQty = data.BalanceStock,
                    Status = ItemStatus
                });
            }
            var parameters = new List<ReportParameter>
            {
                new ReportParameter("DateCreated", DateTime.Now.ToString("MMMM dd, yyyy"))
            };
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //Name ng report inside the project folder structure
            string resourceName = "DazaBestApplication.Reports.Report4.rdlc";
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
