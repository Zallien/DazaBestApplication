using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;
using Utilities.BunifuPages;

namespace DazaBestApplication.Layout
{
    public partial class Loadingscreen : Form
    {
        private LoginServices LoginServices;
        private Size clientsize = Program.WorkspaceSize;
        private System.Windows.Forms.Timer loadingTimer;
        private int Timerprogress = 0;
        private LoggingInModel LoginInfo = new LoggingInModel();

        public Loadingscreen(LoggingInModel logginginInfo)
        {
            InitializeComponent();
            LoginInfo = logginginInfo;
        }

        private void Loadingscreen_Load(object sender, EventArgs e)
        {
            SetupTimer();
        }
        private async Task SetupTimer()
        {
            loadingprogressbar.Value = 0;
            loadingprogressbar.Maximum = 100;
            loadingTimer = new System.Windows.Forms.Timer();
            loadingTimer.Interval = 100;
            loadingTimer.Tick += LoadingtimerTick;
            loadingTimer.Start();
            LoginUser();

        }
        private void LoadingtimerTick(object sender, EventArgs e)
        {
            Timerprogress++;
            if (Timerprogress >= 100)
            {
                loadingTimer.Stop();
                Timerprogress = 0;
            }
            loadingprogressbar.Value = Timerprogress;
        }

        //LoginUser Function
        private async Task LoginUser()
        {
            bool loginsuccess = false;
            string username;
            string password;
            username = LoginInfo.Username;
            password = LoginInfo.Password;
            LoginServices = new LoginServices(new BackEndDBContext());
            try
            {
                loginsuccess = await LoginServices.LoginAccountAsync(username, password);
                if (loginsuccess == true)
                {
                    Timerprogress = 100;
                    this.Close();
                    this.DialogResult = DialogResult.Yes;
                    return;
                }
                Timerprogress = 100;
                this.Close();
                this.DialogResult = DialogResult.No;
                return;
            }
            catch (Exception ex)
            {

                throw;
            }

        }

    }
}
