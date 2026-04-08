using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Services
{
    public class DriveServices
    {
        public DriveServices()
        {
        }

        public DriveService GetDriveServices()
        {
            UserCredential credential;
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string appDataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DazaBestApplication"
            );

            string clientsecretPath = Path.Combine(appDataFolder, "ClientSecret.json");

            using (var stream = new FileStream(clientsecretPath, FileMode.Open, FileAccess.Read))
            {
                string credPath = Path.Combine(appDataFolder, "token.json");
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            return new DriveService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Daza'sBest Winform Uploader",
            });
        }

        public bool UploadFile(string filePath)
        {
            try
            {
                var service = GetDriveServices();
                string folderId = "15U_jy_fiHRHN5jISX-5bAgJ_YysmcqWW"; // Replace with your folder ID

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = Path.GetFileName(filePath),
                    Parents = new List<string> { folderId }
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    request = service.Files.Create(fileMetadata, stream, "application/octet-stream");
                    request.Fields = "id, name, parents";
                    request.Upload();
                }

                var file = request.ResponseBody;

                // Return true if upload succeeded
                return !string.IsNullOrEmpty(file?.Id);
            }
            catch (Exception ex)
            {
                // Optional: log or show the error
                MessageBox.Show($"Upload failed: {ex.Message}");
                return false;
            }
        }

        public async Task CreateClientSecretFileAsync()
        {
            string sourcePath = "ClientSecret.json";

            string appDataFolder = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
                "DazaBestApplication"
            );

            // Ensure folder exists
            Directory.CreateDirectory(appDataFolder);

            // Destination path
            string destPath = Path.Combine(appDataFolder, "ClientSecret.json");

            // Copy file if not already there
            if (!File.Exists(destPath))
            {
                File.Copy(sourcePath, destPath, true); // true = overwrite if needed
            }
        }
    }
}
