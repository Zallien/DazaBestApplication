using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;

namespace SystemBackEnd.Services
{
    public class POSService
    {
        private BackEndDBContext _db;
        public POSService(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get All Available Products
        public async Task<List<Products>> GetAllAvailableProducts()
        {
            List<Products> products = new();
            try
            {
                products = await _db.Products.Where(x => x.IsActive == true && x.IsAvailable == true).ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }
    }
}
