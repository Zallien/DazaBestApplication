using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertProduct
    {
        public string? ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
