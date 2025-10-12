using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;

namespace SystemBackEnd.ServiceModels
{
    public class ViewPurchaseItem
    {
        public PurchaseItemHeader _PurcahseItemHeader { get; set; }
        public List<PurchaseItemDetailswithItemName> _PurchaseItemDetails { get; set; }

    }
}
