using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class StockInReportsDetails
    {

        public Guid PurchaseItemDetailsId { get; set; }
        public string PurchaseItemNumber { get; set; }
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public string AddedBy { get; set; }


    }
}
