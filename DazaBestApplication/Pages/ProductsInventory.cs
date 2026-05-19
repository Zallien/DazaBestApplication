using DazaBestApplication.Modals;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class ProductsInventory : Form
    {
        private List<Products> _theproducts = new();
        private ProductModal _productmodal = new();
        private Form Mainform;
        private int _currentPage;
        private int _productsperpage = 12;
        private int _totalproducts;
        private int _maxpages;
        private DecisionModel _decision;
        private string ProductsBusiness = "Karinderya";
        private List<string> Businesses = new List<string>()
        {
            "Karinderya",
            "Food Stall"
        };
        private NotificationModel _notificationmodel;

        //Constructor
        public ProductsInventory(Form _MainForm)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }
        }
        //Main Load
        private async void ProductsInventory_Load(object sender, EventArgs e)
        {
            await CheckAllProductsCount();
            await CheckPageNumber();
            await LoadProducts();
            PaginationLabel.Text = $"{_currentPage} / {_maxpages}";//Pagination Label
            HookEvents();
            Setfilterpanel();

        }

        //Hook Events
        private void HookEvents()
        {
            ProductEventHandlers.ProductInventoryChanged += LoadProducts;
            Deletetoolstrip.Click += DeleteusingDelToolstrip;
        }
        //Load Data
        private async Task LoadProducts()
        {
            _theproducts = new List<Products>();
            ProductServices _productservices = new ProductServices(new BackEndDBContext());
            _theproducts = await _productservices.GetAllProductsByPagination(new SearchItem
            {
                PageNumber = _currentPage,
                ItemperPage = _productsperpage,
                ProductBusiness = ProductsBusiness
            });
            PopulateProductsDatagrid(_theproducts);
        }
        //Populate ProductDatagrid
        private void PopulateProductsDatagrid(List<Products> _productsparam)
        {
            AllProductDatagridView.Rows.Clear();
            if (_productsparam.Count > 0)
            {
                foreach (var item in _productsparam)
                {   
                    int rowindex = AllProductDatagridView.Rows.Add();
                    DataGridViewRow row = AllProductDatagridView.Rows[rowindex];
                    row.Cells["IdCol"].Value = item.ProductID;
                    row.Cells["ProductCodeCol"].Value = item.ProductCode;
                    row.Cells["ProductNameCol"].Value = item.ProductName;
                    row.Cells["PriceCol"].Value = "₱" + item.Price;
                    row.Cells["AvailabilityCol"].Value = item.IsAvailable == true ? Properties.Resources.check :
                                        Properties.Resources.cancel;
                    row.Height = 80;
                }
                AllProductDatagridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            }
        }
        //Get All Products Count
        private async Task CheckAllProductsCount()
        {
            _currentPage = 1;//Reset Current Page
            PaginationLabel.Text = $"{_currentPage}";//Pagination Label
            ProductServices _productservices = new ProductServices(new BackEndDBContext());
            _totalproducts = await _productservices.GetProductsCount(new SearchItem
            {
                SearchValue = SearchBox.Text.Trim(),
                PageNumber = _currentPage,
                ItemperPage = _productsperpage
            });
            //Calculate Total Pages
            _maxpages = _totalproducts % _productsperpage != 0 ? (_totalproducts / _productsperpage) + 1
                                                        : _totalproducts / _productsperpage; ;
        }
        //pagination Previous 
        private async Task PreviousButton_Click()
        {
            if (_currentPage > 1)
            {
                _currentPage--;
                PaginationLabel.Text = $"{_currentPage} / {_maxpages}";//Pagination Label
                await CheckPageNumber();
                await LoadProducts();
            }
        }
        //Pagination Next
        private async Task NextButton_Click()
        {
            if (_currentPage < _maxpages)
            {
                _currentPage++;
                PaginationLabel.Text = $"{_currentPage} / {_maxpages}";//Pagination Label
                await CheckPageNumber();
                await LoadProducts();
            }
        }
        //Check Page Number
        private async Task CheckPageNumber()
        {
            await Task.Delay(200);
            if (_currentPage == 1)
            {
                PaginationPREV.Enabled = false;
            }
            else
            {
                PaginationPREV.Enabled = true;
            }
            if (_currentPage >= _maxpages)
            {
                PaginationNext.Enabled = false;
            }
            else
            {
                PaginationNext.Enabled = true;
            }
        }
        //Search Box
        private async Task SearchProduct()
        {
            _theproducts = new List<Products>();
            ProductServices _productservices = new ProductServices(new BackEndDBContext());
            _theproducts = await _productservices.SearchProducts(new SearchItem
            {
                SearchValue = SearchBox.Text.Trim(),
                PageNumber = _currentPage,
                ItemperPage = _productsperpage
            });
            PopulateProductsDatagrid(_theproducts);
            await CheckAllProductsCount();
            await CheckPageNumber();
            PaginationLabel.Text = $"{_currentPage} / {_maxpages}";//Pagination Label
        }
        //Open Decision Modal
        private bool OpenDecisionModal()
        {
            Form ModalBackgorund = new();
            using (DecisionModal modalcontent = new(_decision))
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

                var result = modalcontent.ShowDialog();

                ModalBackgorund.Dispose();

                return result == DialogResult.Yes;
            }
        }
        //Open Product Modal
        private void OpenProductModal()
        {
            Form ModalBackgorund = new();
            using (ProductModalForm modalcontent = new ProductModalForm(_productmodal))
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
        //Delete Item Validation
        private async Task<Boolean> DeleteProduct(List<ProductID> AllSelectedID)
        {
            try
            {
                foreach (var item in AllSelectedID)
                {
                    ProductServices _productServices = new ProductServices(new BackEndDBContext());
                    if (!await _productServices.ToggleProductStatus(item.ID))
                    {
                        return false;
                    }
                }
                await ProductEventHandlers.InvokeProductChanged();
                await CheckAllProductsCount();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Add New Product
        private void AddNewProduct()
        {
            _productmodal = new ProductModal()
            {
                Action = "AddProduct",
                EditItem = null
            };
            OpenProductModal();
        }
        //Aciton Button
        private async Task ChangeAvailability(Guid _productid)
        {
            ProductServices _productservices = new ProductServices(new BackEndDBContext());
            bool _isSuccess = await _productservices.ChangeAvailability(_productid);
            if (_isSuccess)
            {
                await ProductEventHandlers.InvokeProductChanged();
                _notificationmodel = new NotificationModel()
                {
                    Title = "Availability Changed",
                    Details = "The product availability status has been successfully changed."
                };
                OpenNotificationModal();
            } 
            else
            {
                _notificationmodel = new NotificationModel()
                {
                    Title = "Availability Change Failed",
                    Details = "The product availability status change has failed. Please try again."
                };
                OpenNotificationModal();
            }
        }
        //Edit Product
        private async void EditProduct()
        {
            EditProduct _editproduct = new EditProduct();
            if (AllProductDatagridView.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = AllProductDatagridView.SelectedRows[0];
                _editproduct.ProductPrice = decimal.Parse(
                   selectedRow.Cells["PriceCol"].Value.ToString().Replace("₱", "")
                );
                _editproduct.ProductName = selectedRow.Cells["ProductNameCol"].Value.ToString();
                _editproduct.ProductID = Guid.Parse(selectedRow.Cells["IdCol"].Value.ToString());
                _editproduct.ProductImage = await new ProductServices(new BackEndDBContext())
                                            .GetProductImageByID(_editproduct.ProductID);
                _editproduct.Category = await new ProductServices(new BackEndDBContext())
                                            .GetProductCategoryByID(_editproduct.ProductID);
                _editproduct.BusinessCategory = await new ProductServices(new BackEndDBContext())
                                             .GetProductBusinessCategory(_editproduct.ProductID);
                _productmodal = new ProductModal()
                {
                    Action = "EditProduct",
                    EditItem = _editproduct
                };
                OpenProductModal();
            }
        }
        //Set FilterPanel
        private void Setfilterpanel()
        {
            bunifuShadowPanel1.Location = new Point(filterbutton.Location.X - (bunifuShadowPanel1.Width - filterbutton.Width), filterbutton.Location.Y + filterbutton.Height);

            //populate dropdown in filter
            businesscategorypicked.Items.Clear();
            foreach (var item in Businesses)
            {
                businesscategorypicked.Items.Add(item.ToString());
            }
            //Set Defult value of filter
            businesscategorypicked.Text = ProductsBusiness;
            productperpagetxt.Text = _productsperpage.ToString();
        }
        //Save Filter
        private async Task SaveFilter()
        {

            ProductsBusiness = businesscategorypicked.Text;
            _productsperpage = int.Parse(productperpagetxt.Text);
            await CheckAllProductsCount();
            await CheckPageNumber();
            await LoadProducts();
            PaginationLabel.Text = $"{_currentPage} / {_maxpages}";//Pagination Label
            bunifuShadowPanel1.Visible = false;
        }
        //Open Notification Modal
        private void OpenNotificationModal()
        {
            Form ModalBackgorund = new();
            using (NotificationModal modalcontent = new(_notificationmodel))
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



        //Evemts
        private async void PaginationPREV_Click(object sender, EventArgs e)
        {
            await PreviousButton_Click();
        }
        private async void PaginationNext_Click(object sender, EventArgs e)
        {
            await NextButton_Click();
        }
        private async void SearchBox_TextChange(object sender, EventArgs e)
        {
            await SearchProduct();
        }
        private async void DeleteusingDelToolstrip(object sender, EventArgs e)
        {

            _decision = new DecisionModel()
            {
                DecisionTitle = "Delete Item(s)",
                DecisionQuestion = "Are you sure you want to delete the selected item(s)?"
            };

            var decision = OpenDecisionModal();

            if (decision)
            {
                List<ProductID> AllSelectedID = new List<ProductID>();
                foreach (DataGridViewRow row in AllProductDatagridView.SelectedRows)
                {
                    if (row.Cells["IdCol"].Value != null)
                    {
                        Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllSelectedID.Add(new ProductID { ID = id });
                    }
                }

                if (await DeleteProduct(AllSelectedID))
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Product Deleted",
                        Details = "The selected product(s) have been successfully deleted."
                    };
                    OpenNotificationModal();
                }
                else
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Product Deletion Failed",
                        Details = "The selected product(s) deletion has failed. Please try again."
                    };
                    OpenNotificationModal();
                }
            }
        }//Delete using Del Toolstrip
        private void AllItemsDatagrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (AllProductDatagridView.SelectedRows.Count > 1)
                {
                    Edittoolstrip.Visible = false;
                    sep1.Visible = false;
                }
                else
                {
                    Edittoolstrip.Visible = true;
                    sep1.Visible = true;
                }
                ProductMenuStrip.Show(Cursor.Position);
            }
        }
        private void AddProductBTN_Click(object sender, EventArgs e)
        {
            AddNewProduct();
        }
        private async void AllProductDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && AllProductDatagridView.Columns[e.ColumnIndex].Name == "ActionCol")
            {
                await ChangeAvailability(Guid.Parse(AllProductDatagridView.Rows[e.RowIndex].Cells["IdCol"].Value.ToString()));
            }
        }
        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            _decision = new DecisionModel()
            {
                DecisionTitle = "Delete Item(s)",
                DecisionQuestion = "Are you sure you want to delete the selected item(s)?"
            };

            var decision = OpenDecisionModal();

            if (decision)
            {
                List<ProductID> AllSelectedID = new List<ProductID>();
                foreach (DataGridViewRow row in AllProductDatagridView.SelectedRows)
                {
                    if (row.Cells["IdCol"].Value != null)
                    {
                        Guid id = Guid.Parse(row.Cells["IdCol"].Value.ToString());
                        AllSelectedID.Add(new ProductID { ID = id });
                    }
                }

                if (await DeleteProduct(AllSelectedID))
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Product Deleted",
                        Details = "The selected product(s) have been successfully deleted."
                    };
                    OpenNotificationModal();
                }
                else
                {
                    _notificationmodel = new NotificationModel()
                    {
                        Title = "Product Deletion Failed",
                        Details = "The selected product(s) deletion has failed. Please try again."
                    };
                    OpenNotificationModal();
                }
            }
        }
        private void Edittoolstrip_Click(object sender, EventArgs e)
        {
            EditProduct();
        }
        private void EditButton_Click(object sender, EventArgs e)
        {
            EditProduct();
        }
        private void AllProductDatagridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Customize Action Button Style
            if (AllProductDatagridView.Columns[e.ColumnIndex].Name == "ActionCol" && e.RowIndex >= 0)
            {
                DataGridViewButtonCell buttonCell = AllProductDatagridView.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;
                buttonCell.Style.BackColor = Color.DarkGreen;
                buttonCell.Style.ForeColor = Color.White;
                buttonCell.Style.SelectionBackColor = Color.Green;
                buttonCell.Style.SelectionForeColor = Color.White;
                buttonCell.FlatStyle = FlatStyle.Flat;
            }
        }
        private void filterbutton_Click(object sender, EventArgs e)
        {
            bunifuShadowPanel1.Visible = !bunifuShadowPanel1.Visible;
        }
        private void productperpagetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SaveFilter();
        }


    }
}
