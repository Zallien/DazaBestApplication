using Bunifu.UI.WinForms;
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
        private AccountPagination AccountPagination;
        private DecisionModel _decision;
        private NotificationModel _notificationmodel;

        //Pagination
        private int _itemperpage = 10;
        private int _pagenumber = 1;
        private int _maxpagenumber = 1;
        private string _searchvalue = "";
        private int _totalaccounts = 0;



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
                AccountPagination = new AccountPagination()
                {
                    SearchValue = _searchvalue,
                    PageNumber = _pagenumber,
                    ItemperPage = _itemperpage
                };
                allAccounts.Clear();
                allAccounts = await loginServices.GetAllAccountwithQuestion(AccountPagination);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            _decision = new DecisionModel()
            {
                DecisionQuestion = "Do you want to Remove this Account?",
                DecisionTitle = "Remove Account",
            };

            bool result = OpenDecisionModal();
            if (result == true)
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
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Account Removed Successfully",
                        Details = "Account Removed"
                    };
                    OpenNotificationModal();
                    await AccountEventHandlers.InvokeAccount();
                }
                else
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Account Removal Failed",
                        Details = "An error occured while removing the account."
                    };
                    OpenNotificationModal();
                }
                await PopulateDatagridAllAccounts();
            }

            

        }
        //Open Notification Modal
        private void OpenNotificationModal()
        {
            Form ModalBackgorund = new();
            using (NotificationModal modalcontent = new(_notificationmodel))
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



        //Pagination
        //Get All item Count
        private async Task GetAllAccountCounts()
        {
            _pagenumber = 1;
            loginServices = new LoginServices(new BackEndDBContext());
            PaginationLabel.Text = $"{_pagenumber}";//Pagination Label
            SearchItem Bypage = new SearchItem()
            {
                SearchValue = _searchvalue,
                PageNumber = _pagenumber,
                ItemperPage = _itemperpage
            };
            _totalaccounts = await loginServices.GetTotalAccountsCount();
            _maxpagenumber = _totalaccounts % _itemperpage != 0 ? (_totalaccounts / _itemperpage) + 1
                                                        : _totalaccounts / _itemperpage;
            await CheckPageNumber();
        }
        //Pagination Next
        private async void NextButton_Click()
        {

            if (_pagenumber < _maxpagenumber)
            {
                _pagenumber++;
                await CheckPageNumber();
                await GetAllAccounts();
                PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton_Click()
        {
            if (_pagenumber > 1)
            {
                _pagenumber--;
                await CheckPageNumber();
                await GetAllAccounts();
                PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";//Pagination Label
            }
        }
        //Check Page Number
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (_pagenumber == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (_pagenumber >= _maxpagenumber)
            {
                PaginationNext.Enabled = false;
            }
            else
            {
                PaginationNext.Enabled = true;
            }
        }
        //Open Decision Modal
        private bool OpenDecisionModal()
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
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

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }



        //Main Load
        private async void accountPage_Load(object sender, EventArgs e)
        {
            await GetAllAccountCounts();
            await PopulateDatagridAllAccounts();
            AccountEventHandlers.AccountChangeNotifier += async () =>
            {
                await PopulateDatagridAllAccounts();
            };
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";
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
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton_Click();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton_Click();
        }

        private async void SearchBox_TextChange(object sender, EventArgs e)
        {
            _searchvalue = SearchBox.Text;
            await GetAllAccountCounts();
            await PopulateDatagridAllAccounts();
            PaginationLabel.Text = $"{_pagenumber} / {_maxpagenumber}";
        }
    }
}
