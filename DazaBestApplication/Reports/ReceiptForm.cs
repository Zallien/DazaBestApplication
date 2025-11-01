using AspNetCore.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.ServiceModels;

namespace DazaBestApplication.Reports
{
    public partial class ReceiptForm : Form
    {
        private RecieptData RecieptData = new RecieptData();

        public ReceiptForm(RecieptData therecieptdata)
        {
            InitializeComponent();
            RecieptData = therecieptdata;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            
        }

        private async Task GetRecieptInformation()
        {

        }
    }
}
