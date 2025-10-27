using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class AdjustItemModal : Form
    {
        private List<AdjustItemDisplay> _pickedItems = new List<AdjustItemDisplay>();
        private GetAvailableItemswithpagination _getavailableitemswithpagination;
        private PurchaseitemServices PurchaseitemServices;
        private List<Guid> AllSelectedProducts = new();
        private AdjustItemModalViewModel adjustItemModalViewModel;
        private List<AdjustmentInformations> AllpickedItemswithReason = new List<AdjustmentInformations>();
        private AdjustmentItemFullInformation adjustmentItemFullInformation = new AdjustmentItemFullInformation();
        private Panel OverlayPanel;

        //ForViewOnly
        private Guid? AdjustItemHeaderId;
        private string AdjustItemReferenceNumber;


        //for Products Pagination
        private int Productcurrentpage = 1;
        private int Productitemperpage = 12;
        private int Producttotalpage = 0;
        private int Producttotalitem = 0;


        //Constructor
        public AdjustItemModal(AdjustItemModalViewModel _AdjustItemModalViewModel)
        {
            InitializeComponent();
            adjustItemModalViewModel = _AdjustItemModalViewModel;
            CheckModalAction();
        }
        //Open All Product Panel
        private async Task OpenAllProductsPanel()
        {
            await PopulatAllItemDataGrid();
            OverlayPanel = new Panel();
            OverlayPanel.Location = new Point(0, 0);
            OverlayPanel.Parent = this;
            OverlayPanel.Size = this.Size;
            OverlayPanel.BackColor = Color.FromArgb(77, 0, 0, 0);
            OverlayPanel.BringToFront();

            //Set Datagrid Properties
            AllItemDatagridview.ColumnHeadersHeight = 24;
            AllItemDatagridview.RowTemplate.Height = 20;
            Size _allppanelsize = AllProductsContainer.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            AllProductsContainer.Location = _allproductlocation;
            AllProductsContainer.Visible = true;
            AllProductsContainer.BringToFront();

            RemovedQuantityTxtbox.Text = "1";
        }
        //Populate All Item DataGrid
        private async Task PopulatAllItemDataGrid()
        {
            //Load All Available Products
            List<Items> _allproducts = await GetAllAvailableProducts();

            AllItemDatagridview.Rows.Clear();
            foreach (var item in _allproducts)
            {
                int rowindex = AllItemDatagridview.Rows.Add();
                DataGridViewRow row = AllItemDatagridview.Rows[rowindex];
                row.Cells["ALLI_ItemIdCol"].Value = item.ItemID;
                row.Cells["ALLI_ItemNameCol"].Value = item.ItemName;
                row.Cells["ALLI_ItemCodeCol"].Value = item.ItemCode;
                row.Height = 21;
                row.Resizable = DataGridViewTriState.False;
            }
        }
        //Get All Available Products
        private async Task<List<Items>> GetAllAvailableProducts()
        {
            _getavailableitemswithpagination = new GetAvailableItemswithpagination()
            {
                Pagenumber = Productcurrentpage,
                Itemperpage = Productitemperpage,
                Searchvalue = "",
                AllSelectedItem = AllSelectedProducts
            };


            PurchaseitemServices = new PurchaseitemServices(new BackEndDBContext());
            var _allproducts = await PurchaseitemServices.GetAllActiveProducts(_getavailableitemswithpagination);
            return _allproducts;
        }
        //Close Panel
        private void CloseAddAdjustmentPanel()
        {
            AllProductsContainer.Visible = false;
            OverlayPanel.Dispose();
        }
        //Close Modal
        private void CloseAdjustItemModal()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        //Get AdjusmentInformation from User
        private async Task<AdjustmentInformations> GetAdjustmentInfos()
        {
            AdjustmentInformations adjustmentInformations = new AdjustmentInformations();
            try
            {
                if (AllProductsContainer.Visible == true && AllItemDatagridview.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in AllItemDatagridview.SelectedRows)
                    {
                        adjustmentInformations.ItemId = Guid.Parse(row.Cells["ALLI_ItemIdCol"].Value.ToString());
                        adjustmentInformations.ItemName = row.Cells["ALLI_ItemNameCol"].Value.ToString();
                    }
                    adjustmentInformations.Reason = ReasonTxtbox.Text;
                    adjustmentInformations.ItemQuantity = int.Parse(RemovedQuantityTxtbox.Text);
                }
            }
            catch (Exception e)
            {

                throw;
            }

            return adjustmentInformations;
        }
        //Add AdjustmentInfo in MainDisplay
        private async Task AddAdjustmentInfo()
        {
            try
            {
                AdjustmentInformations theinfo = await GetAdjustmentInfos();
                if (theinfo != null)
                {
                    bool isExistalready = AllSelectedProducts.Contains(theinfo.ItemId);
                    if (!isExistalready)
                    {
                        AllSelectedProducts.Add(theinfo.ItemId);
                        int rowindex = AllPickedItems.Rows.Add();
                        DataGridViewRow row = AllPickedItems.Rows[rowindex];
                        row.Cells["IdCol"].Value = theinfo.ItemId;
                        row.Cells["ItemNameCol"].Value = theinfo.ItemName;
                        row.Cells["ItemQuantityCol"].Value = theinfo.ItemQuantity;
                        row.Cells["ReasonCol"].Value = theinfo.Reason;
                        AllpickedItemswithReason.Add(theinfo);
                    }
                    else
                    {
                        var theitem = AllpickedItemswithReason.FirstOrDefault(eg => eg.ItemId == theinfo.ItemId);
                        theitem.ItemQuantity = theinfo.ItemQuantity;
                    }
                    ReasonTxtbox.Text = "";
                    RemovedQuantityTxtbox.Text = "1";
                    CloseAddAdjustmentPanel();
                }
            }
            catch (Exception e)
            {

                throw;
            }



        }
        //Add Adjust Item Informations to Database
        private async Task<bool> DoneAdjustments()
        {
            bool isSuccess = false;
            try
            {
                adjustmentItemFullInformation = new AdjustmentItemFullInformation();
                adjustmentItemFullInformation.AllAdjustments = new List<AdjustItemDetailsInformations>();
                adjustmentItemFullInformation.OperatedBy = Guid.NewGuid();
                foreach (var item in AllpickedItemswithReason)
                {

                    AdjustItemDetailsInformations adjustItemDetailsInformations = new AdjustItemDetailsInformations()
                    {
                        ItemId = item.ItemId,
                        ItemQuantity = item.ItemQuantity,
                        Reason = item.Reason,
                    };

                    adjustmentItemFullInformation.AllAdjustments.Add(adjustItemDetailsInformations);
                }
                AdjustItemServices adjustitemservice = new(new BackEndDBContext());
                isSuccess = await adjustitemservice.InsertNewItemAdjustmentInformation(adjustmentItemFullInformation);
            }
            catch (Exception e)
            {
                return isSuccess;
            }
            return isSuccess;
        }
        private async Task AddAdjustmentBTN()
        {

            try
            {
                bool success = await DoneAdjustments();
                if (success)
                {
                    await AdjustItemEventHandler.InvokeAdjustItemNotifier();
                    MessageBox.Show("Successfully Added", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CloseAdjustItemModal();
                }
                else
                {
                    MessageBox.Show("Unsuccessfully Action An Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {
                return;
            }
        }
        //Remove SelectedRow from Picked Items
        private async Task<bool> RemovedSelectedItem()
        {
            bool isDeletedSuccessfully = false;
            try
            {
                if (AllPickedItems.SelectedRows.Count > 0)
                {
                    foreach(DataGridViewRow row in AllPickedItems.SelectedRows)
                    {
                        //int index = row.Index;
                        Guid Id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllPickedItems.Rows.Remove(row);
                        AllSelectedProducts.Remove(Id);

                        var theadjusteditem = AllpickedItemswithReason.Where(x => x.ItemId == Id).FirstOrDefault();
                        if (theadjusteditem != null)
                        {
                            AllpickedItemswithReason.Remove(theadjusteditem);
                        }
                        
                    }
                    isDeletedSuccessfully = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return isDeletedSuccessfully;
        }
        private async Task RemoveSelectedItemBTN()
        {
            bool isDeletedSuccessfully = await RemovedSelectedItem();
            if (isDeletedSuccessfully == true)
            {
                MessageBox.Show("Removed Successfully", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Check ModalAction
        private async Task CheckModalAction()
        {
            //adjustItemModalViewModel
            if (adjustItemModalViewModel.Action == "ViewItems")
            {
                AdjustItemHeaderId = adjustItemModalViewModel.EditPurchaseItemHeaderId;
                AdjustItemReferenceNumber = adjustItemModalViewModel.ForViewOnly.AdjustItemHeader.ReferenceNumber;

                //AllpickedItemswithReason
                foreach (var item in adjustItemModalViewModel.ForViewOnly.AdjustItemDetailswithName)
                {
                    AdjustmentInformations _new = new AdjustmentInformations()
                    {
                        ItemId = item.ItemId,
                        ItemName = item.ItemName,
                        ItemQuantity = item.RemovedQuantity,
                        Reason = item.Reason
                    };
                    AllpickedItemswithReason.Add(_new);
                    AllSelectedProducts.Add(item.ItemId);
                }

                await PopulateAllPickedItems();
                Modaltitle.Text = AdjustItemReferenceNumber;
                bunifuButton1.Visible = false;
                removeitempickedbutton.Visible = false;
                AddAdjustmentItemInformationsBTN.Text = "Ok";
            }
        }
        //Populate to Selected Item DatagridView
        private async Task PopulateAllPickedItems()
        {
            try
            {
                foreach (var item in AllpickedItemswithReason)
                {
                    int index = AllPickedItems.Rows.Add();
                    DataGridViewRow row = AllPickedItems.Rows[index];
                    row.Cells["IdCol"].Value = item.ItemId;
                    row.Cells["ItemNameCol"].Value = item.ItemName;
                    row.Cells["ItemQuantityCol"].Value = item.ItemQuantity;
                    row.Cells["ReasonCol"].Value = item.Reason;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }



        //Main Load
        private void AdjustItemModal_Load(object sender, EventArgs e)
        {
            AllPickedItems.RowTemplate.Height = 24;
        }




        private void AllPickedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void letters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AllPickedItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;
            const int LETTER_COLUMN_INDEX = 3;

            if (AllPickedItems.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
                else if (AllPickedItems.CurrentCell.ColumnIndex == LETTER_COLUMN_INDEX)
                {
                    TextBox textBox1 = e.Control as TextBox;
                    if (textBox1 != null)
                    {
                        textBox1.KeyPress -= new KeyPressEventHandler(letters_KeyPress);
                        textBox1.KeyPress += new KeyPressEventHandler(letters_KeyPress);
                    }
                }
            }
        }
        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            await OpenAllProductsPanel();
        }
        private void CloseAllPModal_Click(object sender, EventArgs e)
        {
            CloseAddAdjustmentPanel();
        }
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            CloseAdjustItemModal();
        }
        private void AddInfoBTN_Click(object sender, EventArgs e)
        {
            AddAdjustmentInfo();
        }
        private void AddAdjustmentItemInformationsBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Proceed? ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                AddAdjustmentBTN();
            }
        }
        private void removeitempickedbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Removed It?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveSelectedItemBTN();
            }
        }

        
    }


}
