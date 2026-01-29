using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class Items
    {
        [Key]
        public int Row { get; set; }
        public string ItemName { get; set; }
        public Guid ItemID { get; set; }
        public string ItemCode { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal BalanceStocks { get; set; }
        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
        public byte[]? ItemImage { get; set; }
        public decimal ItemThreshold { get; set; }
    }
}
