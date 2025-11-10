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



        public AccountModal(Form mainPage, AccountEditInformation accountEditInformation,string actionModal)
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
                    MessageBox.Show("Account successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CloseAddAccountModal();
                    await AccountEventHandlers.InvokeAccount();
                }
                else
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
