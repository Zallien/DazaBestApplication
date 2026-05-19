using DazaBestApplication.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;

namespace DazaBestApplication.Pages
{
    public partial class ItemAdjustment : Form
    {
        private Form MainForm;
        private AdjustItemModalViewModel adjustItemModalViewModel = new();
        private List<AdjustItemHeaderwithOperatedName> _theadjustitemheaderlist = new();
        private AdjustItemServices adjustitemservice;

        //for Products Pagination
        private int pagenumber = 1;
        private int itemperpage = 12;
        private int maxpagenumber = 0;
        private string searchvalue = "";

        //Constructor
        public ItemAdjustment(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }
        //Main Load
        private async void ItemAdjustment_Load(object sender, EventArgs e)
        {
            await GetMaxpagevalue();
            await CheckPageNumber();
            await PopulateHeaderDatagridview();
            AdjustItemEventHandler.AdjustItemNotifier += PopulateHeaderDatagridview;
            PaginationLabel.Text = $"{pagenumber} / {maxpagenumber}";//Pagination Label
        }


        //Get AdjustItemHeader
        private async Task<List<AdjustItemHeaderwithOperatedName>> GetAdjustItemHeader()
        {
            List<AdjustItemHeaderwithOperatedName> thelist = new();
            try
            {
                SearchItem _info = new SearchItem()
                {
                    ItemperPage = itemperpage,
                    PageNumber = pagenumber,
                    SearchValue = searchvalue
                };
                AdjustItemServices service = new AdjustItemServices(new BackEndDBContext());
                thelist = await service.GetAdjustItemHeader(_info);
            }
            catch (Exception e)
            {

            }
            return thelist;
        }
        //Popolate the DatagridHeader
        private async Task PopulateHeaderDatagridview()
        {
            try
            {
                _theadjustitemheaderlist = await GetAdjustItemHeader();
                AllAdjustmentItemsDatagrid.Rows.Clear();
                foreach (var item in _theadjustitemheaderlist)
                {
                    int index = AllAdjustmentItemsDatagrid.Rows.Add();
                    DataGridViewRow row = AllAdjustmentItemsDatagrid.Rows[index];
                    row.Cells["IdCol"].Value = item.ReferenceHeaderId;
                    row.Cells["ReferenceNoCol"].Value = item.ReferenceNumber;
                    row.Cells["OperatedDateCol"].Value = item.DateCreated;
                    row.Cells["AdjustedByCol"].Value = item.OperatedByName;
                }
                AllAdjustmentItemsDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //View Adjustment Details
        private async Task ViewAdjustmentItemDetails(Guid theheaderId)
        {
            var db = new BackEndDBContext();
            var service = new AdjustItemServices(db);

            ViewAdjustItem viewAdjustItem = await service.GetViewAdjustItem(theheaderId);
            string operatename = await service.GetOperatedByName(theheaderId);
            adjustItemModalViewModel = new AdjustItemModalViewModel()
            {
                Action = "ViewItems",
                EditPurchaseItemHeaderId = theheaderId,
                ForViewOnly = viewAdjustItem,
                OperatedBy = operatename
            };
            await ShowItemAdjustmentModal();

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
        //Search Adjust Item 
        private async Task SearchAdjustitem()
        {
            searchvalue = SearchBox.Text.Trim();
            pagenumber = 1;
            await PopulateHeaderDatagridview();
        }


        #region Pagination
        private async Task GetMaxpagevalue()
        {
            adjustitemservice = new AdjustItemServices(new BackEndDBContext());
            maxpagenumber = await adjustitemservice.GetTotalPages(itemperpage);
        }
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (pagenumber == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (pagenumber >= maxpagenumber)
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

            if (pagenumber < maxpagenumber)
            {
                pagenumber++;
                await GetMaxpagevalue();
                await CheckPageNumber();
                await PopulateHeaderDatagridview();
                PaginationLabel.Text = $"{pagenumber} / {maxpagenumber}";//Pagination Label
            }
        }
        //Pagination Previous
        private async void PreviousButton()
        {
            if (pagenumber > 1)
            {
                pagenumber--;
                await GetMaxpagevalue();
                await CheckPageNumber();
                await PopulateHeaderDatagridview();
                PaginationLabel.Text = $"{pagenumber} / {maxpagenumber}";//Pagination Label

            }
        }



        #endregion


        #region Form Events
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
        private void AllAdjustmentItemsDatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Guid _selectedpurchaseheaderid = Guid.Parse(AllAdjustmentItemsDatagrid.Rows[e.RowIndex].Cells["IdCol"].Value.ToString());
                ViewAdjustmentItemDetails(_selectedpurchaseheaderid);
            }
        }
        private void AllAdjustmentItemsDatagrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NumberOnlyCol = 0;
            const int LetterOnlyCol = 0;
            if (AllAdjustmentItemsDatagrid.CurrentCell.ColumnIndex == NumberOnlyCol)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(DataGridView_NumberOnly_KeyPress);
                e.Control.KeyPress += new KeyPressEventHandler(DataGridView_NumberOnly_KeyPress);
            }
            else if (AllAdjustmentItemsDatagrid.CurrentCell.ColumnIndex == LetterOnlyCol)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(DataGridView_LettersOnly_KeyPress);
                e.Control.KeyPress += new KeyPressEventHandler(DataGridView_LettersOnly_KeyPress);
            }

        }
        private void DataGridView_NumberOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DataGridView_LettersOnly_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void PaginationNext_Click(object sender, EventArgs e)
        {
            NextButton();
        }
        private void PaginationPREV_Click(object sender, EventArgs e)
        {
            PreviousButton();
        }
        private void SearchBox_TextChange(object sender, EventArgs e)
        {
            SearchAdjustitem();
        }

        #endregion

    }
}
