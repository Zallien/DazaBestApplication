using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;


namespace SystemBackEnd.Services
{
    public class DashboardServices
    {

        private BackEndDBContext _db;
        public DashboardServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }
        //Load Dashboard Informations
        public async Task<DashboardInformation> GetDashboardInformation(string dashboardType)
        {
            DateTime now = DateTime.Now;

            var (fromDate, toDate, Qouta) = dashboardType switch
            {
                "Daily" => (now.Date, now.Date, 3000m),
                "Weekly" => (now.Date.AddDays(-(int)now.DayOfWeek), now.Date, 5000m),
                "Monthly" => (new DateTime(now.Year, now.Month, 1), now.Date, 10000m),
                "Yearly" => (new DateTime(now.Year, 1, 1), now.Date, 30000m),

                _ => throw new ArgumentException("Invalid dashboard type.")
            };

            SystemBackEnd.ServiceModels.DashboardInformation dashinfo = new SystemBackEnd.ServiceModels.DashboardInformation();
            try
            {
                dashinfo.Qouta = Qouta;
                dashinfo.ItemsCount = await _db.Items.Where(x => x.IsActive == true).CountAsync();
                dashinfo.OrdersCount = await _db.TransactionHeader
                                        .Where(x => x.TransactionDate.Date >= fromDate &&
                                                    x.TransactionDate.Date <= toDate)
                                        .CountAsync();
                dashinfo.TotalSale = await (from a in _db.TransactionHeader
                                            join b in _db.TransactionDetails on a.TransactionHeaderId equals b.TransactionHeaderId
                                            where a.TransactionDate.Date >= fromDate && a.TransactionDate.Date <= toDate
                                            select a.Grandtotal).SumAsync();
                dashinfo.ProductsCount =  await _db.Products.CountAsync();
                dashinfo.CriticalItems =  await _db.Items.Where(x => x.BalanceStocks <= 10m).CountAsync();
                dashinfo.OutofStockCount =  await _db.Items.Where(x => x.BalanceStocks == 0m).CountAsync();
                dashinfo.OverstockItems =  await _db.Items.Where(x => x.BalanceStocks <= 50m).CountAsync();
                var Topsellingtable = await (from a in _db.TransactionDetails
                                                  join b in _db.Products on a.ProductId equals b.ProductID
                                                  join c in _db.TransactionHeader on a.TransactionHeaderId equals c.TransactionHeaderId
                                                  group a by new { a.ProductId, b.ProductName } into d
                                                  orderby d.Count() descending
                                                  select new DashboardItems()
                                                  {
                                                      ProductId = d.Key.ProductId,
                                                      ProductName = d.Key.ProductName
                                                  })
                                             .Take(3)
                                             .ToListAsync();
                dashinfo.TopSellingItems = Topsellingtable;
                var leastsellingtalbe = await (from a in _db.TransactionDetails
                                                    join b in _db.Products on a.ProductId equals b.ProductID
                                                    join c in _db.TransactionHeader on a.TransactionHeaderId equals c.TransactionHeaderId
                                                    group a by new { a.ProductId, b.ProductName } into d
                                                    orderby d.Count() ascending
                                                    select new DashboardItems()
                                                    {
                                                        ProductId = d.Key.ProductId,
                                                        ProductName = d.Key.ProductName
                                                    })
                                                  .Take(3)
                                                  .ToListAsync();
                dashinfo.LeastSellingItems = leastsellingtalbe;
                dashinfo.ForChart = await (from a in _db.TransactionDetails
                                                join b in _db.Products on a.ProductId equals b.ProductID
                                                join c in _db.TransactionHeader on a.TransactionHeaderId equals c.TransactionHeaderId
                                                where c.TransactionDate.Date >= fromDate && c.TransactionDate.Date <= toDate
                                                group a by new { a.ProductId, b.ProductName } into d
                                                orderby d.Count() descending
                                                select new DashboardItems()
                                                {
                                                    ProductId = d.Key.ProductId,
                                                    ProductName = d.Key.ProductName,
                                                    ProducsSold = d.Count()
                                                })
                                              .ToListAsync();




            }
            catch (Exception ex)
            {

            }

            return dashinfo;
        }

    }
}
