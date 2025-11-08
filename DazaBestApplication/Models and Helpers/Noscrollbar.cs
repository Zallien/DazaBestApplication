using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DazaBestApplication.Models_and_Helpers
{
    public class Noscrollbar : FlowLayoutPanel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.Style &= ~0x100000; // WS_HSCROLL
                cp.Style &= ~0x200000; // WS_VSCROLL
                return cp;
            }
        }
    }
}
