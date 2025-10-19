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
                Panel itemPanel = new Panel
                {
                    Width = panelWidth - 10,
                    Height = 100,
                    Margin = new Padding(5),
                    BackColor = Color.LightGray,
                    Tag = new ProductInformation
                    {
                        ProductCode = product.ProductCode,
                        ProductID = product.ProductID,
                        ProductPrice = product.Price,
                        ProductName = product.ProductName
                    }
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
                    Dock = DockStyle.Fill, // <-- Fill the remaining space
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    Padding = new Padding(10, 0, 0, 0)
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
        private Panel GetParentPanel(Control control)
        {
            while (control != null && !(control is Panel))
            {
                control = control.Parent;
            }
            return control as Panel;
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
            if(productExists)
            {
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


        //Main Load
        private async void PointofSaleForm_Load(object sender, EventArgs e)
        {
            await GetAllAvailableProducts();
            ProductOrdersDatagrid.ColumnHeadersHeight = 24;
        }


        //Envents

        //Handle Order Clicked
        private async void OrderClicked(object sender, EventArgs e)
        {
            Panel clickedPanel = GetParentPanel((Control)sender);
            ProductInformation productInfo = (ProductInformation)clickedPanel.Tag;
            SearchOrderedProductInDatagrid(productInfo);
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
