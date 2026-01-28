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
            CultureInfo phCulture = new CultureInfo("en-PH");

            //Set Labels
            totalitemslabel.Text = DashboardInformation.ItemsCount.ToString("N0", CultureInfo.InvariantCulture);
            string totalsale = await TransformLongAmount(DashboardInformation.TotalSale);
            totalsaleslabel.Text = $"₱ {totalsale}";
            totalorderslabel.Text = DashboardInformation.OrdersCount.ToString("N0", CultureInfo.InvariantCulture);
            totalproductslabel.Text = DashboardInformation.ProductsCount.ToString("N0", CultureInfo.InvariantCulture);
            Userlabrl.Text = $"Welcome {Program.theLoggedInAccount.Fullname.Split(' ')[0]}!!";


            //Load Charts
            await LoadSalesChart();
            await LoadLowInventoryStockChart();
            await LoadItemInventoryPreview();
            await LoadTopSellingProducts();
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
                series.LabelForeColor = Color.Maroon;

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
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadLowInventoryStockChart()
        {
            try
            {
                var series = LowInventoryChart.Series["Items Stocks"];
                series.Points.Clear();
                series.IsXValueIndexed = true;

                foreach (var item in DashboardInformation.LowInventoryAlert)
                {
                    series.Points.AddXY(item.ItemName, item.CurrentStocks);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadItemInventoryPreview()
        {
            InventoryStocks.Rows.Clear();
            foreach (var item in DashboardInformation.InventoryPreview)
            {
                int rowindex = InventoryStocks.Rows.Add();
                DataGridViewRow row = InventoryStocks.Rows[rowindex];
                row.Cells["ItemCol"].Value = item.Itemname;
                row.Cells["StockCol"].Value = item.CurrentStocks;
            }
        }
        private async Task LoadTopSellingProducts()
        {
            var series = TopProductschart.Series["Top Products"];
            series.Points.Clear();
            series.IsXValueIndexed = true;
            foreach (var item in DashboardInformation.TopSellingItems)
            {
                series.Points.AddXY(item.ProductName, item.ProducsSold);
            }
        }

        private async Task<string> TransformLongAmount(decimal convertthis)
        {
            string thevalue = null;
            if (convertthis >= 1_000_000M)
            {
                thevalue = (convertthis / 1_000_000M).ToString("0.#") + "M";
            }
            else if (convertthis >= 1_000M)
            {
                thevalue = (convertthis / 1_000M).ToString("0.#") + "K";
            }
            else
            {
                thevalue = convertthis.ToString("0");
            }
            return thevalue;
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
