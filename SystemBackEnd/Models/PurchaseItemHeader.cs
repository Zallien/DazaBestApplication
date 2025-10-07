using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class PurchaseItemHeader
    {
        [Key]
        public int Row { get; set; }
        public Guid Purchaseheaderid { get; set; }
        public string? Purchasenumber { get; set; }
        public DateTime DateCreated { get; set; }
        public Guid Addedby { get; set; }
        public DateTime Dateverified { get; set; }
        public Guid Verifiedby { get; set; }
        public bool Isverified { get; set; }
        public decimal Grandtotal { get; set; }
    }
}
