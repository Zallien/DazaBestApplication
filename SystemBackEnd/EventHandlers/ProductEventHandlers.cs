using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class ProductEventHandlers
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? ProductInventoryChanged;
        public static event Func<Task>? ChangeItemDisplayed;

        public static async Task InvokeProductChanged()
        {
            if (ProductInventoryChanged != null)
            {
                await ProductInventoryChanged.Invoke();
            }
        }
        public static async Task InvokeChangeItemDisplayed()
        {
            if (ChangeItemDisplayed != null)
            {
                await ChangeItemDisplayed.Invoke();
            }
        }
    }
}
