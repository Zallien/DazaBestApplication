using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class SaleReportDetails
    {
        public Guid TransactionDetailsId { get; set; }
        public string TransactionNumber { get; set; }
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public DateTime Date { get; set; }
        public string CashierName { get; set; }
    }
}
