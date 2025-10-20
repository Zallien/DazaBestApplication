using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    //to be removed later
    public class POSPaymentprocess
    {
        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }
        public decimal? PaymentAmount { get; set; }
        public decimal? PaymentChange { get; set; }
    }
}
