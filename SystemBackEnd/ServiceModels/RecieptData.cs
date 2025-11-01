using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class RecieptData
    {
        public string ORnumber { get; set; }
        public DateTime Date { get; set; }
        public string Cashier { get; set; }
        public List<RecieptItemInformation> AllItemsReciepts { get; set; }
        public decimal Total { get; set; }
    }
}
