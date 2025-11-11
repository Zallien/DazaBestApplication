using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class StockInReportServices
    {

        private BackEndDBContext _db;
        public StockInReportServices(BackEndDBContext mdb)
        {
            _db = mdb;

        }

        //Get PurchaseItemDetails for Reports
        public async Task<List<StockInReportsDetails>> GetStockInDetails(RecordsFilterSearch searchfilter)
        {
            List<StockInReportsDetails> stockindetails = new List<StockInReportsDetails>();
            try
            {
                stockindetails = await (from a in _db.PurcahseItemHeader
                                        join b in _db.PurchaseItemDetails on a.Purchaseheaderid equals b.Purchaseheaderid
                                        join c in _db.Items on b.ItemID equals c.ItemID
                                        join d in _db.Accounts on a.Addedby equals d.AccountId
                                        where (!searchfilter.FromDate.HasValue || a.DateCreated >= searchfilter.FromDate.Value)
                                             && (!searchfilter.ToDate.HasValue || a.DateCreated <= searchfilter.ToDate.Value)
                                             && (string.IsNullOrEmpty(searchfilter.SearchValue) || a.Purchasenumber.Contains(searchfilter.SearchValue))
                                        select new StockInReportsDetails()
                                        {
                                            PurchaseItemDetailsId = b.Purchasedetailsid,
                                            PurchaseItemNumber = a.Purchasenumber,
                                            ItemName = c.ItemName,
                                            Quantity = b.Quantity,
                                            UnitPrice = b.Priceperunit,
                                            TotalPrice = (b.Quantity * b.Priceperunit),
                                            Date = a.DateCreated,
                                            AddedBy = d.Fullname
                                        })
                                        .Skip((searchfilter.PageNumber - 1) * searchfilter.ItemperPage)
                                        .Take(searchfilter.ItemperPage)
                                        .ToListAsync();
            }
            catch (Exception e)
            {
                
            }

            return stockindetails;


        }

        //Get total Page
        public async Task<int> Gettotalpage(RecordsFilterSearch searchfilter)
        {
            int totalpages = 0;
            try
            {
                int totalitems = await (from a in _db.PurcahseItemHeader
                                    join b in _db.PurchaseItemDetails on a.Purchaseheaderid equals b.Purchaseheaderid
                                    join c in _db.Items on b.ItemID equals c.ItemID
                                    join d in _db.Accounts on a.Addedby equals d.AccountId
                                    where (!searchfilter.FromDate.HasValue || a.DateCreated >= searchfilter.FromDate.Value)
                                         && (!searchfilter.ToDate.HasValue || a.DateCreated <= searchfilter.ToDate.Value)
                                         && (string.IsNullOrEmpty(searchfilter.SearchValue) || a.Purchasenumber.Contains(searchfilter.SearchValue))
                                    select new StockInReportsDetails()
                                    {
                                        PurchaseItemDetailsId = b.Purchasedetailsid,
                                        PurchaseItemNumber = a.Purchasenumber,
                                        ItemName = c.ItemName,
                                        Quantity = b.Quantity,
                                        UnitPrice = b.Priceperunit,
                                        TotalPrice = (b.Quantity * b.Priceperunit),
                                        Date = a.DateCreated,
                                        AddedBy = d.Fullname
                                    }).CountAsync();
                totalpages = (totalitems / searchfilter.ItemperPage) + 1;
            }
            catch (Exception ex)
            {

            }

            return totalpages;
        }




    }
}
