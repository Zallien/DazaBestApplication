using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class ItemEventHandlers
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? ItemInventoryChanged;

        public static async Task InvokeItemChanged()
        {
            if (ItemInventoryChanged != null)
            {
                await ItemInventoryChanged.Invoke();
            }
        }
    }
}
