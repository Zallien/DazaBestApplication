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
using SystemBackEnd.EventHandlers;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class PurchaseItem : Form
    {
        private Form Mainform;
        private PurchaseItemModal _purcahseitemmodal;
        private List<PurchaseItemHeaderDisplay> _allpurchaseitemsheaders;

        //pagination
        private int currentpage = 1;
        private int itemperpage = 12;

        public PurchaseItem(Form _mainform)
        {
            InitializeComponent();
            if (_mainform.Name == "MainPage")
            {
                Mainform = _mainform;
            }
        }

        //Show Purchase Item Page --Add Item--
        private void ShowAddItemModal()
        {
            _purcahseitemmodal = new PurchaseItemModal()
            {
                Action = "AddItemStock",
                EditPurchaseItemHeaderId = null,
                ForViewOnly = null
            };
            OpenModal();
        }
        //Show Purcahse Item Page --View--
        private async Task ShowAddItemModelView(Guid PurcahseItemHeaderId)
        {
            PurchaseitemServices _purchaseitemServices = new PurchaseitemServices(new SystemBackEnd.BackEndDBContext());
            _purcahseitemmodal = new PurchaseItemModal()
            {
                Action = "ViewPurcahseItem",
                EditPurchaseItemHeaderId = PurcahseItemHeaderId,
                ForViewOnly = await _purchaseitemServices.GetPurchaseItemDetailsandHeader(PurcahseItemHeaderId)
            };
            OpenModal();
        }
        //Main Load
        private async void PurchaseItem_Load(object sender, EventArgs e)
        {
            await GetAllPurchaseItemHeaders();
            HookEvents();
        }
        //Hook Events
        private void HookEvents()
        {
            PurchaseItemEventHandlers.PurchaseItemChanged += GetAllPurchaseItemHeaders;
        }
        //Get Purchase Items
        private async Task GetAllPurchaseItemHeaders()
        {
            _allpurchaseitemsheaders = new List<PurchaseItemHeaderDisplay>();
            PurchaseitemServices purchaseitemServices = new PurchaseitemServices(new SystemBackEnd.BackEndDBContext());
            _allpurchaseitemsheaders = await purchaseitemServices.GetPurchaseHeaders(new SearchItem()
            {
                SearchValue = SearchBox.Text,
                PageNumber = currentpage,
                ItemperPage = itemperpage
            });
            await PopulatePurchaseItemDatagrid();
        }
        //Populate Purchase Item Headers DataGrid
        private async Task PopulatePurchaseItemDatagrid()
        {
            AllPurchaseDatagridView.Rows.Clear();
            foreach (var item in _allpurchaseitemsheaders)
            {
                int rowindex = AllPurchaseDatagridView.Rows.Add();
                DataGridViewRow row = AllPurchaseDatagridView.Rows[rowindex];
                row.Cells["IdCol"].Value = item.Purchaseheaderid;
                row.Cells["PurchaseNumberCol"].Value = item.Purchasenumber;
                row.Cells["PurchaseDateCol"].Value = item.DateCreated;
                row.Cells["AddedByCol"].Value = item.AddedbyName;
                row.Cells["VerifiedByCol"].Value = item.VerifiedbyName == null ? "N/A" : item.VerifiedbyName;
            }
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
        //Open Adjust Item Modal
        private void OpenAdjustItemModal()
        {
            Form ModalBackgorund = new();
            using (AdjustItemModal modalcontent = new())
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


        //Event Handlers
        private void BuyProductBTN_Click(object sender, EventArgs e)
        {
            ShowAddItemModal();
        }
        //Opening Purchase Item Details on Double Click
        private void AllPurchaseDatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid _selectedpurchaseheaderid = Guid.Parse(AllPurchaseDatagridView.Rows[e.RowIndex].Cells["IdCol"].Value.ToString());
                PurchaseItemHeaderDisplay _selectedpurchaseheader = _allpurchaseitemsheaders.Where(x => x.Purchaseheaderid == _selectedpurchaseheaderid).FirstOrDefault();
                if (_selectedpurchaseheader != null)
                {
                    ShowAddItemModelView(_selectedpurchaseheaderid);
                }
            }
        }
        //Open Adjust Item Modal Button
        private void AdjustProductBTN_Click(object sender, EventArgs e)
        {
            OpenAdjustItemModal();
        }
    }
}
