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
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class BusinessFormPage : Form
    {
        private List<BusinessCategoryDisplay> BusinessCategoryDisplay;
        private BusinessCategoryServices BusinessCategoryServices;
        private BusinessFormModalAction modalAction;
        private SearchItem SearchItem;
        private Form mainForm;
        private List<Guid> IdList = new List<Guid>();

        //For Pagination
        int currentpage = 1;
        string searchvalue = "";
        int itemperpage = 20;

        public BusinessFormPage(Form mainpage)
        {
            InitializeComponent();
            this.mainForm = mainpage;

        }
        //Main Load
        private async void BusinessFormPage_Load(object sender, EventArgs e)
        {
            await PopulateBusinessCategory();
            BusinessCategoryEventHandlers.BusinessCategoryNotifier += async () =>
            {
                await PopulateBusinessCategory();
            };
        }
        //Show Modal
        private void showAddBusinessCategory()
        {
            Form ModalBackgorund = new();
            using (BusinessModalForm modalcontent = new(mainForm, modalAction))
            {
                var mainBounds = mainForm.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = mainForm.Size;
                ModalBackgorund.Location = mainForm.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(mainForm);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }
        //Load All Business Category
        private async Task LoadBusinessCategory()
        {
            BusinessCategoryDisplay = new List<BusinessCategoryDisplay>();
            SearchItem = new SearchItem()
            {
                SearchValue = searchvalue,
                ItemperPage = itemperpage,
                PageNumber = currentpage
            };
            try
            {
                using (var dbcontext = new BackEndDBContext())
                {
                    BusinessCategoryServices = new BusinessCategoryServices(dbcontext);
                    BusinessCategoryDisplay = await BusinessCategoryServices.GetBusinessCategories(SearchItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //Populate all business Category
        private async Task PopulateBusinessCategory()
        {
            try
            {
                await LoadBusinessCategory();
                AllBusinessDatagrid.Rows.Clear();
                foreach (BusinessCategoryDisplay item in BusinessCategoryDisplay)
                {
                    int rowindex = AllBusinessDatagrid.Rows.Add();
                    DataGridViewRow row = AllBusinessDatagrid.Rows[rowindex];
                    row.Cells["IdCol"].Value = item.BusinessCategoryId;
                    row.Cells["BusinessNameCol"].Value = item.BusinessName;
                    row.Cells["DateCreatedCol"].Value = item.DateCreated.ToString("MMM/dd/yyyy");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Remove All Selected BusinessCategory
        private async Task RemoveAllBusinessCategories()
        {
            try
            {
                IdList = new List<Guid>();
                foreach (DataGridViewRow row in AllBusinessDatagrid.SelectedRows)
                {
                    if (row.Cells["IdCol"].Value != null)
                    {
                        Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        IdList.Add(id);
                    }
                }

                foreach (Guid Id in IdList)
                {
                    BusinessCategoryServices = new BusinessCategoryServices(new BackEndDBContext());
                    bool successfullyremoved = await BusinessCategoryServices.RemoveBusinessCategory(Id);
                    if (!successfullyremoved)
                    {
                        await BusinessCategoryEventHandlers.InvokeBusinessCategoryNotifier();
                        MessageBox.Show("Error Occured!! Removing Interupted", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                await BusinessCategoryEventHandlers.InvokeBusinessCategoryNotifier();
                MessageBox.Show("Removed Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        //Edit Business Type Information
        private async Task EditInformation()
        {
            DataGridViewRow row = AllBusinessDatagrid.SelectedRows[0];

            Guid businesstyperow = Guid.Parse(row.Cells["IdCol"].Value.ToString());
            string businesstypename = row.Cells["BusinessNameCol"].Value.ToString();

            modalAction = new BusinessFormModalAction()
            {
                Action = "Edit",
                BusinessName = businesstypename,
                BusinessTypeId = businesstyperow,
            };

            showAddBusinessCategory();
        }




        //Events
        private void AddBusinessBTN_Click(object sender, EventArgs e)
        {
            modalAction = new BusinessFormModalAction()
            {
                Action = "Add",
                BusinessName = null,
                BusinessTypeId = null,
            };

            showAddBusinessCategory();
        }
        private void AllBusinessDatagrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (AllBusinessDatagrid.SelectedRows.Count > 1)
                {
                    updateToolStripMenuItem.Visible = false;
                    sep1.Visible = false;
                }
                else
                {
                    updateToolStripMenuItem.Visible = true;
                    sep1.Visible = true;
                }
                Menustrip.Show(Cursor.Position);
            }
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Item/s?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveAllBusinessCategories();
            }

        }
        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Item/s?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveAllBusinessCategories();
            }
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditInformation();
        }
        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (AllBusinessDatagrid.SelectedRows.Count > 0)
            {
                MessageBox.Show("You can't Edit more than 1 Item", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditInformation();
        }
    }
}
