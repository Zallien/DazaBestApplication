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
    public class ItemServices
    {
        private BackEndDBContext _db;

        public ItemServices(BackEndDBContext mdb)
        {
            _db = mdb;
        }

        //GetData
        public async Task<List<Items>> GetAllItems()
        {
            List<Items> _theitems = new();
            try
            {
                _theitems = await _db.Items
                                   .Where(x => x.IsActive == true)
                                   .OrderByDescending(x => x.Row).ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _theitems;
        }
        //Get Data By Pagination
        public async Task<List<DisplayItem>> GetAllItemsByPagination(SearchItem item)
        {
            List<DisplayItem> _theitems = new();

            try
            {
                var latestUpdates =
                    from d in _db.PurchaseItemDetails
                    join h in _db.PurcahseItemHeader
                        on d.Purchaseheaderid equals h.Purchaseheaderid
                    group h by d.ItemID into g
                    select new
                    {
                        ItemID = g.Key,
                        LastUpdate = g.Max(x => (DateTime?)x.DateCreated) // 🔥 MAKE NULLABLE
                    };

                _theitems = await (
                    from i in _db.Items
                    join lu in latestUpdates
                        on i.ItemID equals lu.ItemID into gj
                    from sub in gj.DefaultIfEmpty()
                    where i.IsActive
                    orderby i.Row descending
                    select new DisplayItem
                    {
                        ItemID = i.ItemID,
                        ItemName = i.ItemName,
                        ItemCode = i.ItemCode,
                        ItemPrice = i.ItemPrice,
                        BalanceStocks = i.BalanceStocks,
                        DateCreated = i.DateCreated,
                        IsActive = i.IsActive,
                        ItemImage = i.ItemImage,
                        ItemThreshold = i.ItemThreshold,
                        UnitMeasurement = i.UnitMeasurement,

                        // 🔥 SAFE NULL HANDLING
                        LastUpdate = sub.LastUpdate ?? i.DateCreated
                    })
                    .Skip((item.PageNumber - 1) * item.ItemperPage)
                    .Take(item.ItemperPage)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _theitems;
        }
        //Add Item
        public async Task<Boolean> AddItem(InsertItem item)
        {
            try
            {
                Guid uid = Guid.NewGuid();

                Items newinserteditem = new Items()
                {
                    ItemName = item.ItemName,
                    ItemCode = "",
                    ItemID = uid,
                    ItemPrice = item.ItemPrice,
                    BalanceStocks = 0,
                    DateCreated = item.DateCreated,
                    IsActive = true,
                    ItemThreshold = item.ItemThreshold,
                    UnitMeasurement = item.UnitMeasurement,
                };
                await _db.Items.AddAsync(newinserteditem);
                await _db.SaveChangesAsync();
                //Set the item code after getting the row number
                Items _theitem = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == uid);
                _theitem.ItemCode = "ITM-" + _theitem.Row.ToString("D4");
                _db.Items.Update(_theitem);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Toggle isActive or Delete Simulation
        public async Task<Boolean> ToggleIsactiveItem(Guid ItemID)
        {
            try
            {
                //Items theitem = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == ItemID);
                Items _Theitem = await _db.Items.Where(x => x.ItemID == ItemID).FirstOrDefaultAsync();
                if (_Theitem != null)
                {
                    _Theitem.IsActive = !_Theitem.IsActive;
                    _db.Items.Update(_Theitem);
                    await _db.SaveChangesAsync();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        //Update Item
        public async Task<Boolean> UpdateItem(Guid ItemID, InsertItem item)
        {
            try
            {
                Items _Theitem = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == ItemID);
                _Theitem.ItemName = item.ItemName;
                _Theitem.ItemPrice = item.ItemPrice;
                _Theitem.ItemThreshold = item.ItemThreshold;
                _Theitem.UnitMeasurement = item.UnitMeasurement;
                _db.Items.Update(_Theitem);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        //Get Items Count
        public async Task<int> GetItemsCount(SearchItem item)
        {
            int count = 0;
            try
            {
                count = await _db.Items.Where(x => x.IsActive == true &&
                                               (x.ItemName!.ToLower().Contains(item.SearchValue.ToLower()) ||
                                                x.ItemCode!.ToLower().Contains(item.SearchValue.ToLower())))
                                               .CountAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }
        //Search Items with Pagination
        public async Task<List<DisplayItem>> SearchItems(SearchItem item)
        {
            List<DisplayItem> _theitems = new();

            try
            {
                var search = item.SearchValue.ToLower() ?? "";

                var latestUpdates =
                    from d in _db.PurchaseItemDetails
                    join h in _db.PurcahseItemHeader
                        on d.Purchaseheaderid equals h.Purchaseheaderid
                    group h by d.ItemID into g
                    select new
                    {
                        ItemID = g.Key,
                        //MUST BE NULLABLE
                        LastUpdate = g.Max(x => (DateTime?)x.DateCreated)
                    };

                _theitems = await (
                    from i in _db.Items
                    join lu in latestUpdates
                        on i.ItemID equals lu.ItemID into gj
                    from sub in gj.DefaultIfEmpty()
                    where i.IsActive &&
                          (i.ItemName.ToLower()!.Contains(search) ||
                           i.ItemCode.ToLower()!.Contains(search))
                    orderby i.Row descending
                    select new DisplayItem
                    {
                        ItemID = i.ItemID,
                        ItemName = i.ItemName,
                        ItemCode = i.ItemCode,
                        ItemPrice = i.ItemPrice,
                        BalanceStocks = i.BalanceStocks,
                        DateCreated = i.DateCreated,
                        IsActive = i.IsActive,
                        ItemImage = i.ItemImage,
                        ItemThreshold = i.ItemThreshold,
                        UnitMeasurement = i.UnitMeasurement,

                        //SAFE NULL HANDLING
                        LastUpdate = sub.LastUpdate ?? i.DateCreated
                    })
                    .Skip((item.PageNumber - 1) * item.ItemperPage)
                    .Take(item.ItemperPage)
                    .ToListAsync();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return _theitems;
        }
    }
}
