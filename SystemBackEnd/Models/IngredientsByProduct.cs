using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class IngredientsByProduct
    {
        [Key]
        public int Row { get; set; }
        public Guid IngredientID { get; set; }
        public string IngredientsCode { get; set; }
        public Guid ProductId { get; set; }
        public Guid ItemId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModified { get; set; }
        public int Quantity { get; set; }
    }
}
