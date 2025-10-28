using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustmentItemFullInformation
    {
        //AdjustItem Header
        public Guid OperatedBy { get; set; }

        //AdjustItem Details
        public List<AdjustItemDetailsInformations> AllAdjustments { get; set; }
    }

    public class AdjustItemDetailsInformations
    {
        public Guid ItemId { get; set; }
        public string Reason { get; set; }
        public decimal ItemQuantity { get; set; }

    }
}
