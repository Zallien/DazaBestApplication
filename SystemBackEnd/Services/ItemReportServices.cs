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
                                where (a.ItemName.ToLower().Contains(searchitem.SearchValue.ToLower()) ||
                                       a.ItemCode.ToLower().Contains(searchitem.SearchValue.ToLower())) &&
                                      a.IsActive == true
                                select new ItemsReportDetails
                                {
                                    ItemId = a.ItemID,
                                    ItemName = a.ItemName,
                                    BalanceStock = a.BalanceStocks,
                                    Price = a.ItemPrice,
                                    DateCreated = a.DateCreated,
                                    ItemCode = a.ItemCode,
                                    UnitMeasurement = a.UnitMeasurement,
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

        //Get total pages
        public async Task<int> GetTotalPages(int itemperpage)
        {
            int GetTotalPages = 0;
            try
            {
                int totalcount  = await _db.Items.CountAsync();
                GetTotalPages = (totalcount / itemperpage) + 1;
            }
            catch (Exception ex)
            {

            }
            return GetTotalPages;
        }


    }
}
