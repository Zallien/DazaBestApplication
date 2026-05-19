using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class ItemsReportDetails
    {

        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal BalanceStock { get; set; }
        public decimal Price { get; set; }
        public DateTime DateCreated { get; set; }
        public string ItemCode { get; set; }
        public string UnitMeasurement { get; set; }

    }
}
