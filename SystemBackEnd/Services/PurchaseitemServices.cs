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
        public async Task<List<PurchaseItemHeaderDisplay>> GetPurchaseHeaders(SearchItem purchaseitem)
        {
            List<PurchaseItemHeaderDisplay> purchaseItemHeaders = new List<PurchaseItemHeaderDisplay>();
            try
            {
                purchaseItemHeaders = await(from a in _db.PurcahseItemHeader
                                         where a.Purchasenumber.ToLower().Contains(purchaseitem.SearchValue.ToLower())
                                         orderby a.Row descending
                                         select new PurchaseItemHeaderDisplay
                                         {
                                             Purchaseheaderid = a.Purchaseheaderid,
                                             Purchasenumber = a.Purchasenumber,
                                             DateCreated = a.DateCreated,
                                             IsVerified = a.Isverified,
                                             Dateverified = a.Isverified == true ? a.Dateverified : null,
                                             AddedbyName = "No Name",
                                             VerifiedbyName = a.Isverified == true ? "No Name" : null,
                                             Grandtotal = a.Grandtotal
                                         }).ToListAsync();
            }
            catch (Exception e)
            {
                return purchaseItemHeaders;
            }
            return purchaseItemHeaders; 
        }
        //Insert New Purchase Item Header and Details
        public async Task<bool> AddPurchaseItem(InsertPurchaseItem newitem)
        {
            bool isadded = false;
            try
            {
                Guid _PurchaseItemHeaderID = Guid.NewGuid();

                //Insert Header
                PurchaseItemHeader _newheader = new PurchaseItemHeader()
                {
                    Purchaseheaderid = _PurchaseItemHeaderID,
                    DateCreated = DateTime.Now,
                    Addedby = newitem.Addedby,
                    Isverified = false,
                    Grandtotal = 0
                };
                await _db.PurcahseItemHeader.AddAsync(_newheader);
                await _db.SaveChangesAsync();

                _newheader = new PurchaseItemHeader();
                _newheader = await _db.PurcahseItemHeader.Where(x => x.Purchaseheaderid == _PurchaseItemHeaderID).FirstOrDefaultAsync();
                _newheader.Purchasenumber = $"P-{DateTime.Now.ToString("yyyyMMddHHmmss")}-{_newheader.Row.ToString("D4")}";
                _db.PurcahseItemHeader.Update(_newheader);
                await _db.SaveChangesAsync();

                //Insert Details
                decimal _totalamount = 0;

                foreach (var item in newitem.PurchaseItemDetails)
                {
                    PurchaseitemDetails _newdetails = new PurchaseitemDetails()
                    {
                        Purchasedetailsid = Guid.NewGuid(),
                        Purchaseheaderid = _PurchaseItemHeaderID,
                        ItemID = item.ItemID,
                        Quantity = item.Quantity,
                        Priceperunit = item.Unitprice
                    };
                    _totalamount += (item.Quantity * item.Unitprice);
                    await _db.AddAsync(_newdetails);
                    await _db.SaveChangesAsync();
                }

                //Update the Grand Total
                _newheader = new PurchaseItemHeader();
                _newheader = await _db.PurcahseItemHeader.Where(x => x.Purchaseheaderid == _PurchaseItemHeaderID).FirstOrDefaultAsync();
                _newheader.Grandtotal = _totalamount;
                _db.PurcahseItemHeader.Update(_newheader);
                await _db.SaveChangesAsync();
                isadded = true;
            }
            catch (Exception e)
            {
                
            }
            return isadded;

        }
        //Get PurchaseItem Details and Header
        //-- Fix this after adding user table --
        public async Task<ViewPurchaseItem> GetPurchaseItemDetailsandHeader(Guid PurchaseItemHeaderId)
        {
            ViewPurchaseItem _viewpurchaseitem = new ViewPurchaseItem();
            _viewpurchaseitem._PurcahseItemHeader = new PurchaseItemHeader();
            _viewpurchaseitem._PurchaseItemDetails = new List<PurchaseItemDetailswithItemName>();
            try
            {
                //For Header
                _viewpurchaseitem._PurcahseItemHeader = await _db.PurcahseItemHeader.Where(x => x.Purchaseheaderid == PurchaseItemHeaderId).FirstOrDefaultAsync();

                //For Details with Item Name
                _viewpurchaseitem._PurchaseItemDetails = await (from a in _db.PurchaseItemDetails
                                                                join b in _db.Items on a.ItemID equals b.ItemID
                                                                where a.Purchaseheaderid == PurchaseItemHeaderId
                                                                select new PurchaseItemDetailswithItemName
                                                                {
                                                                    Purchasedetailsid = a.Purchasedetailsid,
                                                                    Purchaseheaderid = a.Purchaseheaderid,
                                                                    ItemID = a.ItemID,
                                                                    ItemName = b.ItemName,
                                                                    Quantity = a.Quantity,
                                                                    Priceperunit = a.Priceperunit
                                                                }).ToListAsync();
            }
            catch (Exception e)
            {

            }
            return _viewpurchaseitem;
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
