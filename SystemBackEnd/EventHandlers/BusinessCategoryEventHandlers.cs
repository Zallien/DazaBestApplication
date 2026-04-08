using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public class BusinessCategoryEventHandlers
    {
        //Event that need to notify when Business Category changes Add, Update, Delete
        public static event Func<Task>? BusinessCategoryNotifier;

        public static async Task InvokeBusinessCategoryNotifier()
        {
            if (BusinessCategoryNotifier != null)
            {
                await BusinessCategoryNotifier.Invoke();
            }
        }
    }
}
