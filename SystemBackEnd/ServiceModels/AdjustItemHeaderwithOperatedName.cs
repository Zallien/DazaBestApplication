using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AdjustItemHeaderwithOperatedName
    {
        public Guid ReferenceHeaderId { get; set; }
        public string ReferenceNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public string OperatedByName { get; set; }
    }
}
