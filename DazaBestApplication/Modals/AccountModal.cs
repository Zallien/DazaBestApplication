using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.Services;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;

namespace DazaBestApplication.Modals
{
    public partial class AccountModal : Form
    {

        private Form MainPage;
        private bool IsOwner = false;
        private LoginServices loginServices = new LoginServices(new BackEndDBContext());
        private AccountEditInformation accountEditInformation = new AccountEditInformation();
        private string ActionType;
        private NotificationModel _notificationmodel;


        public AccountModal(Form mainPage, AccountEditInformation accountEditInformation, string actionModal)
        {
            InitializeComponent();
            MainPage = mainPage;
            this.accountEditInformation = accountEditInformation;
            ActionType = actionModal;
        }
        //Close Modal
        private async Task CloseAddAccountModal()
        {
            this.Close();
            await Task.CompletedTask;
        }
        //Add Account
        private async Task AddAccount()
        {
            try
            {
                loginServices = new LoginServices(new BackEndDBContext());
                RegisterAccount newAccount = new RegisterAccount
                {
                    Username = Usernametxt.Text,
                    Password = Passwordtxt.Text,
                    Firstname = FirstNametxt.Text,
                    Lastname = LastNametxt.Text,
                    IsOwner = isAdminToggle.Checked
                };
                bool isRegistered = await loginServices.RegisterAccountAsync(newAccount);

                if (isRegistered)
                {
                    _notificationmodel = new NotificationModel
                    {
                        Title = "Account Created",
                        Details = "The account has been created successfully."
                    };
                    OpenNotificationModal();
                    await CloseAddAccountModal();
                    await AccountEventHandlers.InvokeAccount();
                }
                else
                {
                    _notificationmodel = new NotificationModel
                    {
                        Title = "Account Creation Failed",
                        Details = "The username already exists. Please choose a different username."
                    };
                    OpenNotificationModal();
                }



            }
            catch (Exception e)
            {

            }
        }
        //Check Account Action Type
        private async Task CheckActions()
        {
            if (ActionType != "Add")
            {
                modaltitletext.Text = "Edit Account";
                FirstNametxt.Text = accountEditInformation.Firstname;
                LastNametxt.Text = accountEditInformation.Lastname;
                Usernametxt.Text = accountEditInformation.Username;
                isAdminToggle.Checked = accountEditInformation.IsOwner;
                Passwordtxt.PlaceholderText = "Enter New Password";
                AddAccountBtn.Text = "Save Changes";
            }
        }
        //Save Changes
        private async Task SaveChanges()
        {
            try
            {
                loginServices = new LoginServices(new BackEndDBContext());
                accountEditInformation.Firstname = FirstNametxt.Text;
                accountEditInformation.Lastname = LastNametxt.Text;
                accountEditInformation.Username = Usernametxt.Text;
                accountEditInformation.IsOwner = isAdminToggle.Checked;
                if (Passwordtxt.Text != "")
                {
                    accountEditInformation.Password = Passwordtxt.Text;
                }
                bool isUpdated = await loginServices.EditAccountInformation(accountEditInformation);
                if (isUpdated)
                {
                    MessageBox.Show("Account successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CloseAddAccountModal();
                    await AccountEventHandlers.InvokeAccount();
                }
                else
                {
                    MessageBox.Show("Error updating account. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
            }
        }
        //Open Notification Modal
        private void OpenNotificationModal()
        {
            Form ModalBackgorund = new();
            using (NotificationModal modalcontent = new(_notificationmodel))
            {
                var mainBounds = MainPage.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = MainPage.Size;
                ModalBackgorund.Location = MainPage.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(MainPage);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }



        //Main Load
        private async void AccountModal_Load(object sender, EventArgs e)
        {
            isAdminToggle.Checked = IsOwner;
            await CheckActions();
        }






        //Events
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }
        private void CloseModal_Click(object sender, EventArgs e)
        {
            CloseAddAccountModal();
        }
        private async void AddAccountBtn_Click(object sender, EventArgs e)
        {
            if (ActionType != "Add")
            {
                await SaveChanges();
                return;
            }

            if (FirstNametxt.Text == "" || LastNametxt.Text == "" || Usernametxt.Text == "" || Passwordtxt.Text == "")
            {
                _notificationmodel = new NotificationModel
                {
                    Title = "Validation Error",
                    Details = "Please fill in all fields."
                };
                OpenNotificationModal();
                return;
            }
            else
            {
                await AddAccount();
            }

        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            CloseAddAccountModal();
        }
        private void FirstNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
        private void LastNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Usernametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
