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

namespace DazaBestApplication.Pages
{
    public partial class BusinessFormPage : Form
    {

        private Form mainForm;

        public BusinessFormPage(Form mainpage)
        {
            InitializeComponent();
            this.mainForm = mainpage;

        }
        //Main Load
        private void BusinessFormPage_Load(object sender, EventArgs e)
        {

        }
        //Show Modal
        private void showAddBusinessCategory()
        {
            Form ModalBackgorund = new();
            using (BusinessModalForm modalcontent = new(mainForm))
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




        //Events
        private void AddBusinessBTN_Click(object sender, EventArgs e)
        {
            showAddBusinessCategory();
        }
    }
}
