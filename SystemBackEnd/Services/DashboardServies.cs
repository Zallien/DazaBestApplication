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
                "Weekly" => (now.Date.AddDays(-(int)now.DayOfWeek), now.Date, 21000m),
                "Monthly" => (new DateTime(now.Year, now.Month, 1), now.Date, 90000m),
                "Yearly" => (new DateTime(now.Year, 1, 1), now.Date, 1095000m),

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
                dashinfo.TotalSale = await _db.TransactionHeader.Where(x => x.TransactionDate.Date >= fromDate.Date && x.TransactionDate.Date
                                    <= toDate.Date).SumAsync(x => x.Grandtotal);


                dashinfo.ProductsCount =  await _db.Products.Where(x => x.IsActive == true).CountAsync();
                dashinfo.CriticalItems =  await _db.Items.Where(x => (x.BalanceStocks > 0.0m && x.BalanceStocks <= 3.0m) && x.IsActive == true).CountAsync();
                dashinfo.OutofStockCount =  await _db.Items.Where(x => x.BalanceStocks == 0m && x.IsActive == true).CountAsync();
                dashinfo.OverstockItems =  await _db.Items.Where(x => x.BalanceStocks >= 10.0m && x.IsActive == true).CountAsync();
                var Topsellingtable = await (
                    from a in _db.TransactionDetails
                    join b in _db.Products on a.ProductId equals b.ProductID
                    join c in _db.TransactionHeader on a.TransactionHeaderId equals c.TransactionHeaderId
                    where b.Category != "Beverage"
                    group a by new { a.ProductId, b.ProductName } into d
                    orderby d.Sum(x => x.Quantity) descending // order by total quantity sold
                    select new DashboardItems
                    {
                        ProductId = d.Key.ProductId,
                        ProductName = d.Key.ProductName,
                        ProducsSold = d.Sum(x => x.Quantity) // sum of quantities per product
                    })
                    .Take(5)
                    .ToListAsync();

                dashinfo.TopSellingItems = Topsellingtable;

                var leastsellingtalbe = await (from a in _db.TransactionDetails
                                                    join b in _db.Products on a.ProductId equals b.ProductID
                                                    join c in _db.TransactionHeader on a.TransactionHeaderId equals c.TransactionHeaderId
                                                    where b.Category != "Beverage"
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
                //Sales Chart Data
                if (dashboardType != "Yearly")
                {
                    var rawData = await _db.TransactionHeader
                        .Where(x => x.TransactionDate.Date >= fromDate && x.TransactionDate.Date <= toDate)
                        .GroupBy(x => x.TransactionDate.Date)
                        .Select(g => new
                        {
                            Date = g.Key, // DateTime
                            SalesValue = g.Sum(x => x.Grandtotal)
                        })
                        .OrderBy(x => x.Date)
                        .ToListAsync();

                    dashinfo.ChartforSale = rawData
                        .Select(x => new SalesChart
                        {
                            Date = x.Date,              // keep as DateTime
                            SalesValue = x.SalesValue
                        })
                        .ToList();
                }
                else
                {
                    var rawData = await _db.TransactionHeader
                        .Where(x => x.TransactionDate.Date >= fromDate && x.TransactionDate.Date <= toDate)
                        .GroupBy(x => x.TransactionDate.Month)
                        .Select(g => new
                        {
                            Month = g.Key,
                            SalesValue = g.Sum(x => x.Grandtotal)
                        })
                        .OrderBy(x => x.Month)
                        .ToListAsync();

                    dashinfo.ChartforSale = rawData
                        .Select(x => new SalesChart
                        {
                            Date = new DateTime(fromDate.Year, x.Month, 1), // first day of month
                            SalesValue = x.SalesValue
                        })
                        .ToList();
                }

                //Low Inventory Alert
                dashinfo.LowInventoryAlert = await _db.Items
                    .Where(x => (x.BalanceStocks <= x.ItemThreshold && x.BalanceStocks > 0m) && x.IsActive == true)
                    .OrderBy(x => (double)x.BalanceStocks) // cast to double
                    .Select(x => new LowInventory
                    {
                        ItemName = x.ItemName,
                        CurrentStocks = x.BalanceStocks,
                    })
                    .Take(5)
                    .ToListAsync();

                dashinfo.InventoryPreview = await _db.Items
                    .Where(x => x.IsActive == true)
                    .OrderBy(x => (double)x.BalanceStocks)
                    .Select(x => new ItemInventoryPreview
                    {
                        Itemname = x.ItemName,
                        CurrentStocks = x.BalanceStocks
                    })
                    .Take(10)
                    .ToListAsync();



            }
            catch (Exception ex)
            {

            }

            return dashinfo;
        }
        
    }
}
