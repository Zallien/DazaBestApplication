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
        private BusinessFormModalAction modalAction;

        public BusinessModalForm(Form mainform, BusinessFormModalAction action)
        {
            InitializeComponent();
            mainForm = mainform;
            modalAction = action;
            CheckModalAction();
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
        //Check Modal Action
        private void CheckModalAction()
        {
            if (modalAction.Action != "Add")
            {
                BusinessTypeTxt.Text = modalAction.BusinessName;
                submitbutton.Text = "Update";
            }
        }
        //Update Business type Information
        private async Task UpdateBusinessTypeInformation()
        {
            UpdateBusinessType updateBusinessType = new UpdateBusinessType()
            {
                BusinessTypeId = modalAction.BusinessTypeId ?? Guid.Empty,
                BusinessTypeName = BusinessTypeTxt.Text,
            };
            using (var context = new BackEndDBContext())
            {
                BusinessCategoryServices = new BusinessCategoryServices(context);
                bool updatesuccess = await BusinessCategoryServices.UpdateBusinessType(updateBusinessType);
                if (!updatesuccess)
                {
                    MessageBox.Show("An Error Occured!!", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                await BusinessCategoryEventHandlers.InvokeBusinessCategoryNotifier();
                MessageBox.Show("Updated Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                closemodal();
            }


        }







        //Events
        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (modalAction.Action != "Add")
            {
                await UpdateBusinessTypeInformation();
                return;
            }
            await AddBusinessCategory();
        }

        private void CloseModal_Click(object sender, EventArgs e)
        {
            closemodal();
        }
    }
}
