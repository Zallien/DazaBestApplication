using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class PosItemFilter
    {
        public string SearchValue { get; set; }
        public string Category { get; set; }
        public string Business { get; set; }
    }
}
