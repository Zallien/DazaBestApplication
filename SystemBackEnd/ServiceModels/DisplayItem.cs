using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class DisplayItem
    {
        public string ItemName { get; set; }
        public Guid ItemID { get; set; }
        public string ItemCode { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal BalanceStocks { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public byte[]? ItemImage { get; set; }
        public decimal ItemThreshold { get; set; }
        public string UnitMeasurement { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
