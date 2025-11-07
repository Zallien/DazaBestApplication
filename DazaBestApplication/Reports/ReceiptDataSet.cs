using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using SystemBackEnd.ServiceModels;

namespace DazaBestApplication.Reports
{
    public class ReceiptDataSet
    {
        public string ORnumber { get; set; }
        public string Date { get; set; }
        public string Cashier { get; set; }
        public string Total { get; set; }
    }

    public class RecieptItemDataSet
    {
        public string ItemName { get; set; }
        public int ItemQuantity { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal ItemTotal { get; set; }
    }

    public class SalesPerformanceData
    {
        public string TransactionNo { get; set; }
        public string Date { get; set; }
        public string Seller { get; set; }
        public string ProductName { get; set; }
        public decimal ProductQty { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductTotal { get; set; }

    }

    public class DataforAdjustment
    {
        public string ReferenceNo { get; set; }
        public string Date { get; set; }
        public string itemName { get; set; }
        public decimal Quantity { get; set; }
        public string Reason { get; set; }
    }
}
