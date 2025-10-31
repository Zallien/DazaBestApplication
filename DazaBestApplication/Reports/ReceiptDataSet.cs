using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DazaBestApplication.Reports
{
    public class ReceiptDataSet
    {
        public string ORnumber { get; set; }
        public string Date { get; set; }
        public string Cashier { get; set; }
        public string itemName { get; set; }
        public string itemPrice { get; set; }
        public string itemQty { get; set; }
        public string itemTotal { get; set; }
        public string Total { get; set; }
    }
}
