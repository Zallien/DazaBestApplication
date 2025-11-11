using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DazaBestApplication.Models_and_Helpers
{
    public class SmoothForm : Form
    {
        public SmoothForm()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);

            this.UpdateStyles();
        }
    }

}
