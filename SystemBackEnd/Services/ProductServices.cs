using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class ProductServices
    {
        private BackEndDBContext _db;

        public ProductServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //GetData By Pagination
        public async Task<List<Products>> GetAllProductsByPagination(SearchItem product)
        {
            List<Products> _theproducts = new();
            try
            {
                _theproducts = await _db.Products
                                   .Where(x => x.IsActive == true && x.BusinessCategory == product.ProductBusiness)
                                   .OrderByDescending(x => x.Row)
                                   .Skip((product.PageNumber - 1) * product.ItemperPage)
                                   .Take(product.ItemperPage)
                                   .ToListAsync();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _theproducts;
        }
        //Gwt Products Count
        public async Task<int> GetProductsCount(SearchItem product)
        {
            int _thecount = 0;
            try
            {
                _thecount = await _db.Products
                                   .Where(x => x.IsActive == true &&
                                               (x.ProductName!.ToLower().Contains(product.SearchValue.ToLower()) ||
                                                x.ProductCode!.ToLower().Contains(product.SearchValue.ToLower())))
                                               .CountAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _thecount;
        }
        //Search Products
        public async Task<List<Products>> SearchProducts(SearchItem product)
        {
            List<Products> _theproducts = new();
            try
            {
                _theproducts = await _db.Products
                                   .Where(x => x.IsActive == true &&
                                               (x.ProductName!.ToLower().Contains(product.SearchValue.ToLower()) ||
                                                x.ProductCode!.ToLower().Contains(product.SearchValue.ToLower())))
                                   .OrderByDescending(x => x.Row)
                                   .Skip((product.PageNumber - 1) * product.ItemperPage)
                                   .Take(product.ItemperPage)
                                   .ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _theproducts;
        }
        //Toggle Product Status
        public async Task<bool> ToggleProductStatus(Guid _productid)
        {
            bool _issuccess = false;
            try
            {
                var _theproduct = await _db.Products.Where(x => x.ProductID == _productid).FirstOrDefaultAsync();
                if (_theproduct != null)
                {
                    _theproduct.IsActive = false;
                    await _db.SaveChangesAsync();
                    _issuccess = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _issuccess;
        }
        //Add Product
        public async Task<bool> AddProduct(InsertProduct product)
        {
            bool _issuccess = false;
            try
            {
                Guid _theid = Guid.NewGuid();
                Products _theaddedproduct = new Products()
                {
                    ProductID = _theid,
                    ProductName = product.ProductName,
                    IsActive = true,
                    ProductCode = "",
                    DateCreated = DateTime.Now,
                    Quantity = 0,
                    Price = product.ProductPrice,
                    IsAvailable = false,
                    ProductImage = product.ProductPicture,
                    Category = product.Category,
                    BusinessCategory = product.BusinessCategory,
                };
                await _db.Products.AddAsync(_theaddedproduct);
                await _db.SaveChangesAsync();
                //Generate Product Code
                _theaddedproduct = new Products();
                _theaddedproduct = await _db.Products.Where(x => x.ProductID == _theid).FirstOrDefaultAsync();
                _theaddedproduct.ProductCode = "PR" + _theaddedproduct.Row.ToString("D4");
                _db.Update(_theaddedproduct);
                await _db.SaveChangesAsync();
                _issuccess = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _issuccess;
        }
        //Change Availability Status
        public async Task<bool> ChangeAvailability(Guid _productid)
        {
            bool _issuccess = false;
            try
            {
                Products _theproduct = await _db.Products.FirstOrDefaultAsync(x => x.ProductID == _productid);
                if (_theproduct != null)
                {
                    _theproduct.IsAvailable = !_theproduct.IsAvailable;
                    _db.Update(_theproduct);
                    await _db.SaveChangesAsync();
                    _issuccess = true;
                }
            }
            catch (Exception e)
            {

            }
            return _issuccess;
        }
        //Update Product
        public async Task<bool> UpdateProduct(EditProduct _editedproduct)
        {
            bool _issuccess = false;
            try
            {
                Products _theproduct = await _db.Products.FirstOrDefaultAsync(x => x.ProductID == _editedproduct.ProductID);
                if (_theproduct != null)
                {
                    _theproduct.ProductName = _editedproduct.ProductName;
                    _theproduct.Price = _editedproduct.ProductPrice;
                    _theproduct.ProductImage = _editedproduct.ProductImage;
                    _theproduct.Category = _editedproduct.Category;
                    _theproduct.BusinessCategory = _editedproduct.BusinessCategory;
                    _db.Update(_theproduct);
                    await _db.SaveChangesAsync();
                    _issuccess = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _issuccess;
        }
        //Get Product Image By ID
        public async Task<byte[]?> GetProductImageByID(Guid _productid)
        {
            byte[]? _theimage = null;
            try
            {
                Products _theproduct = await _db.Products.FirstOrDefaultAsync(x => x.ProductID == _productid);
                if (_theproduct != null)
                {
                    _theimage = _theproduct.ProductImage;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _theimage;
        }
        //Get ProductCategory By Id
        public async Task<string> GetProductCategoryByID(Guid _productid)
        {
            string _thecategory = "";
            try
            {
                Products _theproduct = await _db.Products.FirstOrDefaultAsync(x => x.ProductID == _productid);
                if (_theproduct != null)
                {
                    _thecategory = _theproduct.Category;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _thecategory;



        }
        //Get ProductBusinessCategory By Id
        public async Task<string> GetProductBusinessCategory(Guid _productid)
        {
            string _thecategory = "";
            try
            {
                Products _theproduct = await _db.Products.FirstOrDefaultAsync(x => x.ProductID == _productid);
                if (_theproduct != null)
                {
                    _thecategory = _theproduct.BusinessCategory;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return _thecategory;



        }
    }
}
