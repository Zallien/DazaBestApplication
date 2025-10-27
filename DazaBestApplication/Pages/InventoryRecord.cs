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
    public partial class InventoryRecord : Form
    {
        private Form MainForm;
        public InventoryRecord(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }

        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
