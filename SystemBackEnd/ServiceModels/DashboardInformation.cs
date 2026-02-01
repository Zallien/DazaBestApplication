using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class DashboardInformation
    {
        public decimal Qouta { get; set; }
        public decimal Revenue { get; set; }
        public int OrdersCount { get; set; }
        public decimal TotalSale { get; set; }
        public int ItemsCount { get; set; }
        public int ProductsCount { get; set; }
        public int OutofStockCount { get; set; }
        public int CriticalItems { get; set; }
        public int OverstockItems { get; set; }
        public List<DashboardItems> TopSellingItems { get; set; }
        public List<DashboardItems> LeastSellingItems { get; set; }
        public List<DashboardItems> ForChart { get; set; }
        public List<SalesChart> ChartforSale { get; set; }
        public List<LowInventory> LowInventoryAlert { get; set; }
        public List<ItemInventoryPreview> InventoryPreview { get; set; }
    }

    public class DashboardItems
    {
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProducsSold { get; set; }
    }

    public class SalesChart
    {
        public DateTime Date { get; set; }
        public decimal SalesValue { get; set; }
    }

    public class LowInventory
    {
        public string ItemName { get; set; }
        public decimal CurrentStocks { get; set; }
    }

    public class ItemInventoryPreview
    {
        public string Itemname { get; set; }
        public decimal CurrentStocks { get; set; }
        public string UnitMeasurement { get; set; }
    }
}
