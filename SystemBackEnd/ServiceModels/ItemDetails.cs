using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class ItemDetails
    {
        public string? ItemName { get; set; }
        public decimal? ItemPrice { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
