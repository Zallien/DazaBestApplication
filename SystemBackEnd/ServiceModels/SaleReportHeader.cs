using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class SaleReportHeader
    {
        public Guid TransactionHeaderId { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Cashier { get; set; }
        public decimal Total { get; set; }
    }
}
