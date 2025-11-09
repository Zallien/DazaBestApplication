using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Security;
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
        private LoggedinAccount theloggedaccount = new();

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
            theloggedaccount = Program.theLoggedInAccount;
            CheckModalAction();
        }
        //Open All Product Panel
        private async Task OpenAllProductsPanel()
        {
            await Gettotalpages();
            await CheckPageNumber();
            await PopulatAllItemDataGrid();
            OverlayPanel = new Panel();
            OverlayPanel.Location = new Point(0, 0);
            OverlayPanel.Parent = this;
            OverlayPanel.Size = this.Size;
            OverlayPanel.BackColor = Color.FromArgb(77, 0, 0, 0);
            OverlayPanel.BringToFront();

            //Set Datagrid Properties
            AllItemDatagridview.ColumnHeadersHeight = 26;
            AllItemDatagridview.RowTemplate.Height = 30;
            Size _allppanelsize = AllProductsContainer.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            AllProductsContainer.Location = _allproductlocation;
            AllProductsContainer.Visible = true;
            AllProductsContainer.BringToFront();
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
                row.Height = 24;
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
        private async Task<AdjustmentInformations> GetAdjustmentInfos(Guid theid, string itemname)
        {
            AdjustmentInformations adjustmentInformations = new AdjustmentInformations();
            try
            {
                if (AllProductsContainer.Visible == true && AllItemDatagridview.SelectedRows.Count > 0)
                {
                    adjustmentInformations.Reason = "No Reason Yet";
                    adjustmentInformations.ItemQuantity = 1;
                    adjustmentInformations.ItemId = theid;
                    adjustmentInformations.ItemName = itemname;

                }
            }
            catch (Exception e)
            {

                throw;
            }

            return adjustmentInformations;
        }
        //Add AdjustmentInfo in MainDisplay
        private async Task AddAdjustmentInfo(Guid theid, string itemname)
        {
            try
            {
                AdjustmentInformations theinfo = await GetAdjustmentInfos(theid, itemname);
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
                    await PopulatAllItemDataGrid();
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
                adjustmentItemFullInformation.OperatedBy = theloggedaccount.AccountId;
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
                    foreach (DataGridViewRow row in AllPickedItems.SelectedRows)
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
                Point point = AddAdjustmentItemInformationsBTN.Location;
                AddAdjustmentItemInformationsBTN.Visible = false;
                bunifuButton2.Location = point;
                preparedby.Text = adjustItemModalViewModel.OperatedBy;
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
        //Update Values
        private async Task UpdateValuesfromSelectedItems(Guid theid, string updatedReason, decimal updatedQuantity)
        {
            var tobeupdated = AllpickedItemswithReason.FirstOrDefault(x => x.ItemId == theid);
            if (tobeupdated != null)
            {
                tobeupdated.Reason = updatedReason;
                tobeupdated.ItemQuantity = updatedQuantity;
            }
        }

        //Pagination for Items
        //Get Total Pages
        private async Task Gettotalpages()
        {
            using (var context = new BackEndDBContext())
            {
                PurchaseitemServices = new PurchaseitemServices(context);
                Producttotalpage = await PurchaseitemServices.GettotalPages(Productitemperpage);
            }
        }
        //Check Page Number
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            //await Gettotalpages();
            if (Productcurrentpage == 1)
            {
                buttonprev.Enabled = false;
            }
            else
            {
                buttonprev.Enabled = true;
            }
            if (Productcurrentpage >= Producttotalpage)
            {
                buttonnext.Enabled = false;
            }
            else
            {
                buttonnext.Enabled = true;
            }
            pagenumberindicator.Text = $"{Productcurrentpage} / {Producttotalpage}";
        }


        //Press Prev Button
        private async Task PressPrevButton()
        {
            await Gettotalpages();
            if (Productcurrentpage > 0)
            {
                Productcurrentpage--;
                await CheckPageNumber();
                await PopulatAllItemDataGrid();
            }
        }
        //Press Next Buttons
        private async Task PressNextButton()
        {
            await Gettotalpages();
            if (Productcurrentpage < Producttotalpage)
            {
                Productcurrentpage++;
                await CheckPageNumber();
                await PopulatAllItemDataGrid();
            }
        }


        //Main Load
        private async void AdjustItemModal_Load(object sender, EventArgs e)
        {
            AllPickedItems.RowTemplate.Height = 32;
            pagenumberindicator.Text = $"{Productcurrentpage} / {Producttotalpage}";
        }




        private void AllPickedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void letters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
        //Patanggal
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
        private void AddAdjustmentItemInformationsBTN_Click(object sender, EventArgs e)
        {
            if (AllPickedItems.Rows.Count == 0)
            {
                MessageBox.Show("Please pick at least one item to proceed.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (MessageBox.Show("Do you want to Proceed? ", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AddAdjustmentBTN();
                }
            }
        }
        private void removeitempickedbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Removed It?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveSelectedItemBTN();
            }
        }
        private void AllItemDatagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AllItemDatagridview.Columns[e.ColumnIndex].Name == "ItemActionCol")
            {
                Guid theId = Guid.Parse(AllItemDatagridview.Rows[e.RowIndex].Cells["ALLI_ItemIdCol"].Value.ToString());
                string itemname = AllItemDatagridview.Rows[e.RowIndex].Cells["ALLI_ItemNameCol"].Value.ToString();
                AddAdjustmentInfo(theId, itemname);
            }
        }
        private async void AllPickedItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.RowIndex >= 0 &&
                    !AllProductsContainer.Visible &&
                    adjustItemModalViewModel.Action == "AdjustItem" &&
                    (AllPickedItems.Columns[e.ColumnIndex].Name == "ItemQuantityCol" ||
                     AllPickedItems.Columns[e.ColumnIndex].Name == "ReasonCol"))
                {
                    var row = AllPickedItems.Rows[e.RowIndex];

                    if (row.Cells["IdCol"].Value == null)
                        return;

                    if (!Guid.TryParse(row.Cells["IdCol"].Value?.ToString(), out Guid theId))
                        return;

                    string reason = row.Cells["ReasonCol"].Value?.ToString();
                    if (string.IsNullOrWhiteSpace(reason))
                    {
                        reason = "No Reason Yet";
                        row.Cells["ReasonCol"].Value = reason;
                    }

                    decimal qty = 1;
                    string qtyValue = row.Cells["ItemQuantityCol"].Value?.ToString();
                    AdjustItemServices service = new AdjustItemServices(new BackEndDBContext());
                    bool acceptable = await service.CheckItemStock(theId, decimal.Parse(qtyValue));
                    if ((!decimal.TryParse(qtyValue, out qty) || qty <= 0) || !acceptable)
                    {
                        qty = 1;
                        row.Cells["ItemQuantityCol"].Value = qty;
                    }
                    UpdateValuesfromSelectedItems(theId, reason, qty);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AllPickedItems_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;
            const int LETTER_COLUMN_INDEX = 3;

            TextBox textBox = e.Control as TextBox;

            if (textBox != null)
            {
                textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                textBox.KeyPress -= new KeyPressEventHandler(letters_KeyPress);
                if (AllPickedItems.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
                {
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
                else if (AllPickedItems.CurrentCell.ColumnIndex == LETTER_COLUMN_INDEX)
                {
                    textBox.KeyPress += new KeyPressEventHandler(letters_KeyPress);
                }
            }
        }
        private void buttonprev_Click(object sender, EventArgs e)
        {
            PressPrevButton();
        }
        private void buttonnext_Click(object sender, EventArgs e)
        {
            PressNextButton();
        }
    }


}
