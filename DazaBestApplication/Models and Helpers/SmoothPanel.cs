using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DazaBestApplication.Models_and_Helpers
{
    public class SmoothPanel : Panel
    {
        public SmoothPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);

            this.DoubleBuffered = true;
            this.UpdateStyles();
        }
    }
}
