using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertPurchaseItem
    {
        //For Header
        public Guid Addedby { get; set; }

        //For Details
        public List<InsertPurchaseItem_Details>? PurchaseItemDetails { get; set; }
    }
}
