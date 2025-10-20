using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class POSService
    {
        private BackEndDBContext _db;
        public POSService(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get All Available Products
        public async Task<List<Products>> GetAllAvailableProducts()
        {
            List<Products> products = new();
            try
            {
                products = await _db.Products.Where(x => x.IsActive == true && x.IsAvailable == true).ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }


        //Transaction Processing --Done Transaction--
        public async Task<bool> ProcessPOSTransaction(POSTransactionDone transactionprocess)
        {
            bool isTransactionSuccess = false;

            try
            {
                Guid trasactionheaderid = Guid.NewGuid();
                //Transaction Header
                POSTransactionHeader transactionHeader = new()
                {
                    TransactionHeaderId = trasactionheaderid,
                    TransactionBy = transactionprocess.TransactionBy,
                    Grandtotal = transactionprocess.Grandtotal,
                    TransactionDate = DateTime.Now
                };
                await _db.AddAsync(transactionHeader);

                //Transaction Details
                foreach (var item in transactionprocess.TransactionDetails)
                {
                    POSTransactionDetails transactionDetails = new()
                    {
                        TransactionDetailsId = Guid.NewGuid(),
                        TransactionHeaderId = trasactionheaderid,
                        ProductId = item.ProductId,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice
                    };
                    await _db.AddAsync(transactionDetails);
                }

                //Payment Details
                POSPaymentTransaction transactionPayment = new()
                {
                    PaymentTransactionId = Guid.NewGuid(),
                    TransactionHeaderId = trasactionheaderid,
                    Subtotal = transactionprocess.Subtotal,
                    Discount = transactionprocess.Discount,
                    Total = transactionprocess.Total,
                    PaymentAmount = transactionprocess.PaymentAmount,
                    PaymentMethod = transactionprocess.PaymentMethod
                };
                await _db.AddAsync(transactionPayment);

                //Transaction History
                if (transactionprocess.TransactionHistory != null)
                {
                    foreach (var item in transactionprocess.TransactionHistory)
                    {
                        POSTransactionHistory transactionHistory = new()
                        {
                            TransactionHistoryId = Guid.NewGuid(),
                            TransactionHeaderId = trasactionheaderid,
                            TransactionHistoryTitle = item.TransactionHistoryTitle,
                            TransactionHistoryDate = item.TransactionHistoryDate,
                            TransactionHistoryDetails = item.TransactionHistoryDetails
                        };
                        await _db.AddAsync(transactionHistory);
                    }
                }
                await _db.SaveChangesAsync();
                isTransactionSuccess = true;
            }
            catch (Exception e)
            {
                
            }

            return isTransactionSuccess;
        }





    }
}
