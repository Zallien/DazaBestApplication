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

namespace DazaBestApplication.Layout
{
    public partial class RedirectForm : Form
    {
        private LoggedinAccount theLoggedInAccount = Program.theLoggedInAccount;


        public RedirectForm()
        {
            InitializeComponent();

        }

        //Check if the Logged In Account is Admin
        private async Task<bool> IsAdminAccount()
        {
            try
            {
                if (theLoggedInAccount.IsOwner != true)
                {
                    PointofSaleForm posForm = new PointofSaleForm();
                    posForm.Show();
                }
                else
                {
                    MainPage mainPage = new MainPage();
                    mainPage.Show();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (e.g., log the error)
            }
            return false;
        }

        private async void RedirectForm_Load(object sender, EventArgs e)
        {
            await IsAdminAccount();
        }
    }
}
