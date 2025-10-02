using Bunifu.UI.WinForms;
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
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

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

        //Open Item Inventory Page
        private void NavButton_Item_Click(object sender, EventArgs e)
        {
            ShowItemPage();
        }

        private void NavButton_Products_Click(object sender, EventArgs e)
        {
            ShowProductPage();
        }
    }
}
