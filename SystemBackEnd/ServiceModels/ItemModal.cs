using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class ItemModal
    {
        public string Action { get; set; }
        public ItemDetails? ItemDetails { get; set; }
    }
}
