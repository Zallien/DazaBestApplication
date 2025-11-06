using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.ServiceModels;
using SystemBackEnd;
using Microsoft.EntityFrameworkCore;


namespace SystemBackEnd.Services
{
    public class AdjusmentReportServices
    {
        private BackEndDBContext _db;

        public AdjusmentReportServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get AdjustmentDetails for Adjustment Reports
        public async Task<List<AdjustmentReportDetails>> GetAdjustmentDetails(RecordsFilterSearch filtersearch)
        {
            List<AdjustmentReportDetails> adjustmentReportDetails = new List<AdjustmentReportDetails>();
            try
            {
                adjustmentReportDetails = await (from a in _db.ItemAdjustmentHeader
                                                 join b in _db.ItemAdjustmentDetails on a.ReferenceHeaderId equals b.ReferenceHeaderId
                                                 join c in _db.Items on b.ItemId equals c.ItemID
                                                 where (!filtersearch.FromDate.HasValue || a.DateOperated >= filtersearch.FromDate.Value)
                                                       && (!filtersearch.ToDate.HasValue || a.DateOperated <= filtersearch.ToDate.Value)
                                                       && (string.IsNullOrEmpty(filtersearch.SearchValue) || a.ReferenceNumber.Contains(filtersearch.SearchValue))
                                                 select new AdjustmentReportDetails()
                                                 {
                                                     ReferenceNumber = a.ReferenceNumber,
                                                     ReferenceDetailsId = b.ReferenceDetailsId,
                                                     ItemName = c.ItemName,
                                                     Quantity = b.RemovedQuantity,
                                                     Reason = b.Reason
                                                 })
                                                 .Skip((filtersearch.PageNumber - 1) * filtersearch.ItemperPage)
                                                .Take(filtersearch.ItemperPage)
                                                .ToListAsync();
            }
            catch (Exception e)
            {

            }

            return adjustmentReportDetails;
        }

        //Get Adjustment Report Details for Printing
        public async Task<List<AdjustmentReportDetailsforPrint>> GetAdjustmentDetailsForPrinting(RecordsFilterSearch filtersearch)
        {
            List<AdjustmentReportDetailsforPrint> adjustmentReportDetails = new List<AdjustmentReportDetailsforPrint>();
            try
            {
                adjustmentReportDetails = await (from a in _db.ItemAdjustmentHeader
                                                 join b in _db.ItemAdjustmentDetails on a.ReferenceHeaderId equals b.ReferenceHeaderId
                                                 join c in _db.Items on b.ItemId equals c.ItemID
                                                 where (!filtersearch.FromDate.HasValue || a.DateOperated >= filtersearch.FromDate.Value)
                                                       && (!filtersearch.ToDate.HasValue || a.DateOperated <= filtersearch.ToDate.Value)
                                                       && (string.IsNullOrEmpty(filtersearch.SearchValue) || a.ReferenceNumber.Contains(filtersearch.SearchValue))
                                                 select new AdjustmentReportDetailsforPrint()
                                                 {
                                                     ReferenceNumber = a.ReferenceNumber,
                                                     ReferenceDetailsId = b.ReferenceDetailsId,
                                                     ItemName = c.ItemName,
                                                     Quantity = b.RemovedQuantity,
                                                     Reason = b.Reason,
                                                     Date = a.DateOperated
                                                 })
                                                 .Skip((filtersearch.PageNumber - 1) * filtersearch.ItemperPage)
                                                .Take(filtersearch.ItemperPage)
                                                .ToListAsync();
            }
            catch (Exception e)
            {

            }

            return adjustmentReportDetails;
        }

    }
}
