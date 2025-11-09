using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustItemModalViewModel
    {
        public string Action { get; set; }
        public Guid? EditPurchaseItemHeaderId { get; set; }
        public ViewAdjustItem? ForViewOnly { get; set; }
        public string OperatedBy { get; set; }
    }
}
