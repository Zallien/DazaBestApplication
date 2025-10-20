using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class POSTransactionDone
    {
        // Transaction Header
        public Guid TransactionBy { get; set; }
        public decimal Grandtotal { get; set; }

        // Transaction Details
        public List<POSTransactionDetailsDone> TransactionDetails { get; set; } = new List<POSTransactionDetailsDone>();

        // Payment Details
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal PaymentAmount { get; set; }
        public string? PaymentMethod { get; set; }

        // Transaction History
        public List<POSTransactionHistoryDone>? TransactionHistory { get; set; }

    }

    public class POSTransactionDetailsDone
    {
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
