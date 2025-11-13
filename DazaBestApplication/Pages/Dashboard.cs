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
        //Set DashboardInformations labels and tables
        private async Task SetDashboard()
        {
            await LoadDashboardInformation();
            CultureInfo phCulture = new CultureInfo("en-PH");

            string qoutal = await TransformLongAmount(DashboardInformation.Qouta);
            qoutalabel.Text = "₱" + qoutal;
            numberoforderslabel.Text = DashboardInformation.OrdersCount.ToString();

            string totalsale = await TransformLongAmount(DashboardInformation.TotalSale);
            salelabel.Text = "₱" + totalsale;

            numberofitemslabel.Text = DashboardInformation.ItemsCount.ToString();
            outofstocklabel.Text = DashboardInformation.OutofStockCount.ToString();
            criticalitemslabel.Text = DashboardInformation.CriticalItems.ToString();
            overstocklabel.Text = DashboardInformation.OverstockItems.ToString();

            //Populate Tables or Datagrids for Top Selling and Least Selling Items
            TopSellingTable.Rows.Clear();
            int topsellingnumbering = 1;
            foreach (var item in DashboardInformation.TopSellingItems)
            {

                int rowindex = TopSellingTable.Rows.Add();
                DataGridViewRow row = TopSellingTable.Rows[rowindex];
                row.Cells["NumberCol"].Value = topsellingnumbering;
                row.Cells["ProductNameCol"].Value = item.ProductName;
                topsellingnumbering++;
            }

            LeastSellingTable.Rows.Clear();
            int leastsellingnumbering = 1;
            foreach (var item in DashboardInformation.LeastSellingItems)
            {

                int rowindex = LeastSellingTable.Rows.Add();
                DataGridViewRow row = LeastSellingTable.Rows[rowindex];
                row.Cells["NumberColLeast"].Value = leastsellingnumbering;
                row.Cells["ProductNameColLeast"].Value = item.ProductName;
                leastsellingnumbering++;
            }
            //Populate Chart
            await PopulateChart();

        }
        //Populate Chart
        private async Task PopulateChart()
        {
            salesChart.Series["Sales"].Points.Clear();
            var salesData = DashboardInformation.ForChart;
            var series = salesChart.Series["Sales"];

            series.IsXValueIndexed = true;

            if (salesData == null || salesData.Count == 0)
            {
                // Add a dummy point to show chart even with no data
                series.Points.AddXY("No Data", 0);
            }
            else
            {
                foreach (var dataPoint in salesData)
                {
                    series.Points.AddXY(dataPoint.ProductName.Trim(), dataPoint.ProducsSold);
                }
            }

        }
        //Helper Function 
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


        //Event Handlers
        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }
        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.Maroon;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.Maroon;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.Maroon;
            color4.BackColor = Color.White;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.Maroon;
        }


        //Main Load
        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await SetDashboard();
        }
        private async void DailyBTM_Click(object sender, EventArgs e)
        {
            if (DashboardInformationType != "Daily")
            {
                DashboardInformationType = "Daily";
                await SetDashboard();
            }
            color1.BackColor = Color.Maroon;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }
        private async void WekklyBTN_Click(object sender, EventArgs e)
        {
            if (DashboardInformationType != "Weekly")
            {
                DashboardInformationType = "Weekly";
                await SetDashboard();
            }
            color1.BackColor = Color.White;
            color2.BackColor = Color.Maroon;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }
        private async void MonthlyBTN_Click(object sender, EventArgs e)
        {
            if (DashboardInformationType != "Monthly")
            {
                DashboardInformationType = "Monthly";
                await SetDashboard();
            }
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.Maroon;
            color4.BackColor = Color.White;
        }
        private async void YearlyBTN_Click(object sender, EventArgs e)
        {
            if (DashboardInformationType != "Yearly")
            {
                DashboardInformationType = "Yearly";
                await SetDashboard();
            }
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.Maroon;
        }
    }
}
