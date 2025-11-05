using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class ItemReportServices
    {

        private BackEndDBContext _db;

        public ItemReportServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get Item Report Details
        public async Task<List<ItemsReportDetails>> GetItemsReportDetails(SearchItem searchitem)
        {
            List<ItemsReportDetails> result = new List<ItemsReportDetails>();
            try
            {
                result = await (from a in _db.Items
                                select new ItemsReportDetails
                                {
                                    ItemId = a.ItemID,
                                    ItemName = a.ItemName,
                                    BalanceStock = a.BalanceStocks,
                                    Price = a.ItemPrice,
                                    DateCreated = a.DateCreated,
                                    ItemCode = a.ItemCode
                                })
                                .Skip((searchitem.PageNumber - 1) * searchitem.ItemperPage)
                                .Take(searchitem.ItemperPage)
                                .ToListAsync();
            }
            catch (Exception e)
            {
                
            }

            return result;
        }


    }
}
