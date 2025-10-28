using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustItemDetailswithItemName
    {
        public Guid ReferenceDetailsId { get; set; }
        public Guid ReferenceHeaderId { get; set; }
        public Guid ItemId { get; set; }
        public string? Reason { get; set; }
        public decimal RemovedQuantity { get; set; }
        public string ItemName { get; set; }
    }
}
