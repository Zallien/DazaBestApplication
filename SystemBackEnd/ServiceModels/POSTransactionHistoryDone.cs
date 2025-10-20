using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class POSTransactionHistoryDone
    {
        public string? TransactionHistoryTitle { get; set; }
        public string? TransactionHistoryDetails { get; set; }
        public DateTime TransactionHistoryDate { get; set; }
    }
}
