using Bunifu.UI.WinForms;
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
                BunifuGradientPanel itemPanel = new BunifuGradientPanel
                {
                    Width = panelWidth - 10,
                    Height = 100,
                    Margin = new Padding(5),
                    Tag = new ProductInformation
                    {
                        ProductCode = product.ProductCode,
                        ProductID = product.ProductID,
                        ProductPrice = product.Price,
                        ProductName = product.ProductName
                    },
                    GradientBottomLeft = ColorTranslator.FromHtml("#FF6A00"),
                    GradientBottomRight = ColorTranslator.FromHtml("#D00000"),
                    GradientTopLeft = ColorTranslator.FromHtml("#FFF5CC"),
                    GradientTopRight = ColorTranslator.FromHtml("#FFD93D"),
                    Padding = new Padding(3)
                };
                PictureBox pictureBox = new PictureBox
                {
                    Dock = DockStyle.Left,
                    Width = 100,
                    SizeMode = PictureBoxSizeMode.Zoom,
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

                Label nameLabel = new Label
                {
                    Text = product.ProductName,
                    Dock = DockStyle.Top, // <-- Fill the remaining space
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Padding = new Padding(10, 0, 5, 0),
                    ForeColor = Color.White
                };

                // Add controls in correct order (IMPORTANT)
                itemPanel.Controls.Add(nameLabel);
                itemPanel.Controls.Add(pictureBox);

                // Add click handlers
                itemPanel.Click += OrderClicked;
                nameLabel.Click += OrderClicked;
                pictureBox.Click += OrderClicked;

                MainDisplay.Controls.Add(itemPanel); // <-- Add to parent here
            }

        }
        //Get Parent Panel
        private BunifuGradientPanel GetParentPanel(Control control)
        {
            while (control != null && !(control is BunifuGradientPanel))
            {
                control = control.Parent;
            }
            return control as BunifuGradientPanel;
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
            }

        }
        //Get All Avaiable Products from Database
        private async Task GetAllAvailableProducts()
        {
            AllavailableProducts = new List<Products>();
            POSService posService = new POSService(new SystemBackEnd.BackEndDBContext());
            AllavailableProducts = await posService.GetAllAvailableProducts();
            PopulatePOSItems();
        }
        //Back from Inventory Form --To be Fixed Later--
        private void BackFromInventoryForm()
        {
            //Add Logic Here Later
            //Checks if the User has access to Inventory Form
            this.Hide();
            MainPage mainLayout = new MainPage();
            mainLayout.Show();
        }
        //cALculate Subtotal
        private async Task CalculateSubtotal()
        {
            decimal subtotal = 0;
            foreach (var order in CurrentOrders)
            {
                subtotal += order.ProductPrice * order.Quantity;
            }
            Subtotalvalue.Text = subtotal.ToString("C2");
            await CalculateTotal();
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
        


        //Main Load
        private async void PointofSaleForm_Load(object sender, EventArgs e)
        {
            await GetAllAvailableProducts();
            ProductOrdersDatagrid.ColumnHeadersHeight = 24;
            ProductOrdersDatagrid.RowTemplate.Height = 24;
        }


        //Handle Order Clicked
        private async void OrderClicked(object sender, EventArgs e)
        {
            Panel clickedPanel = GetParentPanel((Control)sender);
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
    }

    public class ProductInformation
    {
        public Guid ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
