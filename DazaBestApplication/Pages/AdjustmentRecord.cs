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
    public partial class AdjustmentRecord : Form
    {
        private Form MainForm;
        public AdjustmentRecord(Form mainForm)
        {
            InitializeComponent();

            PrintPanel.Visible = false;
            PrintBtn.MouseEnter += ShowDropdown;
            PrintBtn.MouseLeave += HideDropdown_Check;
            PrintPanel.MouseEnter += ShowDropdown;
            PrintPanel.MouseLeave += HideDropdown_Check;
            foreach (Control ctrl in PrintPanel.Controls)
            {
                ctrl.MouseEnter += ShowDropdown;
                ctrl.MouseLeave += HideDropdown_Check;
                ctrl.Click += (s, e) => { PrintPanel.Visible = false; };
            }

            MainForm = mainForm;
        }
        private void ShowDropdown(object sender, EventArgs e)
        {
            PrintPanel.Visible = true;
        }
        private async void HideDropdown_Check(object sender, EventArgs e)
        {
            await Task.Delay(100);
            if (this.IsDisposed || panel2.IsDisposed || PrintBtn.IsDisposed)
                return;

            if (!PrintBtn.Bounds.Contains(PointToClient(Cursor.Position)) &&
                !PrintPanel.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                PrintPanel.Visible = false;
            }
        }
        private void PrintBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
