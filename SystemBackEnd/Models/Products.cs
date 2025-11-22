using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class Products
    {
        [Key]
        public int Row { get; set; }
        public Guid ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateCreated { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public byte[]? ProductImage { get; set; }
        public bool IsAvailable { get; set; }
        public string Category { get; set; }
        public Guid BusinessTyoeId { get; set; }

    }
}
