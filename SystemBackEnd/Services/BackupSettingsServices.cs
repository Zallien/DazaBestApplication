using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class BackupSettingsServices
    {
        private BackEndDBContext _db;
        private readonly string appDataFolder;
        private readonly string jsonFilePath;



        public BackupSettingsServices(BackEndDBContext mdb)
        {
            _db = mdb;
            appDataFolder = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                            "DazaBestApplication"
                            );

            jsonFilePath = Path.Combine(appDataFolder, "BackupSettings.json");
        }
        //Add Backup Settings
        public void AddBackupSettings(InsertBackupSettings backupSettings)
        {
            try
            {
                BackupSettings backup = new BackupSettings
                {
                    BackupLocation = backupSettings.BackupLocation,
                    AutoBackupSchedule = backupSettings.AutoBackupSchedule,
                    LastAutoBackupDate = backupSettings.LastAutoBackupDate
                };
                _db.BackupSettings.Add(backup);
                _db.SaveChanges();
            }
            catch (Exception e)
            {

                throw;
            }
        }
        //Get Backup Settings
        public async Task<BackupSettings> GetBackupSettings()
        {
            BackupSettings backupSettings1 = new BackupSettings();
            try
            {
                var backupSettings = _db.BackupSettings.FirstOrDefault();
                if (backupSettings != null)
                {
                    backupSettings1.Row = backupSettings.Row;
                    backupSettings1.BackupLocation = backupSettings.BackupLocation;
                    backupSettings1.AutoBackupSchedule = backupSettings.AutoBackupSchedule;
                    backupSettings1.LastAutoBackupDate = backupSettings.LastAutoBackupDate;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return backupSettings1;
        }
        //Get Backup Settings Count
        public int GetBackupSettingsCount()
        {
            int count = 0;
            try
            {
                count = _db.BackupSettings.Count();
            }
            catch (Exception)
            {
                throw;
            }
            return count;
        }
        //Update Backup Settings
        public async Task UpdateBackupSettings(InsertBackupSettings backupSettings)
        {
            try
            {
                var existingSettings = _db.BackupSettings.FirstOrDefault();
                if (existingSettings != null)
                {
                    existingSettings.BackupLocation = backupSettings.BackupLocation;
                    existingSettings.AutoBackupSchedule = backupSettings.AutoBackupSchedule;
                    existingSettings.LastAutoBackupDate = backupSettings.LastAutoBackupDate;
                    _db.BackupSettings.Update(existingSettings);
                    await _db.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Ensures the backup settings file exists. Creates one with default values if missing.
        /// </summary>
        public async Task<BackupSettingsJSONModel> InitializeBackupJSON()
        {
            try
            {
                if (!Directory.Exists(appDataFolder))
                    Directory.CreateDirectory(appDataFolder);

                if (!File.Exists(jsonFilePath))
                {
                    var defaultSettings = new BackupSettingsJSONModel
                    {
                        BackupLocation = Path.Combine(appDataFolder, "Backups"),
                        LastAutoBackupDate = DateTime.MinValue,
                        AutoBackupSchedule = "Daily"
                    };

                    SaveBackupJSONFile(defaultSettings);
                    return defaultSettings;
                }
                else
                {
                    return await LoadBackupSettings();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing backup settings: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Reads and returns the current backup settings from JSON.
        /// </summary>
        public async Task<BackupSettingsJSONModel> LoadBackupSettings()
        {
            try
            {
                string json = File.ReadAllText(jsonFilePath);
                return JsonSerializer.Deserialize<BackupSettingsJSONModel>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading settings: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Saves the provided settings to JSON file.
        /// </summary>
        public async Task SaveBackupJSONFile(BackupSettingsJSONModel settings)
        {
            try
            {
                string json = JsonSerializer.Serialize(settings, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(jsonFilePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving settings: {ex.Message}");
            }
        }

        /// <summary>
        /// Returns the full path to the settings JSON file.
        /// </summary>
        public string GetSettingsPath() => jsonFilePath;


    }
}
