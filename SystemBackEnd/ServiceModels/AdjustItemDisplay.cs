using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustItemDisplay
    {
        public Guid ItemID { get; set; }
        public string? ItemName { get; set; }
        public int Quantity { get; set; }
        public string? Reason { get; set; }
    }
}
