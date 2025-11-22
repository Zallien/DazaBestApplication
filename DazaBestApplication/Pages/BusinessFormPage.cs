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
    public partial class BusinessFormPage : Form
    {

        private Form mainForm;

        public BusinessFormPage(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

        }
    }
}
