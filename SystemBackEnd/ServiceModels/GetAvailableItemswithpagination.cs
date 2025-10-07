using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class GetAvailableItemswithpagination
    {
        public int Pagenumber { get; set; }
        public int Itemperpage { get; set; }
        public string? Searchvalue { get; set; }
        public List<Guid>? AllSelectedItem { get; set; }
    }
}
