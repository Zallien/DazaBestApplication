using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class POSTransactionVoidHistory
    {
        [Key]
        public int Row { get; set; }
        public Guid TransactionVoidHistoryId { get; set; }
        public Guid AccountId { get; set; }
        public string TransactionVoidHistoryNumber { get; set; }
        public string TransactionHistoryDetails { get; set; }
        public DateTime TransactionHistoryDate { get; set; }
    }
}
