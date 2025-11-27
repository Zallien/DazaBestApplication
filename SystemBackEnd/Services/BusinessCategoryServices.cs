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
        //Remove or Deactivate Business Category
        public async Task<bool> RemoveBusinessCategory(Guid Id)
        {
            bool IsSuccessRemoved = false;
            try
            {
                BusinessType businesscategory = await _db.BusinessType.FirstOrDefaultAsync(x => x.BusinessId == Id);
                if (businesscategory != null)
                {
                    businesscategory.IsActive = false;
                    _db.Update(businesscategory);
                    await _db.SaveChangesAsync();
                    IsSuccessRemoved = true;
                }

            }
            catch (Exception ex)
            {

            }
            return IsSuccessRemoved;
        }
        //Edit / Update BusinessType
        public async Task<bool> UpdateBusinessType(UpdateBusinessType businessType)
        {
            bool IsSuccessfullyUpdate = false;
            try
            {
                BusinessType businesstype = await _db.BusinessType.FirstOrDefaultAsync(x => x.BusinessId == businessType.BusinessTypeId);
                if (businesstype != null)
                {
                    businesstype.BusinessName = businessType.BusinessTypeName;
                    _db.Update(businesstype);
                    await _db.SaveChangesAsync();
                    IsSuccessfullyUpdate = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return IsSuccessfullyUpdate;
        }


    }
}
