using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class PurcahseItemDisplay
    {
        public Guid ItemID { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal? Unitprice { get; set; }
        public decimal? GrandTotal { get; set; }
    }
}
