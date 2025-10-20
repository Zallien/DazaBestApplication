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

namespace DazaBestApplication.Modals
{
    public partial class POSPaymentModal : Form
    {
        private POSTransactionDone ProcessTransaction = new POSTransactionDone();

        public POSPaymentModal(POSTransactionDone _paymentprocess)
        {
            InitializeComponent();
            ProcessTransaction = _paymentprocess;
        }
        //Load Event
        private void POSPaymentModal_Load(object sender, EventArgs e)
        {
            Totalvaluetext.Text = ProcessTransaction.Grandtotal.ToString("N2");
        }
    }
}
