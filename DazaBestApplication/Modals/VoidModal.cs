using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd.EventHandlers;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class VoidModal : Form
    {
        private POSService POSService;
        private InsertVoidHistory insertVoidHistory;

        int currentLength;
        int maxLength = 50;

        public VoidModal()
        {
            InitializeComponent();
        }

        //Add VoidHistory
        private async Task AddVoidHistory()
        {
            try
            {
                POSService = new POSService(new SystemBackEnd.BackEndDBContext());
                insertVoidHistory = new InsertVoidHistory
                {
                    Reason = voiddetailstxt.Text,
                    AccountId = Program.theLoggedInAccount.AccountId
                };
                bool isAdded = await POSService.InsertVoidHistory(insertVoidHistory);
                if (isAdded)
                {
                    await VoidHistoryEventHandler.InvokeEventHandlerNotifier();
                    MessageBox.Show("Transaction successfully voided!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CloseVoidModal();
                }
                else
                {
                    MessageBox.Show("Failed to void the transaction.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Close modal
        private async Task CloseVoidModal()
        {
            this.Close();
            await Task.CompletedTask;
        }
        //Update Textcount of void details
        private void UpdateTextCount()
        {
            currentLength = voiddetailstxt.Text.Length;
            textcount.Text = $"{currentLength}/{maxLength}";
        }




        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            AddVoidHistory();
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            CloseVoidModal();
        }
        private void voiddetailstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentLength >= maxLength)
            {
                e.Handled = true;
            }
        }

        private void voiddetailstxt_TextChanged(object sender, EventArgs e)
        {
            UpdateTextCount();
        }

        private void VoidModal_Load(object sender, EventArgs e)
        {
            UpdateTextCount();
        }
    }
}
