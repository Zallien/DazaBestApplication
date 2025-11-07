using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;

namespace SystemBackEnd.Services
{
    public class BackupSettingsServices
    {
        private BackEndDBContext _db;
        


        public BackupSettingsServices(BackEndDBContext mdb)
        {
            _db = mdb;
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


    }
}
