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
    public partial class ItemAdjustment : Form
    {
        private Form MainForm;
        private AdjustItemModalViewModel adjustItemModalViewModel = new();

        //Constructor
        public ItemAdjustment(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        //Main Load
        private void ItemAdjustment_Load(object sender, EventArgs e)
        {

        }

        //Show Adjust Item Modal
        private async Task ShowItemAdjustmentModal()
        {
            Form ModalBackgorund = new();
            using (AdjustItemModal modalcontent = new(adjustItemModalViewModel))
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







        //---Events---
        private async void AdjustItemBTN_Click(object sender, EventArgs e)
        {
            adjustItemModalViewModel = new AdjustItemModalViewModel()
            {
                Action = "AdjustItem",
                EditPurchaseItemHeaderId = null,
                ForViewOnly = null
            };
            await ShowItemAdjustmentModal();
        }
    }
}
