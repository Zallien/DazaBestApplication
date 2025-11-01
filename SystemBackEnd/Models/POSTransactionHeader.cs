using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class POSTransactionHeader
    {
        [Key]
        public int Row { get; set; }
        public Guid TransactionHeaderId { get; set; }
        public string TransactionNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid TransactionBy { get; set; }
        public decimal Grandtotal { get; set; }
    }
}
