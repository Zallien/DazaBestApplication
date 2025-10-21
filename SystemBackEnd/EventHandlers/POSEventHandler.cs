using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class POSEventHandler
    {
        //Event that need to notify when item inventory changes Add, Update, Delete
        public static event Func<Task>? PaymentTransactionSuccess;

        public static async Task InvokePaymentTransactionSuccess()
        {
            if (PaymentTransactionSuccess != null)
            {
                await PaymentTransactionSuccess.Invoke();
            }
        }
    }
}
