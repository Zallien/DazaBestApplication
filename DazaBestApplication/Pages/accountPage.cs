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
using SystemBackEnd.ServiceModels;
using SystemBackEnd;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class accountPage : Form
    {
        private Form MainForm;
        private List<AccountDisplay> allAccounts = new();
        private LoginServices loginServices;
        public accountPage(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Show Add Account Modal
        private async Task ShowAccountModal()
        {
            Form ModalBackgorund = new();
            using (AccountModal modalcontent = new(MainForm))
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
            }
        }



        //Events
        private async void AddAccountBTN_Click(object sender, EventArgs e)
        {
            await ShowAccountModal();
        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }


        //Main Load
        private async void accountPage_Load(object sender, EventArgs e)
        {
            await PopulateDatagridAllAccounts();
        }
    }
}
