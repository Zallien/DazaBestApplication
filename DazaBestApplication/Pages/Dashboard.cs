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
                var series = SaleChart.Series["Sales"];
                series.Points.Clear();

                series.ChartType = SeriesChartType.Line;
                series.XValueType = ChartValueType.DateTime;

                if (DashboardInformationType != "Yearly")
                {
                    foreach (var item in DashboardInformation.ChartforSale)
                    {
                        // Pass DateTime directly
                        series.Points.AddXY(item.Date, item.SalesValue);
                    }

                    // Format axis labels for daily/weekly/monthly
                    SaleChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    SaleChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    SaleChart.ChartAreas[0].AxisX.Interval = 1;
                }
                else
                {
                    foreach (var item in DashboardInformation.ChartforSale)
                    {
                        // Pass DateTime directly (e.g. 2026-01-01 for Jan, 2026-02-01 for Feb)
                        series.Points.AddXY(item.Date, item.SalesValue);
                    }

                    // Format axis labels for yearly (month names)
                    SaleChart.ChartAreas[0].AxisX.LabelStyle.Format = "MMM";
                    SaleChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
                    SaleChart.ChartAreas[0].AxisX.Interval = 1;
                }



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
