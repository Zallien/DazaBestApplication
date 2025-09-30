using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class SearchItem
    {
        public string? SearchValue { get; set; }
        public int PageNumber { get; set; }
        public int ItemperPage { get; set; }
    }
}
