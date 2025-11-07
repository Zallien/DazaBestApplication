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

namespace DazaBestApplication.Modals
{
    public partial class AccountModal : Form
    {
        private Form MainPage;
        private bool IsOwner = false;
        private LoginServices loginServices = new LoginServices(new BackEndDBContext());


        public AccountModal(Form mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
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

        private void AccountModal_Load(object sender, EventArgs e)
        {
            isAdminToggle.Checked = IsOwner;
        }

        private async void AddAccountBtn_Click(object sender, EventArgs e)
        {
            if (FirstNametxt.Text == "" || LastNametxt.Text == "" || Usernametxt.Text== "" || Passwordtxt.Text=="")
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                await AddAccount();
            }
                
        }
    }
}
