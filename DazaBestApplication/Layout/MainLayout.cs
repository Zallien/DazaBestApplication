using DazaBestApplication.Pages;
using System.Windows.Forms;

namespace DazaBestApplication
{
    public partial class MainPage : Form
    {
        List<Panel> AllPanels;
        Form MainContainerForm = null;

        public MainPage()
        {
            InitializeComponent();
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

        private void MainPage_Load(object sender, EventArgs e)
        {

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
