using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class PurchaseItemEventHandlers
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? PurchaseItemChanged;

        public static async Task InvokePurchaseItemChanged()
        {
            if (PurchaseItemChanged != null)
            {
                await PurchaseItemChanged.Invoke();
            }
        }
    }
}
