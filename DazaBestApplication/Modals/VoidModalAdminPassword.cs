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
using DazaBestApplication.Properties;

namespace DazaBestApplication.Modals
{
    public partial class VoidModalAdminPassword : Form
    {
        private LoginServices _loginServices;
        private string acttype;

        public VoidModalAdminPassword(string actionType)
        {
            InitializeComponent();
            acttype = actionType;
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
                    if (acttype == "Cancel")
                    {
                        await VoidHistoryEventHandler.InvokeEventHandlerNotifier(VoidHistoryEventHandler.ActionType.Cancel);
                    }
                    else
                    {
                        await VoidHistoryEventHandler.InvokeEventHandlerNotifier(VoidHistoryEventHandler.ActionType.Remove);
                    }
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

        private void showhidebtn_Click(object sender, EventArgs e)
        {
            if (adminpasswordtxt.PasswordChar != '\0')
            {
                adminpasswordtxt.PasswordChar = '\0';
                showhidebtn.Image = Resources.hide__2_;
            }
            else
            {
                adminpasswordtxt.PasswordChar = '*';
                showhidebtn.Image = Resources.view__1_;
            }
        }
    }
}
