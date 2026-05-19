using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertVoidHistory
    {

        public string Reason { get; set; }
        public Guid AccountId { get; set; }
    }
}
