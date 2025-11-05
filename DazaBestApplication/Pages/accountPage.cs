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
    public partial class accountPage : Form
    {
        private Form MainForm;
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




        //Events
        private async void AddAccountBTN_Click(object sender, EventArgs e)
        {
            await ShowAccountModal();
        }
        private void bunifuButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
