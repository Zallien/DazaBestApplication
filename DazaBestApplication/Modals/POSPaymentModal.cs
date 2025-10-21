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
using SystemBackEnd.Services;
using SystemBackEnd.Models;
using SystemBackEnd;
using Bunifu.UI.WinForms;
using SystemBackEnd.EventHandlers;

namespace DazaBestApplication.Modals
{
    public partial class POSPaymentModal : Form
    {
        private POSTransactionDone ProcessTransaction = new POSTransactionDone();
        private decimal AmountRecieved = 0;
        private decimal ChangeAmount = 0;

        public POSPaymentModal(POSTransactionDone _paymentprocess)
        {
            InitializeComponent();
            ProcessTransaction = _paymentprocess;
        }

        
        //Load Event
        private void POSPaymentModal_Load(object sender, EventArgs e)
        {
            Totalvaluetext.Text = ProcessTransaction.Total.ToString("N2");
            PaymentRecievedtextbox.Focus();
            PaymentRecievedtextbox.Text = AmountRecieved.ToString("N2");
        }
        
        //Process Transaction
        private async Task<bool> PayingTransaction()
        {
            bool isPaymentSuccess = false;
            try
            {
                ProcessTransaction.PaymentAmount = AmountRecieved;
                ProcessTransaction.Grandtotal = ProcessTransaction.Total;
                ProcessTransaction.Total = ProcessTransaction.Total;
                ProcessTransaction.PaymentMethod = "CASH";
                ProcessTransaction.Discount = 0;

                POSService posService = new POSService(new BackEndDBContext());
                isPaymentSuccess = await posService.ProcessPOSTransaction(ProcessTransaction);
            }
            catch (Exception e)
            {

            }
            return isPaymentSuccess;

        }
        //Pay Transaction With Validation
        private async Task PayTransaction()
        {
            try
            {
                if (ChangeAmount >= 0)
                {
                    bool PaymentProcessSuccess = await PayingTransaction();
                    if (PaymentProcessSuccess)
                    {
                        await POSEventHandler.InvokePaymentTransactionSuccess();
                        MessageBox.Show("Payment Success", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        this.DialogResult = DialogResult.No;
                    }
                    else
                    {
                        MessageBox.Show("System Error", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Insufficient Payment Amount", "System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {

                throw;
            }
        }
        //Close Modal
        private void CloseModal()
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }
        //Calculate Change Amount
        private async Task CalculateChangeAmount()
        {
            try
            {
                ChangeAmount = AmountRecieved - ProcessTransaction.Total;
                Changelabel.Text = ChangeAmount.ToString("N2");
            }
            catch (Exception e)
            {
                throw;
            }
        }




        //Payment Recieved Key Press Event
        private void PaymentRecievedtextbox_TextChange(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            TextBox textBox = sender as TextBox;
            if (e.KeyChar == '.' && textBox.Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
        //Payment OK Button Click Event
        private void PaymentOkButton_Click(object sender, EventArgs e)
        {
            PayTransaction();
        }
        //Close Button Click Event
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            CloseModal();
        }
        //Payment Recieved Text Change Event
        private void PaymentRecievedtextbox_TextChange(object sender, EventArgs e)
        {
            decimal.TryParse(PaymentRecievedtextbox.Text, out AmountRecieved);
            CalculateChangeAmount();
        }
    }
}
