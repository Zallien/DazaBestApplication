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
    public partial class PurchaseItem : Form
    {
        private Form Mainform;
        private PurchaseItemModal _purcahseitemmodal;
        private List<PurchaseItemHeaderDisplay> _allpurchaseitemsheaders;
        private PurchaseitemServices PurchaseitemServices;
        private string Searchvalue;


        //pagination
        private int currentpage = 1;
        private int itemperpage = 12;
        private int maxPage;


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
            var db = new BackEndDBContext();
            var service = new PurchaseitemServices(db);

            _purcahseitemmodal = new PurchaseItemModal()
            {
                Action = "ViewPurcahseItem",
                EditPurchaseItemHeaderId = PurcahseItemHeaderId,
                ForViewOnly = await service.GetPurchaseItemDetailsandHeader(PurcahseItemHeaderId),
                Operatedby = await service.GetOperatedBy(PurcahseItemHeaderId)
            };
            OpenModal();
        }
        //Main Load
        private async void PurchaseItem_Load(object sender, EventArgs e)
        {
            await GetMaxpagevalue();
            await CheckPageNumber();
            await GetAllPurchaseItemHeaders();
            HookEvents();
            PaginationLabel.Text = $"{currentpage} / {maxPage}";//Pagination Label
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
        //Search Purchase Items
        private async Task SearchPurchaseitem()
        {
            await GetAllPurchaseItemHeaders();
        }



        //Pagination
        private async Task GetMaxpagevalue()
        {
            PurchaseitemServices = new PurchaseitemServices(new BackEndDBContext());
            maxPage = await PurchaseitemServices.GetPurchaseItemMaxPage(itemperpage);
        }
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (currentpage == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (currentpage >= maxPage)
            {
                PaginationNext.Enabled = false;
            }
            else
            {
                PaginationNext.Enabled = true;
            }
        }
        //Pagination Next
        private async void NextButton()
        {

            if (currentpage < maxPage)
            {
                currentpage++;
                await CheckPageNumber();
                await GetAllPurchaseItemHeaders();
                PaginationLabel.Text = $"{currentpage} / {maxPage}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton()
        {
            if (currentpage > 1)
            {
                currentpage--;
                await CheckPageNumber();
                await GetAllPurchaseItemHeaders();
                PaginationLabel.Text = $"{currentpage} / {maxPage}";//Pagination Label

            }
        }




        //Open Adjust Item Modal


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

        }
        //datagridcell click event
        private void AllPurchaseDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //pagination prev click
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }
        //pagination next click
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }
        //search box text change
        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            SearchPurchaseitem();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
