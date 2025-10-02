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
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Pages
{
    public partial class ProductsInventory : Form
    {
        private List<Products> _theproducts = new();
        private Form Mainform;
        private int _currentPage;
        private int _productsperpage = 12;
        private int _totalproducts;
        private int _maxpages;

        //Constructor
        public ProductsInventory(Form _MainForm)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }
        }

        private async void ProductsInventory_Load(object sender, EventArgs e)
        {
            await CheckAllProductsCount();
            await LoadProducts();
        }
        //Load Data
        private async Task LoadProducts()
        {
            _theproducts = new List<Products>();
            ProductServices _productservices = new ProductServices(new BackEndDBContext());
            _theproducts = await _productservices.GetAllProductsByPagination(new SearchItem
            {
                PageNumber = _currentPage,
                ItemperPage = _productsperpage
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
                    row.Cells["RowCol"].Value = item.Row;
                    row.Cells["ProductCodeCol"].Value = item.ProductCode;
                    row.Cells["ProductNameCol"].Value = item.ProductName;
                    row.Cells["QuantityCol"].Value = item.Quantity;
                    row.Cells["PriceCol"].Value = item.Price;
                }
            }
        }
        //Get All Products Count
        private async Task CheckAllProductsCount()
        {
            _currentPage = 1;
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
                PaginationLabel.Text = $"{_currentPage}";//Pagination Label
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
                PaginationLabel.Text = $"{_currentPage}";//Pagination Label
                await CheckPageNumber();
                await LoadProducts();
            }
        }
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


        //Evemts
        private async void PaginationPREV_Click(object sender, EventArgs e)
        {
            await PreviousButton_Click();
        }
        private async void PaginationNext_Click(object sender, EventArgs e)
        {
            await NextButton_Click();
        }
    }
}
