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
    public class AdjustItemServices
    {
        public BackEndDBContext _db;

        public AdjustItemServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Insert New Adjustment Informations
        public async Task<bool> InsertNewItemAdjustmentInformation(AdjustmentItemFullInformation _fullinfo)
        {
            bool isAdded = false;
            try
            {
                Guid HeaderId = Guid.NewGuid();
                //Header
                ItemAdjustmentHeader itemAdjustmentHeader = new ItemAdjustmentHeader()
                {
                    ReferenceHeaderId = HeaderId,
                    DateOperated = DateTime.Now,
                    OperatedBy = _fullinfo.OperatedBy,
                    ReferenceNumber = ""
                };
                await _db.AddAsync(itemAdjustmentHeader);

                //Details
                foreach (var item in _fullinfo.AllAdjustments)
                {
                    ItemAdjustmentDetails details = new ItemAdjustmentDetails()
                    {
                        ReferenceHeaderId = HeaderId,
                        ReferenceDetailsId = Guid.NewGuid(),
                        ItemId = item.ItemId,
                        RemovedQuantity = item.ItemQuantity,
                        Reason = item.Reason,
                    };
                    await _db.AddAsync(details);
                }
                await _db.SaveChangesAsync();
                //Add ReferenceNumber
                ItemAdjustmentHeader theheader = await _db.ItemAdjustmentHeader.FirstOrDefaultAsync(x => x.ReferenceHeaderId ==  HeaderId);
                if (theheader != null && theheader.ReferenceNumber == "")
                {
                    int countToday = await _db.ItemAdjustmentHeader
                        .CountAsync(x => x.DateOperated.Date == DateTime.Today);
                    string referenceNumber = $"ADJ-{DateTime.Now:yyyyMMdd}-{(countToday + 1):D4}";
                    theheader.ReferenceNumber = referenceNumber;
                    _db.Update(theheader);
                    await _db.SaveChangesAsync();
                    isAdded = true;
                }
            }
            catch (Exception e)
            {

                throw;
            }
            return isAdded; 
        }
        //Get Header List
        public async Task<List<AdjustItemHeaderwithOperatedName>> GetAdjustItemHeader(SearchItem searchvalue)
        {
            List<AdjustItemHeaderwithOperatedName> _thelist = new();
            try
            {
                //TO BE FIX WHEN ACCOUNT IS FIXED
                _thelist = await ( from a in _db.ItemAdjustmentHeader
                                   //join b in _db.Accounts
                                   //on a.OperatedBy equals b.AccountId
                                   orderby a.DateOperated descending
                                   select new AdjustItemHeaderwithOperatedName
                                   {
                                       DateCreated = a.DateOperated,
                                       OperatedByName = "No Account Yet",
                                       ReferenceHeaderId = a.ReferenceHeaderId,
                                       ReferenceNumber = a.ReferenceNumber
                                   }).Skip((searchvalue.PageNumber - 1) * searchvalue.ItemperPage)
                                   .Take(searchvalue.ItemperPage)
                                   .ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return _thelist;
        }
    }
}
