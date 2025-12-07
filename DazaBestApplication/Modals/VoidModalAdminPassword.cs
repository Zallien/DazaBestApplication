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
using SystemBackEnd;
using SystemBackEnd.Models;
using SystemBackEnd.EventHandlers;

namespace DazaBestApplication.Modals
{
    public partial class VoidModalAdminPassword : Form
    {
        private LoginServices _loginServices;

        public VoidModalAdminPassword()
        {
            InitializeComponent();
        }

        //Verifypassword if admin exists
        private async Task VerifyPassword()
        {
            if (adminpasswordtxt.Text == "" || adminpasswordtxt.Text.Length == 0)
            {
                MessageBox.Show("Please insert a Password first", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                _loginServices = new LoginServices(new BackEndDBContext());
                var isValid = await _loginServices.SearchAdminPassword(adminpasswordtxt.Text.Trim());
                if (isValid)
                {
                    await VoidHistoryEventHandler.InvokeEventHandlerNotifier();
                    await closemodal();
                }
                else
                {
                    adminpasswordtxt.Clear();
                    MessageBox.Show("Invalid Admin Password", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Closemodal
        private async Task closemodal()
        {
            this.Close();
            await Task.CompletedTask;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            VerifyPassword();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            closemodal();
        }
    }
}
