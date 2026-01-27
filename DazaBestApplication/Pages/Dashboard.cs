using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using SystemBackEnd;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class Dashboard : Form
    {
        private Form MainForm;
        private DashboardInformation DashboardInformation;
        private DashboardServices dashboardServices;

        private string DashboardInformationType = "Daily";

        public Dashboard(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            DashboardTypeSelect.SelectedIndex = 0;
        }
        //Load Dashboard Information
        private async Task LoadDashboardInformation()
        {

            try
            {
                dashboardServices = new DashboardServices(new BackEndDBContext());
                DashboardInformation = new DashboardInformation();
                DashboardInformation = await dashboardServices.GetDashboardInformation(DashboardInformationType);
            }
            catch (Exception ex)
            {

            }
        }
        //Load Dashboard Information To Labels
        private async Task LoadDashboardInformationToLabels()
        {
            await LoadDashboardInformation();
            //Set Labels
            totalitemslabel.Text = DashboardInformation.ItemsCount.ToString("N0", CultureInfo.InvariantCulture);
            totalsaleslabel.Text = DashboardInformation.TotalSale.ToString("C", CultureInfo.CurrentCulture);
            totalorderslabel.Text = DashboardInformation.OrdersCount.ToString("N0", CultureInfo.InvariantCulture);
            totalproductslabel.Text = DashboardInformation.ProductsCount.ToString("N0", CultureInfo.InvariantCulture);


            //Load Charts
            await LoadSalesChart();
        }


        //Sale Chart Load
        private async Task LoadSalesChart()
        {
            try
            {
                // Clear any existing series
                SaleChart.Series.Clear();

                // Create a new series
                var series = new Series("Sales")
                {
                    ChartType = SeriesChartType.Line,   // Line chart
                    XValueType = ChartValueType.String  // because your Date is string ("yyyy-MM-dd" or "MMM")
                };

                // Add points from your list
                foreach (var item in DashboardInformation.ChartforSale)
                {
                    series.Points.AddXY(item.Date, item.SalesValue);
                }

                // Add the series to the chart
                SaleChart.Series.Add(series);

                // Optional: format chart area
                SaleChart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
                SaleChart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            }
            catch (Exception ex)
            {

            }
        }


        //Main Load
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await LoadDashboardInformationToLabels();
        }

        private async void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DashboardInformationType = DashboardTypeSelect.Text;
            await LoadDashboardInformationToLabels();
        }
    }
}
