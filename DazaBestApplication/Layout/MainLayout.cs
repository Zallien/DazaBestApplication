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


            panel1.Visible = false;
            panel2.Visible = false;
            NavButton_Reports.MouseEnter += ShowDropdown;
            NavButton_Reports.MouseLeave += HideDropdown_Check;
            NavButton_PurchaseItem.MouseEnter += ShowDropdown1;
            NavButton_PurchaseItem.MouseLeave += HideDropdown_Check1;
            panel1.MouseEnter += ShowDropdown;
            panel1.MouseLeave += HideDropdown_Check;
            panel2.MouseEnter += ShowDropdown1;
            panel2.MouseLeave += HideDropdown_Check1;

            foreach (Control ctrl in panel1.Controls)
            {
                ctrl.MouseEnter += ShowDropdown;
                ctrl.MouseLeave += HideDropdown_Check;
                ctrl.Click += (s, e) => { panel1.Visible = false; };
            }

            foreach (Control ctrl in panel2.Controls)
            {
                ctrl.MouseEnter += ShowDropdown1;
                ctrl.MouseLeave += HideDropdown_Check1;
                ctrl.Click += (s, e) => { panel2.Visible = false; };
            }
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

        private void MainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowDropdown(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private async void HideDropdown_Check(object sender, EventArgs e)
        {
            await Task.Delay(100);
            if (this.IsDisposed || panel1.IsDisposed || NavButton_Reports.IsDisposed)
                return;

            if (!NavButton_Reports.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !panel1.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                panel1.Visible = false;
            }
        }

        private void ShowDropdown1(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private async void HideDropdown_Check1(object sender, EventArgs e)
        {
            await Task.Delay(100);
            if (this.IsDisposed || panel2.IsDisposed || NavButton_PurchaseItem.IsDisposed)
                return;

            if (!NavButton_PurchaseItem.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !panel2.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                panel2.Visible = false;
            }
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            
        }
    }
}
