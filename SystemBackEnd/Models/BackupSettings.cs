using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class BackupSettings
    {
        [Key]
        public int Row { get; set; }
        public string BackupLocation { get; set; }
        public string AutoBackupSchedule { get; set; }
        public DateTime LastAutoBackupDate { get; set; }
    }

    public class InsertBackupSettings
    {
        public string BackupLocation { get; set; }
        public string AutoBackupSchedule { get; set; }
        public DateTime LastAutoBackupDate { get; set; }
    }   
}
