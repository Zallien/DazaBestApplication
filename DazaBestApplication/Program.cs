using Microsoft.EntityFrameworkCore;
using SystemBackEnd;

namespace DazaBestApplication
{
    internal static class Program
    {
        public static Size WorkspaceSize { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (var context = new Dbcontext())
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