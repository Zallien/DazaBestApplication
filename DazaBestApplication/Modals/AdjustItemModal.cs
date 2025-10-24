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
    public partial class AdjustItemModal : Form
    {
        public AdjustItemModal()
        {
            InitializeComponent();
        }

        private void AllPickedItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void NumbersOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void letters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AllPickedItems_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            const int NUMBER_COLUMN_INDEX = 2;
            const int LETTER_COLUMN_INDEX = 3;

            if (AllPickedItems.CurrentCell.ColumnIndex == NUMBER_COLUMN_INDEX)
            {
                TextBox textBox = e.Control as TextBox;

                if (textBox != null)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(NumbersOnly_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(NumbersOnly_KeyPress);
                }
                else if (AllPickedItems.CurrentCell.ColumnIndex == LETTER_COLUMN_INDEX)
                {
                    TextBox textBox1 = e.Control as TextBox;
                    if (textBox1 != null)
                    {
                        textBox1.KeyPress -= new KeyPressEventHandler(letters_KeyPress);
                        textBox1.KeyPress += new KeyPressEventHandler(letters_KeyPress);
                    }
                }
            
        }
    }
}
