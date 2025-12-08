using Bunifu.UI.WinForms;
using DazaBestApplication.Layout;
using DazaBestApplication.Modals;
using DazaBestApplication.Models_and_Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class Log_in : SmoothForm
    {
        private LoggedinAccount LoggedinAccount;
        private LoginServices LoginServices;
        private RegisterAccount regAcc;
        private Panel loadingpanel;
        private LoggingInModel logInModel;
        private NotificationModel _notificationmodel;


        public Log_in()
        {
            InitializeComponent();
            MaximizeSystem();
        }


        //Maximize the System AUTOMATICALLY
        private void MaximizeSystem()
        {
            var screensize = Screen.PrimaryScreen.Bounds;
            Program.WorkspaceSize = screensize.Size;
            this.Size = screensize.Size;
            this.Location = screensize.Location;
        }
        //Checks If Theres Currenly Logged In Account or User
        private async Task CheckLoggedAccount()
        {
            if (LoggedinAccount != null)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Close();
            }
        }
        //Add DeveloperAccount
        private async Task AddDevAccount()
        {
            LoginServices = new LoginServices(new BackEndDBContext());
            regAcc = new RegisterAccount()
            {
                Firstname = "System",
                Lastname = "Administration",
                Username = "admin",
                Password = "admin",
                IsOwner = true
            };
            bool addedsuccessfully = await LoginServices.RegisterAccountAsync(regAcc);
            if (addedsuccessfully == true)
            {
                MessageBox.Show("Dev Account Added");
            }
        }
        //Login User
        private async Task LoginUser()
        {
            logInModel = new LoggingInModel()
            {
                Username = Usernametxtbox.Text,
                Password = Passwordtxtbox.Text,
            };
            bool loginsuccess = false;
            LoginServices = new LoginServices(new BackEndDBContext());
            try
            {

                loginsuccess = await ShowLoading();
                if (loginsuccess == false)
                {
                    Usernametxtbox.Focus();
                    Usernametxtbox.Select();
                    Usernametxtbox.Clear();
                    Passwordtxtbox.Clear();
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Login Failed",
                        Details = "The username or password you entered is incorrect. Please try again."
                    };
                    OpenNotificationModal();
                    return;
                }
                LoginServices = new LoginServices(new BackEndDBContext());
                Program.theLoggedInAccount = await LoginServices.GetAccountInfo(logInModel.Username);
                this.Close();
                RedirectForm redirectform = new RedirectForm();
                redirectform.Show();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        //ShowForgotPasswordModal
        private async Task ShowForgotPasswordModal()
        {
            Form ModalBackgorund = new();
            using (ForgotPasswordModal modalcontent = new(this))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }
        //Show lOADING
        private async Task<bool> ShowLoading()
        {
            Form ModalBackgorund = new();
            using (Loadingscreen modalcontent = new(logInModel))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }
        //Open Notification Modal
        private void OpenNotificationModal()
        {
            Form ModalBackgorund = new();
            using (NotificationModal modalcontent = new(_notificationmodel))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }


        //Main Load
        private async void Log_in_Load(object sender, EventArgs e)
        {
            LoggedinAccount = Program.theLoggedInAccount;
            await CheckLoggedAccount();
            LoginServices = new LoginServices(new BackEndDBContext());
            int acccounts = await LoginServices.AccountsCounts();
            if (acccounts <= 0)
            {
                await AddDevAccount();
            }
            Usernametxtbox.Focus();
            Usernametxtbox.Select();

        }


        private async void Login_btn_Click(object sender, EventArgs e)
        {
            await LoginUser();
        }
        private void FormControlBox_CloseClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Passwordtxtbox.PasswordChar == '*')
            {
                pictureBox1.Image = Properties.Resources.hide__2_;
                Passwordtxtbox.PasswordChar = '\0';
            }
            else
            {
                pictureBox1.Image = Properties.Resources.view__1_;
                Passwordtxtbox.PasswordChar = '*';
            }

        }
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }
        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }
        private void Passwordtxtbox_KeyUp(object sender, KeyEventArgs e)
        {

        }
        private void FormControlBox_HelpClicked(object sender, EventArgs e)
        {

        }
        private async void label2_Click(object sender, EventArgs e)
        {
            await ShowForgotPasswordModal();
        }
        private void Usernametxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void background_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Passwordtxtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login_btn.Focus();
                await LoginUser();
            }
        }

        private void Usernametxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
