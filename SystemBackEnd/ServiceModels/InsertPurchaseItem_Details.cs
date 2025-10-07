using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertPurchaseItem_Details
    {
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Unitprice { get; set; }
    }
}
