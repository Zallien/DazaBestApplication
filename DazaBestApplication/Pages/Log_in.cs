using DazaBestApplication.Modals;
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
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class Log_in : Form
    {
        private LoggedinAccount LoggedinAccount;
        private LoginServices LoginServices;
        private RegisterAccount regAcc;



        public Log_in()
        {
            InitializeComponent();
            MaximizeSystem();
            LoggedinAccount = Program.theLoggedInAccount;
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
                Password = "admin"
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
            bool loginsuccess = false;
            string username;
            string password;
            username = Usernametxtbox.Text;
            password = Passwordtxtbox.Text;
            LoginServices = new LoginServices(new BackEndDBContext());
            try
            {
                loginsuccess = await LoginServices.LoginAccountAsync(username, password);
                if (!loginsuccess)
                {
                    MessageBox.Show("Account Not Found", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LoginServices = new LoginServices(new BackEndDBContext());
                    Program.theLoggedInAccount = await LoginServices.GetAccountInfo(username);
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                    this.Hide();
                }
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


        //Main Load
        private async void Log_in_Load(object sender, EventArgs e)
        {
            await CheckLoggedAccount();
            LoginServices = new LoginServices(new BackEndDBContext());
            int acccounts = await LoginServices.AccountsCounts();
            if (acccounts <= 0)
            {
                await AddDevAccount();
            }
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
    }
}
