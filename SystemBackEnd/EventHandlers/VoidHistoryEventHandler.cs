using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class VoidHistoryEventHandler
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? EventHandlerNotifier;

        public static async Task InvokeEventHandlerNotifier()
        {
            if (EventHandlerNotifier != null)
            {
                await EventHandlerNotifier.Invoke();
            }
        }
    }
}
