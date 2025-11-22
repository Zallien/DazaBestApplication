using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SystemBackEnd.Models
{
    public class BusinessType
    {
        [Key]
        public int Row { get; set; }
        public Guid BusinessId { get; set; }
        public string BusinessName { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public Guid AddedBy { get; set; }

    }
}
