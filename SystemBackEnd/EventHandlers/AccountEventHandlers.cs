using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class AccountEventHandlers
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? AccountChangeNotifier;

        public static async Task InvokeAccount()
        {
            if (AccountChangeNotifier != null)
            {
                await AccountChangeNotifier.Invoke();
            }
        }
    }
}
