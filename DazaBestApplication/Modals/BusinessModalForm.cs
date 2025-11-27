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
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class BusinessModalForm : Form
    {
        private Form mainForm;
        private InsertBusinessCategory InsertBusinessCategory;
        private BusinessCategoryServices BusinessCategoryServices;

        public BusinessModalForm(Form mainform)
        {
            InitializeComponent();
            mainForm = mainform;
        }
        //Add Business Category
        private async Task AddBusinessCategory()
        {
            InsertBusinessCategory = new InsertBusinessCategory()
            {
                BusinessName = BusinessTypeTxt.Text,
                AddedBy = Program.theLoggedInAccount.AccountId
            };
            using (var dbcontext = new BackEndDBContext())
            {
                BusinessCategoryServices = new BusinessCategoryServices(dbcontext);
                bool successfullyadded = await BusinessCategoryServices.AddBusinessCategory(InsertBusinessCategory);
                if (successfullyadded == false)
                {
                    MessageBox.Show("An Error Occured!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await BusinessCategoryEventHandlers.InvokeBusinessCategoryNotifier();
                MessageBox.Show("Added Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closemodal();
            }
        }
        //Close Modal
        private void closemodal()
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }








        //Events
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddBusinessCategory();
        }
    }
}
