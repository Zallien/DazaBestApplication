using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;

namespace SystemBackEnd.ServiceModels
{
    public class ViewAdjustItem
    {
        public ItemAdjustmentHeader AdjustItemHeader { get; set; }
        public List<AdjustItemDetailswithItemName> AdjustItemDetailswithName { get; set; }
    }
}
