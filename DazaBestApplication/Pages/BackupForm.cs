using DazaBestApplication.Modals;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class BackupForm : Form
    {
        private Form MainForm;
        private string selectedDirectory;
        private string SelectedBackupFilePath;
        private BackupSettingsServices BackupSettingsServices;
        private List<string> BackupSchedules = new List<string>
                                                {
                                                    "Daily",
                                                    "Every 2 Days",
                                                    "Every 3 Days",
                                                    "Weekly",
                                                    "Monthly"
                                                };
        Panel loadingPanel;
        private DecisionModel _decision;

        public BackupForm(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Load Event
        private async void BackupForm_Load(object sender, EventArgs e)
        {
            backupdirectorytxtbox.Text = Program.theBackupSettings.BackupLocation;
            backupscheduledropdown.Text = Program.theBackupSettings.AutoBackupSchedule;
            await PopulateDropdown();

        }
        //Update Backup Settings Values
        private async Task UpdateBackupSettings()
        {
            try
            {
                using (var context = new SystemBackEnd.BackEndDBContext())
                {
                    BackupSettingsServices backupSettingsServices = new BackupSettingsServices(context);
                    Program.theBackupSettings = await backupSettingsServices.LoadBackupSettings();
                    await UpdateTextboxandContainer();
                }
            }
            catch (Exception ex)
            {
                // Log or handle exception
            }
        }
        //Populate Dropdown
        private async Task PopulateDropdown()
        {
            backupscheduledropdown.Items.Clear();
            foreach (var schedule in BackupSchedules)
            {
                backupscheduledropdown.Items.Add(schedule);
            }
        }
        //Restore Database Method
        private void RestoreDatabase(string backupPath, string dbPath)
        {
            using (var source = new SqliteConnection($"Data Source={backupPath}"))
            using (var dest = new SqliteConnection($"Data Source={dbPath}"))
            {
                source.Open();
                dest.Open();

                // ✅ SQLite-built-in restore function
                source.BackupDatabase(dest);
            }
        }
        //Update All Textbox
        private async Task UpdateTextboxandContainer()
        {
            using (var context = new BackEndDBContext())
            {
                BackupSettingsJSONModel backupSettingsJSONModel = new BackupSettingsJSONModel();
                BackupSettingsServices = new BackupSettingsServices(context);
                backupSettingsJSONModel = await BackupSettingsServices.LoadBackupSettings();
                Program.theBackupSettings = backupSettingsJSONModel;
                backupdirectorytxtbox.Text = Program.theBackupSettings.BackupLocation;
                backupscheduledropdown.Text = Program.theBackupSettings.AutoBackupSchedule;
            }

        }
        //Create a panel while the file is uploading to Google Drive
        private Panel CreateLoadingPanel()
        {
            loadingPanel = new Panel
            {
                Size = new Size(200, 100),
                BackColor = Color.LightGray,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point((this.ClientSize.Width - 200) / 2, (this.ClientSize.Height - 100) / 2)
            };
            Label loadingLabel = new Label
            {
                Text = "Uploading to Google Drive...",
                AutoSize = true,
                Location = new Point((loadingPanel.Width - 150) / 2, (loadingPanel.Height - 20) / 2)
            };
            loadingPanel.Controls.Add(loadingLabel);
            this.Controls.Add(loadingPanel);
            loadingPanel.BringToFront();
            return loadingPanel;
        }
        //Open Decision Modal
        private bool OpenDecisionModal()
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
            {
                var mainBounds = MainForm.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = MainForm.Size;
                ModalBackgorund.Location = MainForm.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(MainForm);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }




        //Events
        private async void SelectDirectoryBTN_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select a backup folder";
                dialog.UseDescriptionForTitle = true;


                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    string selectedDirectory = dialog.SelectedPath;
                    BackupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
                    BackupSettingsJSONModel insertBackupSettings = new BackupSettingsJSONModel
                    {
                        BackupLocation = selectedDirectory,
                        AutoBackupSchedule = Program.theBackupSettings.AutoBackupSchedule,
                        LastAutoBackupDate = Program.theBackupSettings.LastAutoBackupDate
                    };
                    await BackupSettingsServices.SaveBackupJSONFile(insertBackupSettings);
                    await UpdateBackupSettings();
                    await UpdateTextboxandContainer();

                }
            }
        }
        private async void backupscheduledropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            //Update Backup Schedule
            BackupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
            BackupSettingsJSONModel insertBackupSettings = new BackupSettingsJSONModel
            {
                BackupLocation = Program.theBackupSettings.BackupLocation,
                AutoBackupSchedule = backupscheduledropdown.SelectedItem.ToString()
            };
            await BackupSettingsServices.SaveBackupJSONFile(insertBackupSettings);
            await UpdateTextboxandContainer();
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ManualBackupBTN_Click(object sender, EventArgs e)
        {
            try
            {
                // ✅ Default folder from your settings
                string defaultBackupFolder = Program.theBackupSettings.BackupLocation;
                Directory.CreateDirectory(defaultBackupFolder);

                // ✅ DB path
                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "DazaBestApplication",
                    "DazaBestApplication.db"
                );

                if (!File.Exists(dbPath))
                {
                    MessageBox.Show("Database file not found:\n" + dbPath);
                    return;
                }

                // ✅ Configure SaveFileDialog
                SaveFileDialog dlg = new SaveFileDialog
                {
                    Title = "Save Backup File",
                    InitialDirectory = defaultBackupFolder,
                    Filter = "SQLite Database (*.db)|*.db",
                    FileName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}.db"
                };

                // ✅ Let user choose where and what name
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string userSelectedPath = dlg.FileName;

                    // ✅ Copy DB to user-chosen file
                    File.Copy(dbPath, userSelectedPath, true);

                    MessageBox.Show("Backup created:\n" + userSelectedPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Backup failed:\n" + ex.Message);
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select Backup File";
            dlg.Filter = "SQLite Database (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SelectedBackupFilePath = dlg.FileName;
                MessageBox.Show("Selected backup:\n" + SelectedBackupFilePath);
                Restorebackuptxtbox.Text = SelectedBackupFilePath;
            }
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SelectedBackupFilePath) || !File.Exists(SelectedBackupFilePath))
            {
                MessageBox.Show("Please select a backup file first.");
                return;
            }

            string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DazaBestApplication",
                "DazaBestApplication.db"
            );

            if (!File.Exists(dbPath))
            {
                MessageBox.Show("Original database not found:\n" + dbPath);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Restoring will replace your current database.\n\nContinue?",
                "Confirm Restore",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                try
                {

                    Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();

                    RestoreDatabase(SelectedBackupFilePath, dbPath);
                    MessageBox.Show("Database restored successfully!\nThe application will now restart.");

                    Application.Restart();
                    Environment.Exit(0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Restore failed:\n" + ex.Message);
                }
            }
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks for Internet Connection
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    MessageBox.Show("Please Connect to the Internet to Upload Backup to Google Drive.",
                        "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //Open Decision Modal AND Ask User Confirmation
                _decision = new DecisionModel
                {
                    DecisionTitle = "Upload Backup to Google Drive",
                    DecisionQuestion = "Are you sure you want to upload the backup to Google Drive?"
                };
                bool userConfirmed = OpenDecisionModal();
                if (!userConfirmed)
                {
                    return;
                }

                string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                    "DazaBestApplication",
                    "DazaBestApplication.db"
                );

                DriveServices driveServices = new DriveServices();
                // Create a dynamic filename with date and time
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string dynamicFileName = $"DazaBestApplication_{timestamp}.db";

                // Save to temp folder with dynamic name
                string tempPath = Path.Combine(Path.GetTempPath(), dynamicFileName);
                File.Copy(dbPath, tempPath, true);

                // Upload with dynamic filename
                bool uploadSuccess = driveServices.UploadFile(tempPath);
                if (uploadSuccess)
                {
                    MessageBox.Show("Backup uploaded to Google Drive successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to upload backup to Google Drive.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
