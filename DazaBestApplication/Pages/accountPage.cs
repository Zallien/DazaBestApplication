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
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class accountPage : Form
    {
        private Form MainForm;
        private List<AccountDisplay> allAccounts = new();
        private LoginServices loginServices;
        private AccountEditInformation accountEditInformation = new AccountEditInformation();


        public accountPage(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Show Add Account Modal
        private async Task ShowAccountModal(string Actionmodal)
        {
            Form ModalBackgorund = new();
            using (AccountModal modalcontent = new(MainForm, accountEditInformation, Actionmodal))
            {
                var mainBounds = MainForm.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = MainForm.Size;
                ModalBackgorund.Location = MainForm.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(MainForm);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }
        //Get all Accounts
        private async Task GetAllAccounts()
        {
            try
            {
                loginServices = new LoginServices(new BackEndDBContext());
                allAccounts.Clear();
                allAccounts = await loginServices.GetAllAccountwithQuestion();
            }
            catch (Exception ex)
            {
            }
        }
        //Populate Accounts to DataGridView
        private async Task PopulateDatagridAllAccounts()
        {
            await GetAllAccounts();
            AllAccountsDatagridView.Rows.Clear();
            foreach (var account in allAccounts)
            {
                int rowindex = AllAccountsDatagridView.Rows.Add();
                DataGridViewRow row = AllAccountsDatagridView.Rows[rowindex];
                row.Cells["IdCol"].Value = account.AccountId;
                row.Cells["NameCol"].Value = account.Fullname;
                row.Cells["UsernameCol"].Value = account.Username;
                row.Cells["PositionCol"].Value = account.Isadmin == true ? "Admin" : "Staff";
            }
        }
        //Edit Account
        private async Task EditAccount()
        {
            Guid theEditAccountId;
            theEditAccountId = Guid.Parse(AllAccountsDatagridView.SelectedRows[0].Cells["IdCol"].Value.ToString()!);
            loginServices = new LoginServices(new BackEndDBContext());
            accountEditInformation = new AccountEditInformation();
            accountEditInformation = await loginServices.GetAccountEditInformation(theEditAccountId);
            await ShowAccountModal("Edit");
        }
        //Remove All Selected Accounts
        private async Task RemoveSelectedAccounts()
        {
            List<Guid> accountIdsToRemove = new List<Guid>();
            foreach (DataGridViewRow row in AllAccountsDatagridView.SelectedRows)
            {
                Guid accountId = Guid.Parse(row.Cells["IdCol"].Value.ToString()!);
                accountIdsToRemove.Add(accountId);
            }
            loginServices = new LoginServices(new BackEndDBContext());
            bool isOwnerRemoved = await loginServices.RemoveAccount(accountIdsToRemove);
            if (isOwnerRemoved == true)
            {
                MessageBox.Show("Removed Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await AccountEventHandlers.InvokeAccount();
            }
            else
            {
                MessageBox.Show("Removed Unsuccessfully an Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            await PopulateDatagridAllAccounts();

        }




        //Main Load
        private async void accountPage_Load(object sender, EventArgs e)
        {
            await PopulateDatagridAllAccounts();
            AccountEventHandlers.AccountChangeNotifier += async () =>
            {
                await PopulateDatagridAllAccounts();
            };

        }


        //Events
        private async void AddAccountBTN_Click(object sender, EventArgs e)
        {
            ShowAccountModal("Add");
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditAccount();
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedAccounts();
        }
        private void AllAccountsDatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditAccount();
        }
    }
}
