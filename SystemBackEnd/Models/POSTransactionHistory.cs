using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class POSTransactionHistory
    {
        [Key]
        public int Row { get; set; }
        public Guid TransactionHeaderId { get; set; }
        public Guid TransactionHistoryId { get; set; }
        public string? TransactionHistoryTitle { get; set; }
        public string? TransactionHistoryDetails { get; set; }
        public DateTime TransactionHistoryDate { get; set; }
    }
}
