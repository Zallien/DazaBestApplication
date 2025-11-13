using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class BackupSettingsJSONModel
    {
        public string BackupLocation { get; set; }
        public DateTime LastAutoBackupDate { get; set; }
        public string AutoBackupSchedule { get; set; }
    }
}
