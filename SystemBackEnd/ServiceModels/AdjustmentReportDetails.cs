using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustmentReportDetails
    {

        public Guid ReferenceDetailsId { get; set; }
        public string ReferenceNumber { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public string Reason { get; set; }
    }
}
