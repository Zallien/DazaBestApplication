using DazaBestApplication.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using SystemBackEnd;
using System.Text.Json;
using DazaBestApplication.Models_and_Helpers;


namespace DazaBestApplication
{
    internal static class Program
    {
        public static Size WorkspaceSize { get; set; }
        public static ConfigurationModel? theconfig { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            theconfig = ConfigHelper.LoadOrCreateConfigFile();

            try
            {
                using (var context = new BackEndDBContext())
                {
                    context.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainPage());
        }


    }
}