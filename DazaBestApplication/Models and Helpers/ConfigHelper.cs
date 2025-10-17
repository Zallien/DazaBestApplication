using DazaBestApplication.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace DazaBestApplication.Models_and_Helpers
{
    public static class ConfigHelper
    {
        private static readonly string ConfigFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DazaBestApplication"
        );

        private static readonly string ConfigFilePath = Path.Combine(ConfigFolder, "appsettings.json");

        public static ConfigurationModel LoadOrCreateConfigFile()
        {
            try
            {
                if (File.Exists(ConfigFilePath))
                {
                    string jsonString = File.ReadAllText(ConfigFilePath);
                    var config = JsonSerializer.Deserialize<ConfigurationModel>(jsonString);

                    if (config == null)
                        throw new Exception("Configuration file is invalid.");

                    return config;
                }
                else
                {
                    // Ensure directory exists
                    if (!Directory.Exists(ConfigFolder))
                        Directory.CreateDirectory(ConfigFolder);

                    var defaultConfig = new ConfigurationModel
                    {
                        DatabaseSettings = new DatabaseSettings
                        {
                            DbFilePath = Path.Combine(ConfigFolder, "DazaBestApplication.db"),
                            DbName = "DazaBestApplication.db",
                            IsBackupActive = true,
                            BackupScheduler = "Daily",
                            BackupDirectory = Path.Combine(ConfigFolder, "Backups")
                        },
                        GeneralSettings = new GeneralSettings
                        {
                            CompanyName = "My Company",
                            BusinessName = "My Business",
                            ContactInfo = new List<string>(),
                            BusinessLogo = null
                        },
                        POSInventorySettings = new POSInventorySettings
                        {
                            StockThresholds = new List<StockThreshold>(),
                            TrackExpiration = true,
                            ValueAddedTax = 0.12m
                        }
                    };

                    string jsonString = JsonSerializer.Serialize(defaultConfig,
                        new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(ConfigFilePath, jsonString);

                    return defaultConfig;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}", "Configuration Error");
                throw;
            }
        }

        public static void SaveConfig(ConfigurationModel config)
        {
            if (!Directory.Exists(ConfigFolder))
                Directory.CreateDirectory(ConfigFolder);

            string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(ConfigFilePath, json);
        }

        public static void SaveUpdatedConfig(ConfigurationModel config)
        {
            var option = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(config, option);
            File.WriteAllText(ConfigFilePath, json);
        }

        public static ConfigurationModel LoadConfig()
        {
            string jsonstring = File.ReadAllText(ConfigFilePath);
            return JsonSerializer.Deserialize<ConfigurationModel>(jsonstring) ?? new ConfigurationModel();
        }

        public static void UpdateConfig(Action<ConfigurationModel> UpdateAction)
        {
            var config = LoadConfig();
            UpdateAction(config);
            SaveUpdatedConfig(config);
        }
    }
}
