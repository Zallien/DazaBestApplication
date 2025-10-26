using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustmentInformations
    {
        public Guid ItemId { get; set; }
        public string ItemName { get; set; }
        public string Reason { get; set; }
        public int ItemQuantity { get; set; }
    }
}
