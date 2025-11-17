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
    public class AdjustItemServices
    {
        public BackEndDBContext _db;

        public AdjustItemServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Insert New Adjustment Informations
        public async Task<bool> InsertNewItemAdjustmentInformation(AdjustmentItemFullInformation _fullinfo)
        {
            bool isAdded = false;
            try
            {
                Guid HeaderId = Guid.NewGuid();
                //Header
                ItemAdjustmentHeader itemAdjustmentHeader = new ItemAdjustmentHeader()
                {
                    ReferenceHeaderId = HeaderId,
                    DateOperated = DateTime.Now,
                    OperatedBy = _fullinfo.OperatedBy,
                    ReferenceNumber = ""
                };
                await _db.AddAsync(itemAdjustmentHeader);

                //Details
                foreach (var item in _fullinfo.AllAdjustments)
                {
                    ItemAdjustmentDetails details = new ItemAdjustmentDetails()
                    {
                        ReferenceHeaderId = HeaderId,
                        ReferenceDetailsId = Guid.NewGuid(),
                        ItemId = item.ItemId,
                        RemovedQuantity = item.ItemQuantity,
                        Reason = item.Reason,
                    };
                    await UpdateBalanceStock(item.ItemId, item.ItemQuantity);
                    await _db.AddAsync(details);
                }
                await _db.SaveChangesAsync();
                //Add ReferenceNumber
                ItemAdjustmentHeader theheader = await _db.ItemAdjustmentHeader.FirstOrDefaultAsync(x => x.ReferenceHeaderId == HeaderId);
                if (theheader != null && theheader.ReferenceNumber == "")
                {
                    int countToday = await _db.ItemAdjustmentHeader
                        .CountAsync(x => x.DateOperated.Date == DateTime.Today);
                    string referenceNumber = $"ADJ-{DateTime.Now:yyyyMMdd}-{(countToday + 1):D4}";
                    theheader.ReferenceNumber = referenceNumber;
                    _db.Update(theheader);
                    await _db.SaveChangesAsync();
                    isAdded = true;
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return isAdded;
        }
        //Get Header List
        public async Task<List<AdjustItemHeaderwithOperatedName>> GetAdjustItemHeader(SearchItem searchvalue)
        {
            List<AdjustItemHeaderwithOperatedName> _thelist = new();
            try
            {
                //TO BE FIX WHEN ACCOUNT IS FIXED
                _thelist = await (from a in _db.ItemAdjustmentHeader
                                  join b in _db.Accounts
                                  on a.OperatedBy equals b.AccountId
                                  where a.ReferenceNumber.ToLower().Contains(searchvalue.SearchValue.ToLower())
                                  orderby a.DateOperated descending
                                  select new AdjustItemHeaderwithOperatedName
                                  {
                                      DateCreated = a.DateOperated,
                                      OperatedByName = b.Fullname,
                                      ReferenceHeaderId = a.ReferenceHeaderId,
                                      ReferenceNumber = a.ReferenceNumber
                                  }).Skip((searchvalue.PageNumber - 1) * searchvalue.ItemperPage)
                                   .Take(searchvalue.ItemperPage)
                                   .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return _thelist;
        }
        //Get ViewAdjustItem Details
        public async Task<ViewAdjustItem> GetViewAdjustItem(Guid theHeaderId)
        {
            ViewAdjustItem viewAdjustItem = new ViewAdjustItem();
            try
            {

                var theheader = await _db.ItemAdjustmentHeader.Where(x => x.ReferenceHeaderId == theHeaderId).FirstOrDefaultAsync();
                var theitems = await (from a in _db.ItemAdjustmentDetails
                                      join b in _db.Items
                                      on a.ItemId equals b.ItemID
                                      where a.ReferenceHeaderId == theHeaderId
                                      select new AdjustItemDetailswithItemName
                                      {
                                          ItemId = a.ItemId,
                                          ItemName = b.ItemName,
                                          ReferenceDetailsId = a.ReferenceDetailsId,
                                          Reason = a.Reason,
                                          ReferenceHeaderId = a.ReferenceHeaderId,
                                          RemovedQuantity = a.RemovedQuantity,
                                      }).ToListAsync();
                if (theitems != null)
                {
                    viewAdjustItem.AdjustItemDetailswithName = theitems;
                }
                if (theheader != null)
                {
                    viewAdjustItem.AdjustItemHeader = theheader;
                }
            }
            catch (Exception e)
            {

            }

            return viewAdjustItem;
        }
        //Check ItemStock
        public async Task<bool> CheckItemStock(Guid ItemId, decimal stockInput)
        {
            bool isStockAcceptable = false;
            try
            {
                var item = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == ItemId);
                if (item != null)
                {
                    bool acceptable = item.BalanceStocks >= stockInput ? true : false;
                    isStockAcceptable = acceptable;
                    return isStockAcceptable;
                }

            }
            catch (Exception)
            {

            }
            return isStockAcceptable;
        }
        //Update Inventory Stocks
        private async Task UpdateBalanceStock(Guid itemId, decimal stockremoved)
        {
            try
            {
                var item = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == itemId);
                if (item != null)
                {
                    item.BalanceStocks -= stockremoved;
                }
            }
            catch (Exception e)
            {

            }
        }
        //Get Operated By using HeaderId
        public async Task<string> GetOperatedByName(Guid headerId)
        {
            string operatedByName = "";
            try
            {
                var result = await (from a in _db.ItemAdjustmentHeader
                                    join b in _db.Accounts
                                    on a.OperatedBy equals b.AccountId
                                    where a.ReferenceHeaderId == headerId
                                    select b.Fullname).FirstOrDefaultAsync();
                if (result != null)
                {
                    operatedByName = result;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return operatedByName;




        }
        //Get Total Pages
        public async Task<int> GetTotalPages(int itemperpage)
        {
            int totalpages = 0;
            try
            {
                int totalitems = await _db.ItemAdjustmentHeader.CountAsync();
                totalpages = (int)Math.Ceiling((double)totalitems / itemperpage);
            }
            catch (Exception)
            {
                throw;
            }
            return totalpages;
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
                                        && !item.AllSelectedItem.Contains(x.ItemID) && x.BalanceStocks > 0.0m)
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


    }
}
