using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class PurchaseItemModal
    {
        public string Action { get; set; }
        public Guid? EditPurchaseItemHeaderId { get; set; }
        public ViewPurchaseItem? ForViewOnly { get; set; }
        public string Operatedby { get; set; }
    }
}
