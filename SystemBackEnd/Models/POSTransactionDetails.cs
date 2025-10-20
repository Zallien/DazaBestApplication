using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class POSTransactionDetails
    {
        [Key]
        public int Row { get; set; }
        public Guid TransactionHeaderId { get; set; }
        public Guid TransactionDetailsId { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
