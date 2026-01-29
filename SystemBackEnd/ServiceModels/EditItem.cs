using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class EditItem
    {
        public Guid ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemThreshold { get; set; }
        public byte[]? ItemImage { get; set; }
    }
}
