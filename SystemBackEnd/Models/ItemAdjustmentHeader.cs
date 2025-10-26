using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class ItemAdjustmentHeader
    {

        [Key]
        public int Row { get; set; }
        public Guid ReferenceHeaderId { get; set; }
        public string? ReferenceNumber { get; set; }
        public DateTime DateOperated { get; set; }
        public Guid OperatedBy { get; set; }

    }
}
