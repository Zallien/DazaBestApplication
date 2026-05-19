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
        public async Task<List<Products>> GetAllAvailableProducts(PosItemFilter thefilter)
        {
            List<Products> products = new();
            try
            {
                products = await (from a in _db.Products
                                  where (a.IsAvailable == true && a.IsActive == true)
                                  && (string.IsNullOrEmpty(thefilter.SearchValue) ? true : a.ProductName.ToLower().Contains(thefilter.SearchValue.ToLower()))
                                  && (thefilter.Category == "All" ? true : a.Category == thefilter.Category)
                                  && a.BusinessCategory == thefilter.Business
                                  select a).ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return products;
        }

        //Get Reciept Information
        public async Task<RecieptData> GetRecieptData(Guid transacId, string CashierName)
        {
            RecieptData recieptData = new();
            try
            {
                recieptData.Cashier = CashierName;
                //Transacheader 
                var trasacheader = await _db.TransactionHeader.FirstOrDefaultAsync(x => x.TransactionHeaderId ==  transacId);
                if (trasacheader != null)
                {
                    recieptData.ORnumber = trasacheader.TransactionNumber;
                    recieptData.Date = trasacheader.TransactionDate;
                }

                //TransacDetails
                var transacdetails = await (from a in _db.TransactionDetails
                                            join b in _db.Products
                                            on a.ProductId equals b.ProductID
                                            where a.TransactionHeaderId == transacId
                                            select new RecieptItemInformation()
                                            {
                                                ItemName = b.ProductName,
                                                ItemPrice = a.UnitPrice,
                                                ItemQuantity = a.Quantity,
                                                ItemTotal = a.Quantity * a.UnitPrice
                                            }).ToListAsync();
                if (transacdetails != null)
                {
                    recieptData.AllItemsReciepts = transacdetails;
                    foreach (var item in transacdetails)
                    {
                        recieptData.Total += item.ItemTotal;
                    }
                    return recieptData;
                }
            }
            catch (Exception e)
            {
                

            }

            return recieptData;
        }

        //Transaction Processing --Done Transaction--
        public async Task<Guid> ProcessPOSTransaction(POSTransactionDone transactionprocess)
        {
            Guid TransactionHeaderIdReturned = Guid.Empty;

            try
            {
                Guid trasactionheaderid = Guid.NewGuid();
                TransactionHeaderIdReturned = trasactionheaderid;
                //Transaction Header
                POSTransactionHeader transactionHeader = new()
                {
                    TransactionHeaderId = trasactionheaderid,
                    TransactionBy = transactionprocess.TransactionBy,
                    Grandtotal = transactionprocess.Grandtotal,
                    TransactionDate = DateTime.Now,
                    TransactionNumber = ""
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
                await _db.SaveChangesAsync();
                var theheader = await _db.TransactionHeader.FirstOrDefaultAsync(x => x.TransactionHeaderId == trasactionheaderid);
                var countsperday = _db.TransactionHeader.Where(x => x.TransactionDate.Date == DateTime.Now.Date).Count();
                if (theheader != null)
                {
                    theheader.TransactionNumber = $"{DateTime.Now.ToString("yyMMddHHmmss")} - {(countsperday).ToString("D4")}";
                    _db.Update(theheader);
                    await _db.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                
            }

            return TransactionHeaderIdReturned;
        }

        //Store Void History
        public async Task<bool> InsertVoidHistory(InsertVoidHistory voiddetails)
        {
            bool isSuccess = false;
            try
            {
                Guid newid = Guid.NewGuid();
                POSTransactionVoidHistory storevoid = new()
                {
                    TransactionVoidHistoryId = newid,
                    TransactionHistoryDetails = voiddetails.Reason,
                    TransactionHistoryDate = DateTime.Now,
                    AccountId = voiddetails.AccountId,
                    TransactionVoidHistoryNumber = ""
                };
                await _db.AddAsync(storevoid);
                await _db.SaveChangesAsync();
                storevoid.TransactionVoidHistoryNumber = $"Void{DateTime.Now.ToString("yyMMddHHmmss")}-{storevoid.Row.ToString("D4")}";
                _db.Update(storevoid);
                await _db.SaveChangesAsync();
                isSuccess = true;
            }
            catch (Exception e)
            {
                
            }
            return isSuccess;
        }

        




    }
}
