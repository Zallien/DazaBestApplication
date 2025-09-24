using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DazaBestApplication.Modals
{
    public partial class AddItemModal : Form
    {
        private System.Windows.Forms.Timer fadeTimer;

        public AddItemModal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void AddItemModal_Load(object sender, EventArgs e)
        {
            FadeIn();
        }

        //FadeIn Animation
        private void FadeIn()
        {
            this.Opacity = 0;

            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 30;
            fadeTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }
            };
            fadeTimer.Start();
        }
    }
}
