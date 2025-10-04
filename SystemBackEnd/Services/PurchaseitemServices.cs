using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Models;
using SystemBackEnd.Migrations;
using Microsoft.EntityFrameworkCore;

namespace SystemBackEnd.Services
{
    public class PurchaseitemServices
    {
        public BackEndDBContext _db;

        public PurchaseitemServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get All Purchase Header
        public async Task<List<PurchaseItemHeader>> GetPurchaseHeaders(SearchItem purchaseitem)
        {
            List<PurchaseItemHeader> purchaseItemHeaders = new List<PurchaseItemHeader>();
            try
            {
                purchaseItemHeaders = await _db.PurcahseItemHeader
                                       .OrderByDescending(x => x.Row)
                                       .Skip((purchaseitem.PageNumber - 1) * purchaseitem.ItemperPage)
                                       .Take(purchaseitem.ItemperPage)
                                       .ToListAsync();
            }
            catch (Exception e)
            {
                return purchaseItemHeaders;
            }
            return purchaseItemHeaders; 
        }
    }
}
