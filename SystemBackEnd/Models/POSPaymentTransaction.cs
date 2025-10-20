using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class POSPaymentTransaction
    {
        [Key]
        public int Row { get; set; }
        public Guid TransactionHeaderId { get; set; }
        public Guid PaymentTransactionId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
