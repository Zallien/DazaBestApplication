using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemBackEnd.Models;
using SystemBackEnd.ServiceModels;

namespace SystemBackEnd.Services
{
    public class BusinessCategoryServices
    {
        private BackEndDBContext _db;

        public BusinessCategoryServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //Get All Business Category Based on Pagination
        public async Task<List<BusinessCategoryDisplay>> GetBusinessCategories(SearchItem value)
        {
            List<BusinessCategoryDisplay> businessCategoryDisplays = new List<BusinessCategoryDisplay>();
            try
            {
                businessCategoryDisplays = await (from a in _db.BusinessType
                                                  where a.IsActive == true
                                                  orderby a.Row ascending
                                                  select new BusinessCategoryDisplay()
                                                  {
                                                      BusinessCategoryId = a.BusinessId,
                                                      BusinessName = a.BusinessName,
                                                      DateCreated = a.DateCreated,
                                                  })
                                                  .Take(value.ItemperPage)
                                                  .Skip((value.PageNumber - 1) * value.ItemperPage)
                                                  .ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return businessCategoryDisplays;
        }
        //Add Business Category
        public async Task<bool> AddBusinessCategory(InsertBusinessCategory business)
        {
            bool AddedSuccessfully = false;
            try
            {
                BusinessType businesstype = new BusinessType()
                {
                    BusinessId = Guid.NewGuid(),
                    BusinessName = business.BusinessName,
                    DateCreated = DateTime.Now,
                    AddedBy = business.AddedBy,
                    IsActive = true,
                };

                await _db.AddAsync(businesstype);
                await _db.SaveChangesAsync();
                AddedSuccessfully = true;
            }
            catch (Exception ex)
            {
                AddedSuccessfully = false;
                return AddedSuccessfully;
            }
            return AddedSuccessfully;
        }

    }
}
