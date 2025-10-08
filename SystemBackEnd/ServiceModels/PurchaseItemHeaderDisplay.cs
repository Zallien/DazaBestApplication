using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class PurchaseItemHeaderDisplay
    {
        public Guid Purchaseheaderid { get; set; }
        public string? Purchasenumber { get; set; }
        public DateTime DateCreated { get; set; }
        public string? AddedbyName { get; set; }
        public bool IsVerified { get; set; }
        public DateTime? Dateverified { get; set; }
        public string? VerifiedbyName { get; set; }
        public decimal Grandtotal { get; set; }
    }
}
