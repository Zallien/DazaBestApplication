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
                                   .Where(x => x.IsActive == true)
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
    }
}
