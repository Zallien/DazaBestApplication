using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuPages;

namespace DazaBestApplication.Layout
{
    public partial class Loadingscreen : Form
    {
        private Size clientsize = Program.WorkspaceSize;

        //Logo Animation Properties
        string animationType = "Scale";
        int maxanimationTime = 500; //in milliseconds
        float timestep = 0.02f; //in seconds
        private Size originallogosize;
        private Point originallogolocation;

        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void Loadingscreen_Load(object sender, EventArgs e)
        {
            CenterCOmpanyLogo();
        }
        //Center Piturebox Horizontally
        private void CenterCOmpanyLogo()
        {
            CompanyLogo.Left = (clientsize.Width - CompanyLogo.Width) / 2;
            originallogosize = CompanyLogo.Size;
            originallogolocation = CompanyLogo.Location;
        }

    }
}
