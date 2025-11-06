using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Models;
using SystemBackEnd.Migrations;
using Microsoft.EntityFrameworkCore;

namespace SystemBackEnd.Services
{
    public class SaleReportServices
    {
        private BackEndDBContext _db;
        public SaleReportServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }


        //Get SaleReportHeader
        public async Task<List<SaleReportDetails>> GetSaleReportDetails(RecordsFilterSearch salefilter)
        {
            List<SaleReportDetails> theHeaderList = new List<SaleReportDetails>();
            try
            {
                theHeaderList = await ( from a in _db.TransactionHeader
                                join b in _db.Accounts on a.TransactionBy equals b.AccountId
                                join c in _db.TransactionDetails on a.TransactionHeaderId equals c.TransactionHeaderId
                                join d in _db.Products on c.ProductId equals d.ProductID
                                where (!salefilter.FromDate.HasValue || a.TransactionDate >= salefilter.FromDate.Value)
                                   && (!salefilter.ToDate.HasValue || a.TransactionDate <= salefilter.ToDate.Value)
                                   && (string.IsNullOrEmpty(salefilter.SearchValue) || a.TransactionNumber.Contains(salefilter.SearchValue))
                                orderby a.Row descending
                                select new SystemBackEnd.ServiceModels.SaleReportDetails
                                {
                                    TransactionDetailsId = a.TransactionHeaderId,
                                    TransactionNumber = a.TransactionNumber,
                                    Date = a.TransactionDate,
                                    CashierName = b.Fullname,
                                    ProductName = d.ProductName,
                                    Quantity = c.Quantity,
                                })
                                .Skip((salefilter.PageNumber - 1) * salefilter.ItemperPage)
                                .Take(salefilter.ItemperPage)
                                .ToListAsync();

                //where(!salefilter.FromDate.HasValue || a.TransactionDate >= salefilter.FromDate.Value)
                //                   && (!salefilter.ToDate.HasValue || a.TransactionDate <= salefilter.ToDate.Value)
                //                   && (string.IsNullOrEmpty(salefilter.SearchValue) || a.TransactionNumber.Contains(salefilter.SearchValue))
            }
            catch (Exception e)
            {
                
            }
            return theHeaderList;

        }
        //Get SaleReportDetails For Print
        public async Task<List<SaleReportDetailsforPrint>> GetSaleReportforPrinting(RecordsFilterSearch salefilter)
        {
            List<SaleReportDetailsforPrint> saleReportDetailsforPrints = new List<SaleReportDetailsforPrint>();

            saleReportDetailsforPrints = await (from a in _db.TransactionHeader
                                                join b in _db.Accounts on a.TransactionBy equals b.AccountId
                                                join c in _db.TransactionDetails on a.TransactionHeaderId equals c.TransactionHeaderId
                                                join d in _db.Products on c.ProductId equals d.ProductID
                                                where (!salefilter.FromDate.HasValue || a.TransactionDate >= salefilter.FromDate.Value)
                                                   && (!salefilter.ToDate.HasValue || a.TransactionDate <= salefilter.ToDate.Value)
                                                   && (string.IsNullOrEmpty(salefilter.SearchValue) || a.TransactionNumber.Contains(salefilter.SearchValue))
                                                orderby a.Row descending
                                                select new SystemBackEnd.ServiceModels.SaleReportDetailsforPrint()
                                                {
                                                    TransactionDetailsId = a.TransactionHeaderId,
                                                    TransactionNumber = a.TransactionNumber,
                                                    Date = a.TransactionDate,
                                                    CashierName = b.Fullname,
                                                    ProductName = d.ProductName,
                                                    Quantity = c.Quantity,
                                                    Price = d.Price,
                                                    Total = c.Quantity * d.Price
                                                })
                                                .ToListAsync();

            return saleReportDetailsforPrints;
        }

    }
}
