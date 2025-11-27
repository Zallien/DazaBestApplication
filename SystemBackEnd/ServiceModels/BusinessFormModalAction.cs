using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class BusinessFormModalAction
    {
        public string Action { get; set; }
        public string? BusinessName { get; set; }
        public Guid? BusinessTypeId { get; set; }
    }
}
