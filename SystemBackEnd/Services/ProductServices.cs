using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        //private async Task<List<Products>> GetAllProductsByPagination(int pageNumber, int itemPerPage)
        //{
        //    List<Products> _theproducts = new();
        //    try
        //    {
        //        _theproducts = await _db.Products
        //                           .Where(x => x.IsActive == true)
        //                           .OrderByDescending(x => x.Row)
        //                           .Skip((pageNumber - 1) * itemPerPage)
        //                           .Take(itemPerPage)
        //                           .ToListAsync();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return _theproducts;
        //}
    }
}
