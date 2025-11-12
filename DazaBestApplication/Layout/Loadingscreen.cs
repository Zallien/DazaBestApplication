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
        private System.Windows.Forms.Timer loadingTimer;
        private int Timerprogress = 0;

        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void Loadingscreen_Load(object sender, EventArgs e)
        {
            SetupTimer();
        }
        private void SetupTimer()
        {
            loadingprogressbar.Value = 0;
            loadingprogressbar.Maximum = 100;
            loadingTimer = new System.Windows.Forms.Timer();
            loadingTimer.Interval = 100;
            loadingTimer.Tick += LoadingtimerTick;
            loadingTimer.Start();

        }
        private void LoadingtimerTick(object sender, EventArgs e)
        {
            Timerprogress++;
            if (Timerprogress >= 100)
            {
                loadingTimer.Stop();
                Timerprogress = 0;
            }
            loadingprogressbar.Value = Timerprogress;
        }

    }
}
