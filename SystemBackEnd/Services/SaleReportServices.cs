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
        public async Task<List<SaleReportHeader>> GetSaleReportHeaders(SaleRecordFilterSearch salefilter)
        {
            List<SaleReportHeader> theHeaderList = new List<SaleReportHeader>();

            try
            {
                theHeaderList = await ( from a in _db.TransactionHeader
                                join b in _db.Accounts on a.TransactionBy equals b.AccountId
                                where (!salefilter.FromDate.HasValue || a.TransactionDate >= salefilter.FromDate.Value)
                                   && (!salefilter.ToDate.HasValue || a.TransactionDate <= salefilter.ToDate.Value)
                                   && (string.IsNullOrEmpty(salefilter.SearchValue) || a.TransactionNumber.Contains(salefilter.SearchValue))
                                orderby a.Row descending
                                select new SystemBackEnd.ServiceModels.SaleReportHeader
                                {
                                    TransactionDate = a.TransactionDate,
                                    TransactionHeaderId = a.TransactionHeaderId,
                                    Total = a.Grandtotal,
                                    Cashier = b.Fullname,
                                    TransactionNumber = a.TransactionNumber
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
    }
}
