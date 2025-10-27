using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DazaBestApplication.Pages
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.Maroon;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.Maroon;
            color3.BackColor = Color.White;
            color4.BackColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.Maroon;
            color4.BackColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            color1.BackColor = Color.White;
            color2.BackColor = Color.White;
            color3.BackColor = Color.White;
            color4.BackColor = Color.Maroon;
        }
    }
}
