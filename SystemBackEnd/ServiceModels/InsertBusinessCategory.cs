using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertBusinessCategory
    {
        public string BusinessName { get; set; }
        public Guid AddedBy { get; set; }
    }
}
