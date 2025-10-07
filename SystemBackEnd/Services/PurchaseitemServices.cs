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







        //Get All Available and Active Items 
        public async Task<List<Items>> GetAllActiveProducts(GetAvailableItemswithpagination item)
        {
            List<Items> AllItems = new List<Items>();
            try
            {
                AllItems = await _db.Items
                                    .Where(x => x.IsActive == true 
                                        && (x.ItemName.ToLower().Contains(item.Searchvalue.ToLower()) ||
                                        x.ItemCode.ToLower().Contains(item.Searchvalue.ToLower()))
                                        && !item.AllSelectedItem.Contains(x.ItemID))
                                    .OrderByDescending(x => x.Row)
                                    .Skip((item.Pagenumber - 1) * item.Itemperpage)
                                    .Take(item.Itemperpage)
                                    .ToListAsync();
            }
            catch (Exception e)
            {
                return AllItems;
            }
            return AllItems;
        }
        //Get The Picked Items
        public async Task<PurcahseItemDisplay> GetPickedItem(Guid ItemID)
        {
            PurcahseItemDisplay? _theitem = new PurcahseItemDisplay();
            try
            {
                _theitem = await (from a in _db.Items
                                  where a.ItemID == ItemID
                                  select new PurcahseItemDisplay
                                  {
                                      ItemID = a.ItemID,
                                      ItemName = a.ItemName,
                                      Quantity = 1,
                                      Unitprice = a.ItemPrice ?? 0,
                                      GrandTotal = 0
                                  }).FirstOrDefaultAsync();
            }
            catch (Exception e)
            {

            }

            return _theitem;


        }
    }
}
