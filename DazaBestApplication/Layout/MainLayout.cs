using DazaBestApplication.Pages;
using System.Windows.Forms;

namespace DazaBestApplication
{
    public partial class MainPage : Form
    {
        Panel ActiveNavbutton;
        List<Panel> AllPanels;
        Form MainContainerForm = null;
        public MainPage()
        {
            InitializeComponent();
            ActiveNavbutton = NavbarBtn_Home;
            ActiveNavbutton.BackColor = Color.White;
            SetMaxSize();
        }

        //Set to Full Screen
        private void SetMaxSize()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            Rectangle Screenbounds = Screen.PrimaryScreen.WorkingArea;
            this.Location = Screenbounds.Location;
            this.Size = Screenbounds.Size;
            Program.WorkspaceSize = this.Size;

        }

        //Set Fonts based on ScreenSize
        private void SetFontsizes(int Btnsize, int Lblsize)
        {
            //Navbar Buttons(Labels)
            foreach (var item in Navbar.Controls)
            {
                if (item is Label Btn)
                {
                    Btn.Font = new Font(this.Font.FontFamily, Btnsize, FontStyle.Bold);
                }
            }

            //Topnavbar
            foreach (var item in Topnavbar.Controls)
            {
                if (item is Label lb)
                {
                    lb.Font = new Font(this.Font.FontFamily, Lblsize, FontStyle.Bold);
                }
            }
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            if (Program.WorkspaceSize.Width > 600)
            {
                SetFontsizes(14, 12);
            }
            else
            {
                SetFontsizes(10, 9);
            }
            AllPanels = new List<Panel>
            {
                NavbarBtn_Home,
                NavbarBtn_Items,
                NavbarBtn_Products,
                NavbarBtn_Logout,
                NavbarBtn_Supplier,
                NavbarBtn_Sale
            };
            // Attach hover handlers to ALL nav panels
            foreach (var p in AllPanels)
                SetHoverEffects(p);
        }

        //NavbarButtons Effects
        private void SetHoverEffects(Panel navPanel) //Hover for Navbuttons
        {
            navPanel.MouseEnter -= NavItem_MouseEnter;
            navPanel.MouseLeave -= NavItem_MouseLeave;
            navPanel.MouseEnter += NavItem_MouseEnter;
            navPanel.MouseLeave += NavItem_MouseLeave;

            foreach (Control child in navPanel.Controls)
            {
                child.MouseEnter -= NavItem_MouseEnter;
                child.MouseLeave -= NavItem_MouseLeave;
                child.MouseEnter += NavItem_MouseEnter;
                child.MouseLeave += NavItem_MouseLeave;
            }
        }
        private void NavItem_MouseEnter(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Panel panel = c as Panel ?? c.Parent as Panel;
            if (panel == null) return;

            // Only show hover if this panel is NOT the active one
            if (panel != ActiveNavbutton)
                panel.BackColor = Color.White;
        }
        private void NavItem_MouseLeave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Panel panel = c as Panel ?? c.Parent as Panel;
            if (panel == null) return;

            // If the mouse is still inside the panel, ignore the leave.
            Point pt = panel.PointToClient(Cursor.Position);
            if (panel.ClientRectangle.Contains(pt)) return;

            if (panel != ActiveNavbutton)
                panel.BackColor = Color.Transparent;
        }
        private void SetActiveNavButton(Panel NavButtonpanel)
        {
            if (ActiveNavbutton == NavButtonpanel) return; // no-op if same

            // reset previous
            if (ActiveNavbutton != null)
                SetNotActive(ActiveNavbutton);

            // set new active
            ActiveNavbutton = NavButtonpanel;
            ActiveNavbutton.BackColor = Color.White;

            if (NavButtonpanel == NavbarBtn_Items)
            {
                ItemPage();
            }
        }
        private void SetNotActive(Panel panel)
        {
            panel.BackColor = Color.Transparent;
            foreach (Control item in panel.Controls)
                item.BackColor = Color.Transparent;
        }

        //Mouse click NavBtn Mapping
        private void NavbarBtn_Products_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveNavButton(NavbarBtn_Products);
        }
        private void NavbarBtn_Home_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveNavButton(NavbarBtn_Home);
        }
        private void NavbarBtn_Items_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveNavButton(NavbarBtn_Items);
        }
        private void NavbarBtn_Sale_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveNavButton(NavbarBtn_Sale);
        }
        private void NavbarBtn_Supplier_MouseClick(object sender, MouseEventArgs e)
        {
            SetActiveNavButton(NavbarBtn_Supplier);
        }

        //Routing Each Pages
        private void ItemPage()
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
    }
}
