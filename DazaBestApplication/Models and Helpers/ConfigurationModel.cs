using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DazaBestApplication.Models
{
    public class StockThreshold
    {
        public string? ItemCategory { get; set; }
        public int Threshold { get; set; }
    }

    public class DatabaseSettings
    {
        public string? DbFilePath { get; set; } = "DazaBestApplication.db";
        public string? DbName { get; set; } = "DazaBestApplication.db";
        public string? BackupDirectory { get; set; }
        public bool? IsBackupActive { get; set; } = true;
        public string? BackupScheduler { get; set; }
    }

    public class GeneralSettings
    {
        public string? CompanyName { get; set; }
        public string? BusinessName { get; set; }
        public List<string>? ContactInfo { get; set; } = new();
        public byte[]? BusinessLogo { get; set; }
    }

    public class POSInventorySettings
    {
        public List<StockThreshold>? StockThresholds { get; set; } = new();
        public bool? TrackExpiration { get; set; } = true;
        public decimal? ValueAddedTax { get; set; }
    }

    public class ConfigurationModel
    {
        public GeneralSettings? GeneralSettings { get; set; } = new();
        public DatabaseSettings? DatabaseSettings { get; set; } = new();
        public POSInventorySettings? POSInventorySettings { get; set; } = new();
    }
}
