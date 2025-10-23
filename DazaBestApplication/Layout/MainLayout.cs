using Bunifu.UI.WinForms;
using DazaBestApplication.Layout;
using DazaBestApplication.Pages;
using System.Windows.Forms;

namespace DazaBestApplication
{
    public partial class MainPage : Form
    {
        List<Panel> AllPanels;
        Form MainContainerForm = null;
        private BunifuTransition BunifuTransition = new();

        public MainPage()
        {
            InitializeComponent();
            MaximizeSystem();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
        //Maximize the System AUTOMATICALLY
        private void MaximizeSystem()
        {
            var screensize = Screen.PrimaryScreen.Bounds;
            Program.WorkspaceSize = screensize.Size;
            this.Size = screensize.Size;
            this.Location = screensize.Location;
        }




        //Routing Each Pages
        private void ShowItemPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new ItemInventory(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowProductPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new ProductsInventory(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowPurchaseItemPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new PurchaseItem(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowSettingsPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new Settings(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }

        //Open Item Inventory Page
        private void NavButton_Item_Click(object sender, EventArgs e)
        {
            ShowItemPage();
        }
        private void NavButton_Products_Click(object sender, EventArgs e)
        {
            ShowProductPage();
        }
        private void LogOut_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void NavButton_Home_Click(object sender, EventArgs e)
        {
            NavButton_Home.BackColor = System.Drawing.Color.Maroon;
            NavButton_Home.ForeColor = System.Drawing.Color.White;

        }
        private void NavButton_PurchaseItem_Click(object sender, EventArgs e)
        {
            ShowPurchaseItemPage();
        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            ShowSettingsPage();
        }

        private void POSButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PointofSaleForm posForm = new PointofSaleForm();
            posForm.Show();
        }
    }
}
