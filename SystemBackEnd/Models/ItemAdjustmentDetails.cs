using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class ItemAdjustmentDetails
    {
        [Key]
        public int Row { get; set; }
        public Guid ReferenceDetailsId { get; set; }
        public Guid ReferenceHeaderId { get; set; }
        public Guid ItemId { get; set; }
        public string? Reason { get; set; }
        public int RemovedQuantity { get; set; }
    }
}
