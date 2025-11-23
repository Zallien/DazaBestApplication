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
    public partial class BusinessModalForm : Form
    {
        private Form mainForm;


        public BusinessModalForm(Form mainform)
        {
            InitializeComponent();
            mainForm = mainform;
        }
    }
}
