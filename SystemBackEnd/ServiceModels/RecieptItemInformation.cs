using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class RecieptItemInformation
    {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemTotal { get; set; }
    }
}
