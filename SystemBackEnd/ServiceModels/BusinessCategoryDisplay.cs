using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class BusinessCategoryDisplay
    {
        public Guid BusinessCategoryId { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
