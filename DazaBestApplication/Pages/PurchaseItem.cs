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
    public partial class PurchaseItem : Form
    {
        private Form Mainform;
        private PurchaseItemModal _purcahseitemmodal;

        public PurchaseItem(Form _mainform)
        {
            InitializeComponent();
            if (_mainform.Name == "MainPage")
            {
                Mainform = _mainform;
            }
        }

        //Show Purchase Item Page
        private void ShowAddItemModal()
        {
            _purcahseitemmodal = new PurchaseItemModal()
            {
                Action = "AddItemStock",
                EditPurchaseDetails = null
            };
            OpenModal();
        }

        //Open purchase item modal
        private void OpenModal()
        {
            Form ModalBackgorund = new();
            using (PurchaseItemmodal modalcontent = new(_purcahseitemmodal))
            {
                var mainBounds = Mainform.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = Mainform.Size;
                ModalBackgorund.Location = Mainform.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(Mainform);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }

        private void BuyProductBTN_Click(object sender, EventArgs e)
        {
            ShowAddItemModal();
        }
    }
}
