using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.EventHandlers
{
    public static class DecisionHandlers
    {

        public static event Func<bool, Task<bool>>? DecisionMade;
        public static async Task<bool> InvokeDecisionMade(bool Choice)
        {
            if (DecisionMade != null)
            {
                // invoke and return the result
                return await DecisionMade.Invoke(Choice);
            }

            return false;

        }
    }
}
