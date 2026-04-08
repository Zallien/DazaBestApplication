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
        private string LowInventoryType = "Kg";
        private System.Windows.Forms.Timer lowInventoryTimer;
        private int currentUnitIndex = 0;
        private string[] unitMeasurements = { "Kg", "pcs", "L" };


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

                if (DashboardInformationType != "Yearly" && DashboardInformationType != "Daily")
                {
                    foreach (var item in DashboardInformation.ChartforSale)
                    {
                        // Pass DateTime directly
                        series.Points.AddXY(item.Date, item.SalesValue);
                    }

                    // Format axis labels for weekly/monthly
                    SaleChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
                    SaleChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
                    SaleChart.ChartAreas[0].AxisX.Interval = 1;

                    // Set minimum based on first data point
                    if (DashboardInformation.ChartforSale.Any())
                    {
                        var minDate = DashboardInformation.ChartforSale.Min(x => x.Date);
                        var maxDate = DashboardInformation.ChartforSale.Max(x => x.Date);

                        // For weekly: snap to start and end of week
                        if (DashboardInformationType == "Weekly")
                        {
                            var startOfWeek = minDate.AddDays(-(int)minDate.DayOfWeek);
                            var endOfWeek = startOfWeek.AddDays(6);

                            SaleChart.ChartAreas[0].AxisX.Minimum = startOfWeek.ToOADate();
                            SaleChart.ChartAreas[0].AxisX.Maximum = endOfWeek.ToOADate();
                        }
                        // For monthly: snap to first and last day of month
                        else if (DashboardInformationType == "Monthly")
                        {
                            var startOfMonth = new DateTime(minDate.Year, minDate.Month, 1);
                            var endOfMonth = new DateTime(maxDate.Year, maxDate.Month,
                                                          DateTime.DaysInMonth(maxDate.Year, maxDate.Month));

                            SaleChart.ChartAreas[0].AxisX.Minimum = startOfMonth.ToOADate();
                            SaleChart.ChartAreas[0].AxisX.Maximum = endOfMonth.ToOADate();
                        }
                        else
                        {
                            // fallback: use actual min/max transaction dates
                            SaleChart.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
                            SaleChart.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
                        }
                    }


                }
                else if (DashboardInformationType == "Daily")
                {
                    bool hasData = DashboardInformation.ChartforSale.Any();

                    if (!hasData)
                    {
                        // Add a transparent/invisible dummy point to force axis display
                        series.Points.AddXY(DateTime.Today, 1000);
                        series.Points[0].Color = Color.Transparent;
                        series.Points[0].MarkerStyle = MarkerStyle.None;
                    }
                    else
                    {
                        foreach (var item in DashboardInformation.ChartforSale)
                        {
                            series.Points.AddXY(item.Date, item.SalesValue);
                        }
                    }

                    // Format axis labels for daily
                    SaleChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
                    SaleChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Hours;
                    SaleChart.ChartAreas[0].AxisX.Interval = 1;

                    DateTime targetDate = hasData
                        ? DashboardInformation.ChartforSale.First().Date.Date
                        : DateTime.Today;

                    var startOfDay = targetDate;
                    var endOfDay = targetDate.AddDays(1).AddTicks(-1);

                    SaleChart.ChartAreas[0].AxisX.Minimum = startOfDay.ToOADate();
                    SaleChart.ChartAreas[0].AxisX.Maximum = endOfDay.ToOADate();

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

                    if (DashboardInformation.ChartforSale.Any())
                    {
                        var minDate = DashboardInformation.ChartforSale.Min(x => x.Date);
                        var year = minDate.Year; // assume single-year view

                        var startOfYear = new DateTime(year, 1, 1);
                        var endOfYear = new DateTime(year, 12, 31);

                        SaleChart.ChartAreas[0].AxisX.Minimum = startOfYear.ToOADate();
                        SaleChart.ChartAreas[0].AxisX.Maximum = endOfYear.ToOADate();
                    }
                    
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async Task LoadLowInventoryStockChart()
        {

            //Label12 for Label Low Inventory
            try
            {
                var series = LowInventoryChart.Series["Items Stocks"];
                series.Points.Clear();
                series.IsXValueIndexed = true;

                // Filter items by current unit measurement type
                var filteredItems = DashboardInformation.LowInventoryAlert
                    .Where(item => item.Unimeasurement == LowInventoryType)
                    .ToList();

                foreach (var item in filteredItems)
                {
                    series.Points.AddXY(item.ItemName, item.CurrentStocks);
                }

                // Update label to show current unit type
                string unitDisplayName = LowInventoryType switch
                {
                    "Kg" => "Kilogram",
                    "pcs" => "Pieces",
                    "L" => "Liter",
                    _ => LowInventoryType
                };

                label12.Text = $"Low Inventory Alert - {unitDisplayName}";
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
                row.Cells["StockCol"].Value = $"{item.CurrentStocks} {item.UnitMeasurement}";
            }
            InventoryStocks.ColumnHeadersHeight = 30;
            InventoryStocks.RowTemplate.Height = 28;
            InventoryStocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
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

        private void InitializeLowInventoryTimer()
        {
            lowInventoryTimer = new System.Windows.Forms.Timer();
            lowInventoryTimer.Interval = 4000; // 4 seconds
            lowInventoryTimer.Tick += LowInventoryTimer_Tick;
            lowInventoryTimer.Start();

            // Load initial data
            LoadLowInventoryStockChart();
        }
        private void LowInventoryTimer_Tick(object sender, EventArgs e)
        {

            // Move to next unit measurement
            currentUnitIndex = (currentUnitIndex + 1) % unitMeasurements.Length;
            LowInventoryType = unitMeasurements[currentUnitIndex];

            // Reload chart with new filter
            LoadLowInventoryStockChart();
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
            InitializeLowInventoryTimer();
        }

        private async void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DashboardInformationType = DashboardTypeSelect.Text;
            await LoadDashboardInformationToLabels();
        }
    }
}
