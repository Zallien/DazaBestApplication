using Bunifu.UI.WinForms;
using DazaBestApplication.Layout;
using DazaBestApplication.Modals;
using DazaBestApplication.Pages;
using System.Windows.Forms;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication
{
    public partial class MainPage : Form
    {
        List<Panel> AllPanels;
        Form MainContainerForm = null;
        private BunifuTransition BunifuTransition = new();
        private LoggedinAccount theLoggedInAccount;
        

        public MainPage()
        {
            InitializeComponent();
            MaximizeSystem();
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
        //Main Load Event
        private async void MainPage_Load(object sender, EventArgs e)
        {
            theLoggedInAccount = Program.theLoggedInAccount;
            await CheckIfNewlyLoggedIn();
            await IsAdminAccount();
            await AddBackupSettingsIfNotExists();
            await LoadSettingsValues();
            await AutoBackupCheck();
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
            await Task.Delay(500); // Wait for 500 milliseconds to ensure the form is fully loaded
            if (theLoggedInAccount != null && theLoggedInAccount.NewlyLoggedIn == true)
            {
                await ShowForgotPassswordSetup();
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
        //Check if the Logged In Account is Admin
        private async Task<bool> IsAdminAccount()
        {
            try
            {
                if (theLoggedInAccount.IsOwner != true)
                {
                    PointofSaleForm posForm = new PointofSaleForm();
                    posForm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            return false;
        }
        //Add Backup Settings if not exists
        private async Task AddBackupSettingsIfNotExists()
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
                    BackupSettingsServices backupSettingsServices = new BackupSettingsServices(context);

                    int backupSettingsCount = backupSettingsServices.GetBackupSettingsCount();

                    if (backupSettingsCount == 0)
                    {
                        InsertBackupSettings newBackupSettings = new InsertBackupSettings
                        {
                            BackupLocation = backupDirectory,
                            AutoBackupSchedule = "Daily",
                            LastAutoBackupDate = DateTime.Now
                        };

                        backupSettingsServices.AddBackupSettings(newBackupSettings);
                        await LoadSettingsValues();
                        RunAutoBackup(); // your backup logic
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
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
                    Program.theBackupSettings = await backupSettingsServices.GetBackupSettings();
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
            BackupSettingsServices backupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
            var backsettingsinfo = await backupSettingsServices.GetBackupSettings();
            string schedule = backsettingsinfo.AutoBackupSchedule;
            DateTime lastBackup = backsettingsinfo.LastAutoBackupDate;

            if (ShouldAutoBackupRun(schedule, lastBackup))
            {
                RunAutoBackup(); // your backup logic
                Program.theBackupSettings.LastAutoBackupDate = DateTime.Now;

                backupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
                InsertBackupSettings updatedSettings = new InsertBackupSettings
                {
                    BackupLocation = Program.theBackupSettings.BackupLocation,
                    AutoBackupSchedule = Program.theBackupSettings.AutoBackupSchedule,
                    LastAutoBackupDate = Program.theBackupSettings.LastAutoBackupDate
                };

                await backupSettingsServices.UpdateBackupSettings(updatedSettings);
            }
        }
        //Actual Auto Backup Logic
        private void RunAutoBackup()
        {
            try
            {
                string backupFolder = Program.theBackupSettings.BackupLocation;
                Directory.CreateDirectory(backupFolder);

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


        //Open Item Inventory Page
        private void NavButton_Item_Click(object sender, EventArgs e)
        {
            ShowItemPage();
        }
        private void NavButton_Products_Click(object sender, EventArgs e)
        {
            ShowProductPage();
        }
        private async void LogOut_btn_Click(object sender, EventArgs e)
        {
            // Show confirmation dialog

            Program.theLoggedInAccount = null;
            Close();
            Log_in login = new();
            login.Show();
        }
        private void NavButton_Home_Click(object sender, EventArgs e)
        {
            ShowDashboardmPage();
            DashClicked();


        }
        private void NavButton_PurchaseItem_Click(object sender, EventArgs e)
        {

        }
        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            /*ShowSettingsPage();*/
            /// backup and restore page
            BackupAndRestorePage();


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
            //sales
            ShowSalesRecordmPage();
        }
        private void AdjustStockBTN_Click(object sender, EventArgs e)
        {
            ShowAdjustItemPage();
        }
        private void PurchaseItemBTN_Click(object sender, EventArgs e)
        {
            ShowPurchaseItemPage();
        }
        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            //stock adjustment record
            ShowAdjustRecordmPage();
        }
        private void bunifuButton24_Click(object sender, EventArgs e)
        {
            //stock in record
            StockInRecordmPage();
        }
        private void bunifuButton25_Click(object sender, EventArgs e)
        {
            //inventory record
            ShowInventoryRecordmPage();
        }
        private void AccountsManagementBTN_Click(object sender, EventArgs e)
        {
            AccountsPage();
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
    }
}
