using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using DazaBestApplication.Modals;
using DazaBestApplication.Pages;
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
using SystemBackEnd.EventHandlers;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;
using static TheArtOfDev.HtmlRenderer.Adapters.RGraphicsPath;

namespace DazaBestApplication.Layout
{
    public partial class PointofSaleForm : Form
    {

        private List<Products> AllavailableProducts;
        private List<POSProductOrders> CurrentOrders = new List<POSProductOrders>();
        private decimal Total;
        private decimal discountPercentage = 0; // No discount by default
        private POSTransactionDone POSTransactionDone = new POSTransactionDone();
        private LoggedinAccount CurrentLoggedinAccount = Program.theLoggedInAccount;
        private PosItemFilter theFilter;
        private List<string> NavigationButtons = new List<string>()
        {
            "All",
            "Beverage",
            "Silog Meal",
            "Barkada Meal",
            "Meals"
        };

        //For PosItemFIlter
        private string SearchValue = "";
        private string SelectedCategory = "All";


        public PointofSaleForm()
        {
            InitializeComponent();
            MaximizeSystem();
        }

        //Maximize the System AUTOMATICALLY
        private void MaximizeSystem()
        {
            var screensize = Screen.PrimaryScreen.Bounds;
            Program.WorkspaceSize = screensize.Size;
            this.Size = screensize.Size;
            this.Location = screensize.Location;
        }
        //Populate POS Items
        private void PopulatePOSItems()
        {
            int itemCount = 20; // Example item count
            int cols = 4; // Number of columns in the grid
            Size maindisplaysize = MainDisplay.Size;
            int panelWidth = maindisplaysize.Width / cols;
            foreach (Products product in AllavailableProducts)
            {
                BunifuShadowPanel itemPanel = new BunifuShadowPanel
                {
                    Width = panelWidth - 10,
                    Height = 150,
                    Margin = new Padding(5),
                    Tag = new ProductInformation
                    {
                        ProductCode = product.ProductCode,
                        ProductID = product.ProductID,
                        ProductPrice = product.Price,
                        ProductName = product.ProductName
                    },
                    /*GradientBottomLeft = ColorTranslator.FromHtml("#ffffff"),
                    GradientBottomRight = ColorTranslator.FromHtml("#ffffff"),
                    GradientTopLeft = ColorTranslator.FromHtml("#ffffff"),
                    GradientTopRight = ColorTranslator.FromHtml("#ffffff"),
                    BorderStyle = BorderStyle.FixedSingle,*/
                    PanelColor = Color.White,
                    PanelColor2 = Color.White,
                    ShadowColor = Color.Maroon,
                    Padding = new Padding(15),
                    
                };
                PictureBox pictureBox = new PictureBox
                {
                    Dock = DockStyle.Top,
                    Width = 100,
                    Height = 60,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.White,
                    Margin = new Padding(0)
                };

                if (product.ProductImage != null)
                {
                    using (var ms = new System.IO.MemoryStream(product.ProductImage))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBox.Image = Properties.Resources.chicken_leg; // Default image
                }

                Label priceLabel = new Label
                {
                    Text = product.Price.ToString("C2"),
                    Dock = DockStyle.Top, // <-- Fill the remaining space
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Padding = new Padding(10, 0, 5, 0),
                    ForeColor = Color.Black
                };

                Label nameLabel = new Label
                {
                    Text = product.ProductName,
                    Dock = DockStyle.Top, // <-- Fill the remaining space
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Padding = new Padding(10, 0, 5, 0),
                    ForeColor = Color.Black
                };



                // Add controls in correct order (IMPORTANT)
                itemPanel.Controls.Add(priceLabel);
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(pictureBox);

                // Add click handlers
                itemPanel.Click += OrderClicked;
                nameLabel.Click += OrderClicked;
                pictureBox.Click += OrderClicked;
                priceLabel.Click += OrderClicked;

                MainDisplay.Controls.Add(itemPanel); // <-- Add to parent here
            }

        }
        //Get Parent Panel
        private BunifuShadowPanel GetParentPanel(Control control)
        {
            while (control != null && !(control is BunifuShadowPanel))
            {
                control = control.Parent;
            }
            return control as BunifuShadowPanel;
        }
        //Check if Product Exists in Current Orders
        private bool IsProductInCurrentOrders(Guid productId)
        {
            return CurrentOrders.Any(o => o.ProductID == productId);
        }
        //Search Ordered Product in Datagrid
        private void SearchOrderedProductInDatagrid(ProductInformation product)
        {
            bool productExists = IsProductInCurrentOrders(product.ProductID);
            if (productExists)
            {
                //Update Quantity in Datagrid
                foreach (DataGridViewRow row in ProductOrdersDatagrid.Rows)
                {
                    if (row.Cells["ProductIdCol"].Value != null && (Guid)row.Cells["ProductIdCol"].Value == product.ProductID)
                    {
                        int currentQuantity = Convert.ToInt32(row.Cells["QuantityCol"].Value);
                        row.Cells["QuantityCol"].Value = currentQuantity + 1;
                        POSProductOrders theOrder = CurrentOrders.FirstOrDefault(o => o.ProductID == product.ProductID);
                        if (theOrder != null)
                        {
                            theOrder.Quantity += 1;
                        }
                        //Update POSTransactionDone Transaction Details
                        POSTransactionDetailsDone transactionDetail = POSTransactionDone.TransactionDetails.FirstOrDefault(td => td.ProductId == product.ProductID);
                        if (transactionDetail != null)
                        {
                            transactionDetail.Quantity += 1;
                        }
                        break;
                    }
                }
            }
            else
            {
                //Add New Product to Datagrid
                int rowIndex = ProductOrdersDatagrid.Rows.Add();
                DataGridViewRow row = ProductOrdersDatagrid.Rows[rowIndex];
                row.Cells["ProductIdCol"].Value = product.ProductID;
                row.Cells["ProductNameCol"].Value = product.ProductName;
                row.Cells["QuantityCol"].Value = 1;
                row.Cells["PriceCol"].Value = product.ProductPrice;
                CurrentOrders.Add(new POSProductOrders
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Quantity = 1,
                    ProductPrice = product.ProductPrice
                });
                //Add to POSTransactionDone Transaction Details
                POSTransactionDone.TransactionDetails.Add(new POSTransactionDetailsDone
                {
                    ProductId = product.ProductID,
                    Quantity = 1,
                    UnitPrice = product.ProductPrice,
                });



            }



        }
        //Get All Avaiable Products from Database
        private async Task GetAllAvailableProducts(PosItemFilter filter)
        {
            AllavailableProducts = new List<Products>();
            POSService posService = new POSService(new SystemBackEnd.BackEndDBContext());
            AllavailableProducts = await posService.GetAllAvailableProducts(filter);
            PopulatePOSItems();
        }
        //Back from Inventory Form --To be Fixed Later--
        private void BackFromInventoryForm()
        {
            //Add Logic Here Later
            //Checks if the User has access to Inventory Form
            if (CurrentLoggedinAccount.IsOwner == true)
            {
                this.Hide();
                MainPage mainLayout = new MainPage();
                mainLayout.Show();
            }
            else
            {
                if (MessageBox.Show("Do you want to Logout", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Program.theLoggedInAccount = null;
                    Close();
                    Log_in login = new();
                    login.Show();
                    this.Close();
                }
            }
        }
        //cALculate Subtotal
        private async Task CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (var order in CurrentOrders)
            {
                subtotal += order.ProductPrice * order.Quantity;
            }
            TotalValue.Text = subtotal.ToString("C2");
            await CalculateTotal();

            //Update POSTransactionDone Payment Details
            POSTransactionDone.Subtotal = subtotal;
            POSTransactionDone.Discount = subtotal * (discountPercentage / 100);
            POSTransactionDone.Total = Total;
        }
        //Update Quantity and Price of CurrentOrders
        private async Task UpdateCurrentOrders(Guid productId, int newQuantity, decimal newPrice)
        {
            POSProductOrders orderToUpdate = CurrentOrders.FirstOrDefault(o => o.ProductID == productId);
            if (orderToUpdate != null)
            {
                orderToUpdate.Quantity = newQuantity;
                orderToUpdate.ProductPrice = newPrice;
                await CalculateSubtotal();
            }
            //Update POSTransactionDone Transaction Details
            POSTransactionDetailsDone transactionDetail = POSTransactionDone.TransactionDetails.FirstOrDefault(td => td.ProductId == productId);
            if (transactionDetail != null)
            {
                transactionDetail.Quantity = newQuantity;
                transactionDetail.UnitPrice = newPrice;
            }

        }
        //Calculate Total with or without Discount
        private async Task CalculateTotal()
        {
            decimal subtotal = 0;
            foreach (var order in CurrentOrders)
            {
                subtotal += order.ProductPrice * order.Quantity;
            }
            decimal discountAmount = subtotal * (discountPercentage / 100);
            Total = subtotal - discountAmount;
            TotalValue.Text = Total.ToString("C2");
        }
        //Show Payment Modal
        private async Task ShowPaymentModal()
        {
            Form Backgroundmodal = new Form();
            using (POSPaymentModal modalcontent = new POSPaymentModal(POSTransactionDone))
            {
                var mainbounds = this.Bounds;

                Backgroundmodal.StartPosition = FormStartPosition.Manual;
                Backgroundmodal.FormBorderStyle = FormBorderStyle.None;
                Backgroundmodal.Opacity = .60d;
                Backgroundmodal.BackColor = Color.Black;
                Backgroundmodal.Bounds = mainbounds;
                Backgroundmodal.Size = this.Size;
                Backgroundmodal.Location = this.Location;
                Backgroundmodal.ShowInTaskbar = false;
                Backgroundmodal.Show(this);

                modalcontent.Owner = Backgroundmodal;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                Backgroundmodal.Dispose();
            }
        }
        //Cancel or Reset Order
        private async Task CancelResetOrder()
        {
            CurrentOrders.Clear();
            ProductOrdersDatagrid.Rows.Clear();
            await CalculateSubtotal();
            //Reset POSTransactionDone
            POSTransactionDone = new POSTransactionDone
            {
                TransactionBy = POSTransactionDone.TransactionBy // Retain the TransactionBy
            };
        }
        //Cancel or Reset Order Validation
        private async Task CancelResetOrderValidation()
        {
            if (CurrentOrders.Count != 0)
            {
                DecisionModel decisionModel = new DecisionModel
                {
                    DecisionTitle = "Cancel/New Order",
                    DecisionQuestion = "Are you sure you want to cancel/new order?"
                };
                bool userConfirmed = OpenDecisionModal(decisionModel);
                if (userConfirmed)
                {
                    await CancelResetOrder();
                }
            }
            else
            {
                MessageBox.Show("There are no current orders to cancel/reset.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Open Decision Modal
        private bool OpenDecisionModal(DecisionModel _decision)
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
            {
                var mainBounds = this.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = this.Size;
                ModalBackgorund.Location = this.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(this);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }
        //Populate Navigation Buttons
        private async Task PopulateNavigationButtons()
        {
            // Clear old controls and column styles
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.Dock = DockStyle.Fill;
            // Set the number of columns based on your list
            tableLayoutPanel1.ColumnCount = NavigationButtons.Count;

            // Optional: one row only
            tableLayoutPanel1.RowCount = 1;

            //Percentage based column styles
            float percentage = 100f / NavigationButtons.Count;

            int col = 0;

            foreach (string category in NavigationButtons)
            {
                var navButton = new BunifuButton
                {
                    Text = category,
                    AutoSize = false,            
                    Margin = new Padding(5),
                    Tag = category,
                    Dock = DockStyle.Fill,
                    Width=150,
                    
                };

                
                navButton.onHoverState.BorderColor = Color.FromArgb(255, 240, 221);
                navButton.onHoverState.FillColor = Color.FromArgb(255, 240, 221);
                navButton.onHoverState.ForeColor = Color.Black;
                navButton.OnIdleState.BorderColor = Color.Maroon;
                navButton.OnIdleState.FillColor = Color.Maroon;
                navButton.OnIdleState.ForeColor = Color.White;
                navButton.OnPressedState.BorderColor = Color.Black;
                navButton.OnPressedState.FillColor = Color.FromArgb(198, 40, 40);
                navButton.OnPressedState.ForeColor = Color.White;

                navButton.Click += async (s, e) =>
                {
                    SelectedCategory = (string)navButton.Tag;

                    MainDisplay.Controls.Clear();
                    await GetAllAvailableProducts(new PosItemFilter
                    {
                        SearchValue = SearchValue,
                        Category = SelectedCategory
                    });
                };

                // Add autosizing column
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentage));

                // Add button at specific column/row
                tableLayoutPanel1.Controls.Add(navButton, col, 0);

                col++;
            }

        }



        //Main Load
        private async void PointofSaleForm_Load(object sender, EventArgs e)
        {
            await PopulateNavigationButtons();
            theFilter = new PosItemFilter()
            {
                SearchValue = SearchValue,
                Category = SelectedCategory
            };

            await GetAllAvailableProducts(theFilter);
            ProductOrdersDatagrid.ColumnHeadersHeight = 24;
            ProductOrdersDatagrid.RowTemplate.Height = 24;

            //Initialize POSTransactionDone
            POSTransactionDone.TransactionBy = Guid.NewGuid(); // Replace with actual user ID
            POSEventHandler.PaymentTransactionSuccess += async () =>
            {
                await CancelResetOrder();
            };
        }


        //Handle Order Clicked
        private async void OrderClicked(object sender, EventArgs e)
        {
            BunifuShadowPanel clickedPanel = GetParentPanel((Control)sender);
            ProductInformation productInfo = (ProductInformation)clickedPanel.Tag;
            SearchOrderedProductInDatagrid(productInfo);
            await CalculateSubtotal();
        }
        //Handle Cell Formatting for Datagrid
        private void ProductOrdersDatagrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ProductOrdersDatagrid.Columns[e.ColumnIndex].Name == "ActionCol" && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = ProductOrdersDatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Style.BackColor = Color.Red;
                buttonCell.Style.ForeColor = Color.White;
                buttonCell.Style.SelectionBackColor = Color.DarkRed;
                buttonCell.Style.SelectionForeColor = Color.White;
                buttonCell.FlatStyle = FlatStyle.Flat;
            }
        }
        //Delete Order from Datagrid
        private async void ProductOrdersDatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductOrdersDatagrid.Columns[e.ColumnIndex].Name == "ActionCol")
            {
                Guid productId = (Guid)ProductOrdersDatagrid.Rows[e.RowIndex].Cells["ProductIdCol"].Value;
                ProductOrdersDatagrid.Rows.RemoveAt(e.RowIndex);
                POSProductOrders orderToRemove = CurrentOrders.FirstOrDefault(o => o.ProductID == productId);
                if (orderToRemove != null)
                {
                    CurrentOrders.Remove(orderToRemove);
                }
                await CalculateSubtotal();
            }
        }
        //Logout or Go back to InventoryForm
        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            BackFromInventoryForm();
        }
        //Handle Cell Value Changed in Datagrid
        private async void ProductOrdersDatagrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0
                    && (ProductOrdersDatagrid.Columns[e.ColumnIndex].Name == "QuantityCol" || ProductOrdersDatagrid.Columns[e.ColumnIndex].Name == "PriceCol"))
            {
                await UpdateCurrentOrders(
                    (Guid)ProductOrdersDatagrid.Rows[e.RowIndex].Cells["ProductIdCol"].Value,
                    Convert.ToInt32(ProductOrdersDatagrid.Rows[e.RowIndex].Cells["QuantityCol"].Value),
                    Convert.ToDecimal(ProductOrdersDatagrid.Rows[e.RowIndex].Cells["PriceCol"].Value)
                );
            }
        }
        //Handle Payment Button Click
        private async void PaymentButton_Click(object sender, EventArgs e)
        {
            await ShowPaymentModal();
        }
        //Handle Cancel/Reset Order Button Click
        private async void CancelResetOrderButton_Click(object sender, EventArgs e)
        {

            await CancelResetOrderValidation();
        }

        private void ProductOrdersDatagrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Para sa number lang yung mailagay sa datagridview
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ProductOrdersDatagrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;

            if (ProductOrdersDatagrid.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
            }
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        ///datagrid ulit
        private async void ProductOrdersDatagrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductOrdersDatagrid.Columns[e.ColumnIndex].Name == "ActionCol")
            {
                Guid productId = (Guid)ProductOrdersDatagrid.Rows[e.RowIndex].Cells["ProductIdCol"].Value;
                ProductOrdersDatagrid.Rows.RemoveAt(e.RowIndex);
                POSProductOrders orderToRemove = CurrentOrders.FirstOrDefault(o => o.ProductID == productId);
                if (orderToRemove != null)
                {
                    CurrentOrders.Remove(orderToRemove);
                }
                await CalculateSubtotal();
            }
        }
        private void ProductOrdersDatagrid_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;

            if (ProductOrdersDatagrid.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
            }
        }

        private async void PaymentButton_Click_1(object sender, EventArgs e)
        {
            if (ProductOrdersDatagrid.Rows.Count == 0)
            {
                MessageBox.Show("Please pick at least one item to proceed.", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                await ShowPaymentModal();
            }
        }

        private async void bunifuButton1_Click(object sender, EventArgs e)
        {
            await CancelResetOrderValidation();
        }

        private void bunifuTextBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void MainDisplay_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class ProductInformation
    {
        public Guid ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
