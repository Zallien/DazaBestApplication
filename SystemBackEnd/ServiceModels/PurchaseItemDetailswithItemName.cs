using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class PurchaseItemDetailswithItemName
    {
        public Guid Purchaseheaderid { get; set; }
        public Guid Purchasedetailsid { get; set; }
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Priceperunit { get; set; }
    }
}
