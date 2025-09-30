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
        private Dbcontext _db;

        public ItemServices()
        {
            _db = new Dbcontext();
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
        //Add Item
        public async Task<Boolean> AddItem(ItemDetails item)
        {
            try
            {
                Guid uid = Guid.NewGuid();

                Items newinserteditem = new Items()
                {
                    ItemName = item.ItemName,
                    ItemID = uid,
                    ItemPrice = item.ItemPrice,
                    BalanceStocks = 0,
                    DateCreated = item.DateCreated,
                    IsActive = true
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
        public async Task<Boolean> UpdateItem(Guid ItemID, ItemDetails item)
        {
            try
            {
                Items _Theitem = await _db.Items.FirstOrDefaultAsync(x => x.ItemID == ItemID);
                _Theitem.ItemName = item.ItemName;
                _Theitem.ItemPrice = item.ItemPrice;
                _db.Items.Update(_Theitem);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
