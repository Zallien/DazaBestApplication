using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using DazaBestApplication.Layout;
using DazaBestApplication.Modals;
using DazaBestApplication.Models_and_Helpers;
using DazaBestApplication.Pages;
using System.Windows.Forms;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication
{
    public partial class MainPage : SmoothForm
    {
        List<Panel> AllPanels;
        Form MainContainerForm = null;
        private BunifuTransition BunifuTransition = new();
        private LoggedinAccount theLoggedInAccount;
        private Panel Loadingpanel;
        private BunifuLoader bunifuLoader;
        private DecisionModel _decision;

        //Button Index
        private List<BunifuButton2> bunifuButtons;
        private BunifuButton2 Activebutton = new();
        private Panel loadingpanel;


        public MainPage()
        {
            InitializeComponent();
            MaximizeSystem();
        }
        //Main Load Event
        private async void MainPage_Load(object sender, EventArgs e)
        {

            await ShowloadingScreeen();
            await startup();
            theLoggedInAccount = Program.theLoggedInAccount;
            await AddBackupSettingsIfNotExists(1); //Add Backup Folder
            await LoadSettingsValues();
            await AutoBackupCheck();
            await HideLoadingScreen();
            await CheckIfNewlyLoggedIn();


            bunifuButtons = new List<BunifuButton2>()
            {
                NavButton_Home,
                NavButton_Item,
                NavButton_PurchaseItem,
                NavButton_Products,
                NavButton_Reports,
                bunifuButton21,
                AccountsManagementBTN
            };
            Activebutton = NavButton_Home;
            await CheckActiveButton();
        }


        private async Task startup()
        {
            ShowDashboardmPage();

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
        //Maximize the System AUTOMATICALLY
        private void MaximizeSystem()
        {
            var screensize = Screen.PrimaryScreen.Bounds;
            Program.WorkspaceSize = screensize.Size;
            this.Size = screensize.Size;
            this.Location = screensize.Location;
        }
        //Check if User is Newly Logged In
        private async Task CheckIfNewlyLoggedIn()
        {

            if (theLoggedInAccount != null && theLoggedInAccount.NewlyLoggedIn == true)
            {
                LoginServices loginservice = new LoginServices(new SystemBackEnd.BackEndDBContext());
                bool firsttimelogout = await loginservice.GetAccountFirstLoginInformation(theLoggedInAccount.AccountId);
                if (firsttimelogout == true)
                {
                    await ShowForgotPassswordSetup();
                }
            }

        }
        //Show ForgotPassswordSetupModal
        private async Task ShowForgotPassswordSetup()
        {
            Form ModalBackgorund = new();
            using (SecurityQuestionModal modalcontent = new(this))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }



        #region Auto Backup Function

        //Add Backup Settings if not exists
        private async Task AddBackupSettingsIfNotExists(int retry = 0)
        {
            try
            {
                string backupDirectory = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "DazaBestApplication",
                    "Backups"
                );

                Directory.CreateDirectory(backupDirectory);

                using (var context = new SystemBackEnd.BackEndDBContext())
                {
                    var backupSettingsServices = new BackupSettingsServices(context);
                    var backupSettingsCount = await backupSettingsServices.InitializeBackupJSON();

                    if (backupSettingsCount == null)
                    {
                        if (retry >= 5)
                        {
                            Console.WriteLine("Max retries reached. Stopping...");
                            return;
                        }

                        Console.WriteLine($"Backup not found. Retrying... Attempt {retry + 1}");

                        await Task.Delay(1000); // wait 1 second before retry
                        await AddBackupSettingsIfNotExists(retry + 1);
                        return;
                    }

                    Console.WriteLine("Backup settings found or created successfully.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (retry < 5)
                {
                    await Task.Delay(1000);
                    await AddBackupSettingsIfNotExists(retry + 1);
                }
                else
                {
                    Console.WriteLine("Failed after multiple attempts.");
                }
            }
        }

        //Load BackupSettings 
        private async Task LoadSettingsValues()
        {
            try
            {
                using (var context = new SystemBackEnd.BackEndDBContext())
                {
                    BackupSettingsServices backupSettingsServices = new BackupSettingsServices(context);
                    Program.theBackupSettings = await backupSettingsServices.LoadBackupSettings();
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
            }
        }
        //For AutoBackup Functionality
        public bool ShouldAutoBackupRun(string schedule, DateTime lastBackup)
        {
            DateTime today = DateTime.Today;

            switch (schedule)
            {
                case "Daily":
                    return lastBackup.Date < today;

                case "Every 2 Days":
                    return (today - lastBackup.Date).TotalDays >= 2;

                case "Every 3 Days":
                    return (today - lastBackup.Date).TotalDays >= 3;

                case "Weekly":
                    return (today - lastBackup.Date).TotalDays >= 7;

                case "Monthly":
                    return (today - lastBackup.Date).TotalDays >= 30;

                default:
                    return false;
            }
        }
        //Run Auto Backup
        private async Task AutoBackupCheck()
        {
            try
            {
                BackupSettingsServices backupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
                var backsettingsinfo = await backupSettingsServices.LoadBackupSettings();
                string schedule = backsettingsinfo.AutoBackupSchedule;
                DateTime lastBackup = backsettingsinfo.LastAutoBackupDate;

                if (ShouldAutoBackupRun(schedule, lastBackup))
                {
                    RunAutoBackup(); // your backup logic
                    Program.theBackupSettings.LastAutoBackupDate = DateTime.Now;

                    backupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
                    BackupSettingsJSONModel updatedSettings = new BackupSettingsJSONModel
                    {
                        BackupLocation = Program.theBackupSettings.BackupLocation,
                        AutoBackupSchedule = Program.theBackupSettings.AutoBackupSchedule,
                        LastAutoBackupDate = Program.theBackupSettings.LastAutoBackupDate
                    };

                    await backupSettingsServices.SaveBackupJSONFile(updatedSettings);
                }
            }
            catch (Exception ex)
            {

            }
        }
        //Actual Auto Backup Logic
        private void RunAutoBackup()
        {
            try
            {
                string backupFolder = Program.theBackupSettings.BackupLocation;
                Directory.CreateDirectory(Path.GetDirectoryName(backupFolder));

                // DB path
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "DazaBestApplication",
                    "DazaBestApplication.db"
                );

                // Create backup file
                string backupFile = Path.Combine(
                    backupFolder,
                    $"AutoBackup_{DateTime.Now:yyyyMMdd_HHmmss}.db"
                );

                File.Copy(dbPath, backupFile, true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Auto-backup failed:\n" + ex.Message);
            }
        }
        //Open Decision Modal
        private bool OpenDecisionModal()
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }
        #endregion



        //Show and Hide Loading screen
        private async Task ShowloadingScreeen()
        {
            Loadingpanel = new Panel()
            {
                Location = new Point(0, 0),
                Size = this.Size,
                BackColor = Color.FromArgb(20, 0, 0, 0),
                Visible = false
            };

            this.Controls.Add(Loadingpanel);
            Loadingpanel.BringToFront();
            Loadingpanel.Visible = true;

            bunifuLoader = new BunifuLoader()
            {
                Size = new Size(200, 200),
                BackColor = Color.BlanchedAlmond,
                Visible = true
            };

            Loadingpanel.Controls.Add(bunifuLoader);

            bunifuLoader.Location = new Point(
                (Loadingpanel.Width - bunifuLoader.Width) / 2,
                (Loadingpanel.Height - bunifuLoader.Height) / 2
            );

        }
        private async Task HideLoadingScreen()
        {
            bunifuLoader.Dispose();
            Loadingpanel.Dispose();
        }


        #region Routing Each Pages
        private void ShowItemPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new ItemInventory(this, MainContainer);
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
        private void ShowAdjustItemPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new ItemAdjustment(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowDashboardmPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new Dashboard(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowAdjustRecordmPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new AdjustmentRecord(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowInventoryRecordmPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new InventoryRecord(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void StockInRecordmPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new StockRecord(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void AccountsPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new accountPage(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void BackupAndRestorePage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new BackupForm(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowSalesRecordmPage()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new SalesRecord(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }
        private void ShowBusinessForm()
        {
            if (MainContainerForm != null)
            {
                MainContainer.Controls.Remove(MainContainerForm);
                MainContainerForm = null;
            }
            MainContainerForm = new BusinessFormPage(this);
            MainContainerForm.TopLevel = false;
            MainContainerForm.Dock = DockStyle.Fill;
            MainContainer.Controls.Add(MainContainerForm);
            MainContainerForm.Show();
        }

        #endregion


        //Open Item Inventory Page
        private void NavButton_Item_Click(object sender, EventArgs e)
        {
            ShowItemPage();
            Activebutton = NavButton_Item;
            CheckActiveButton();
        }
        private void NavButton_Products_Click(object sender, EventArgs e)
        {
            ShowProductPage();
            Activebutton = NavButton_Products;
            CheckActiveButton();
        }
        private async void LogOut_btn_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog which will do logout if confirmed
            //var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    Program.theLoggedInAccount = null;
            //    Close();
            //    Log_in login = new();
            //    login.Show();
            //}
            _decision = new DecisionModel()
            {
                DecisionQuestion = "Do you want to Logout?",
                DecisionTitle = "Logout",
            };

            bool result = OpenDecisionModal();
            if (result == true)
            {
                Program.theLoggedInAccount = null;
                Close();
                Log_in login = new();
                login.Show();
            }

        }
        private void NavButton_Home_Click(object sender, EventArgs e)
        {
            ShowDashboardmPage();
            Activebutton = NavButton_Home;
            CheckActiveButton();

        }
        private void NavButton_PurchaseItem_Click(object sender, EventArgs e)
        {

        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            /// backup and restore page
            BackupAndRestorePage();
            Activebutton = bunifuButton21;
            CheckActiveButton();

        }
        private void POSButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
            //sales
            ShowSalesRecordmPage();
            Activebutton = NavButton_Reports;
            CheckActiveButton();
        }
        private void AdjustStockBTN_Click(object sender, EventArgs e)
        {
            ShowAdjustItemPage();
            Activebutton = NavButton_PurchaseItem;
            CheckActiveButton();
        }
        private void PurchaseItemBTN_Click(object sender, EventArgs e)
        {
            ShowPurchaseItemPage();
            Activebutton = NavButton_PurchaseItem;
            CheckActiveButton();
        }
        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            //stock adjustment record
            ShowAdjustRecordmPage();
            Activebutton = NavButton_Reports;
            CheckActiveButton();
        }
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //stock in record
            StockInRecordmPage();
            Activebutton = NavButton_Reports;
            CheckActiveButton();
        }
        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            //inventory record
            ShowInventoryRecordmPage();
            Activebutton = NavButton_Reports;
            CheckActiveButton();
        }
        private void AccountsManagementBTN_Click(object sender, EventArgs e)
        {
            AccountsPage();
            Activebutton = AccountsManagementBTN;
            CheckActiveButton();
        }


        //Navbutton Hover
        private void NavbuttonMouseEnter(object sender, EventArgs e)
        {
            if (sender is BunifuButton2 button)
            {
                if (button == Activebutton)
                {
                    return;
                }
                button.BackColor = Color.FromArgb(255, 240, 221);
            }
        }
        private void NavbuttonMouseLeave(object sender, EventArgs e)
        {
            if (sender is BunifuButton2 button)
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.Black;
                CheckActiveButton();
            }
        }
        private async Task CheckActiveButton()
        {
            foreach (BunifuButton2 button2 in bunifuButtons)
            {
                button2.BackColor = Color.Transparent;
                button2.ForeColor = Color.Black;
            }
            if (Activebutton is BunifuButton2 activebutton)
            {
                activebutton.BackColor = Color.FromArgb(198, 40, 40);
                activebutton.ForeColor = Color.White;
            }
        }


        ///clicked 
        private void DashClicked()
        {


            //backcolor
            NavButton_Home.BackColor = Color.FromArgb(198, 40, 40);
            NavButton_Home.IdleFillColor = Color.FromArgb(198, 40, 40);
            NavButton_Item.BackColor = Color.Transparent;
            NavButton_Products.BackColor = Color.Transparent;
            NavButton_PurchaseItem.BackColor = Color.Transparent;
            NavButton_Reports.BackColor = Color.Transparent;
            bunifuButton21.BackColor = Color.Transparent; // Backup and Restore
            POSButton.BackColor = Color.Transparent;
            AccountsManagementBTN.BackColor = Color.Transparent;
            // Forecolor
            NavButton_Home.ForeColor = Color.White;
            NavButton_Item.ForeColor = Color.Black;
            NavButton_Products.ForeColor = Color.Black;
            NavButton_PurchaseItem.ForeColor = Color.Black;
            NavButton_Reports.ForeColor = Color.Black;
            bunifuButton21.ForeColor = Color.Black; // Backup and Restore
            POSButton.ForeColor = Color.Black;
            AccountsManagementBTN.ForeColor = Color.Black;
            //Icon
            NavButton_Home.IdleIconLeftImage = Properties.Resources.speedometer__1___1_;
            //NavButton_Home.IdleIconLeftImage = Properties.Resources.speedometer__1___1_;
            //NavButton_Home.IdleIconLeftImage = Properties.Resources.speedometer__1___1_;
            NavButton_Item.IdleIconLeftImage = Properties.Resources.clipboard;
            NavButton_Products.IdleIconLeftImage = Properties.Resources.clipboard;
            NavButton_PurchaseItem.IdleIconLeftImage = Properties.Resources.logistics;
            NavButton_Reports.IdleIconLeftImage = Properties.Resources.folder;
            bunifuButton21.IdleIconLeftImage = Properties.Resources.gear; // Backup and Restore
            POSButton.IdleIconLeftImage = Properties.Resources.payment_terminal;
            AccountsManagementBTN.IdleIconLeftImage = Properties.Resources.accounts;
        }

        private void voidsbutton_Click(object sender, EventArgs e)
        {

        }
    }
}
