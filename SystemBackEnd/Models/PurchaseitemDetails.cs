using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class PurchaseitemDetails
    {
        [Key]
        public int Row { get; set; }
        public Guid Purchaseheaderid { get; set; }
        public Guid Purchasedetailsid { get; set; }
        public Guid ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal Priceperunit { get; set; }
    }
}
