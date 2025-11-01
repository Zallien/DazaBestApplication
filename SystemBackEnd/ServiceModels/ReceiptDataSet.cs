using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;

namespace DazaBestApplication.Reports
{
    public class ReceiptDataSet
    {
        public string ORnumber { get; set; }
        public string Date { get; set; }
        public string Cashier { get; set; }
        public List<RecieptItemInformation> AllItemsReciepts { get; set; }
        public string Total { get; set; }
    }
}
