using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.Models;
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
                    Program.theBackupSettings = await backupSettingsServices.GetBackupSettings();
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
                    InsertBackupSettings insertBackupSettings = new InsertBackupSettings
                    {
                        BackupLocation = selectedDirectory,
                        AutoBackupSchedule = Program.theBackupSettings.AutoBackupSchedule
                    };
                    await BackupSettingsServices.UpdateBackupSettings(insertBackupSettings);
                    await UpdateBackupSettings();
                }
            }
        }

        private async void backupscheduledropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            //Update Backup Schedule
            BackupSettingsServices = new BackupSettingsServices(new SystemBackEnd.BackEndDBContext());
            InsertBackupSettings insertBackupSettings = new InsertBackupSettings
            {
                BackupLocation = Program.theBackupSettings.BackupLocation,
                AutoBackupSchedule = backupscheduledropdown.SelectedItem.ToString()
            };
            await BackupSettingsServices.UpdateBackupSettings(insertBackupSettings);
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
                    // ✅ IMPORTANT: Close all DB connections first!
                    Microsoft.Data.Sqlite.SqliteConnection.ClearAllPools();

                    // ✅ Now copy the backup over the DB file
                    //File.Copy(SelectedBackupFilePath, dbPath, true);
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
    }
}
