using DazaBestApplication.Modals;
using DazaBestApplication.Properties;
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
    public partial class ItemInventory : Form
    {
        private Form Mainform;
        List<Panel> AllPanelBtns;

        public ItemInventory(Form _MainForm)
        {
            InitializeComponent();
            if (_MainForm.Name == "MainPage")
            {
                Mainform = _MainForm;
            }
        }

        //ShowAddItemModal
        private void ShowAddItemModal()
        {
            Form ModalBackgorund = new();
            using (AddItemModal modalcontent = new())
            {
                var mainBounds = Mainform.Bounds;

                ModalBackgorund.StartPosition = FormStartPosition.Manual;
                ModalBackgorund.FormBorderStyle = FormBorderStyle.None;
                ModalBackgorund.Opacity = .60d;
                ModalBackgorund.BackColor = Color.Black;
                ModalBackgorund.Bounds = mainBounds;
                ModalBackgorund.Size = Mainform.Size;
                ModalBackgorund.Location = Mainform.Location;
                ModalBackgorund.ShowInTaskbar = false;
                ModalBackgorund.Show(Mainform);


                modalcontent.Owner = ModalBackgorund;
                modalcontent.StartPosition = FormStartPosition.CenterParent;
                modalcontent.ShowDialog();
                ModalBackgorund.Dispose();
            }
        }

        //Set Hovers for Panel Buttons
        private void SetHoversforPanels(Panel panelBtns)
        {
            panelBtns.MouseEnter -= PanelButtons_MouseEnter;
            panelBtns.MouseLeave -= PanelButtons_MouseLeave;
            panelBtns.MouseEnter += PanelButtons_MouseEnter;
            panelBtns.MouseLeave += PanelButtons_MouseLeave;
            foreach (Control child in panelBtns.Controls)
            {
                child.MouseEnter -= PanelButtons_MouseEnter;
                child.MouseLeave -= PanelButtons_MouseLeave;
                child.MouseEnter += PanelButtons_MouseEnter;
                child.MouseLeave += PanelButtons_MouseLeave;
            }
        }
        private void PanelButtons_MouseEnter(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Panel panel = c as Panel ?? c.Parent as Panel;
            if (panel == null) return;

            if (panel.Name == "DelBtn")
            {
                panel.BackColor = Color.Red;
                panel.ForeColor = Color.White;
                foreach (Control item in panel.Controls)
                {
                    if (item is PictureBox picbox)
                    {
                        picbox.Image = Properties.Resources.whitedelbtn;
                    }
                }
            }
            else if(panel.Name == "AddItemBtn")
            {
                panel.BackColor = Color.FromArgb(249, 168, 37);
            }
        }
        private void PanelButtons_MouseLeave(object sender, EventArgs e)
        {
            Control c = sender as Control;
            Panel panel = c as Panel ?? c.Parent as Panel;
            if (panel == null) return;

            // If the mouse is still inside the panel, ignore the leave.
            Point pt = panel.PointToClient(Cursor.Position);
            if (panel.ClientRectangle.Contains(pt)) return;

            if (panel.Name == "DelBtn")
            {
                panel.BackColor = Color.White;
                panel.ForeColor = Color.Black;
                foreach (Control item in panel.Controls)
                {
                    if (item is PictureBox picbox)
                    {
                        picbox.Image = Properties.Resources.delete16px;
                    }
                }
            }
            else if (panel.Name == "AddItemBtn")
            {
                panel.BackColor = Color.FromArgb(251, 192, 45);
            }

        }

        //Main Load
        private void ItemInventory_Load(object sender, EventArgs e)
        {
            //PanelBtns
            AllPanelBtns = [
                    AddItemBtn,
                    DelBtn
            ];
            foreach (Panel item in AllPanelBtns)
            {
                SetHoversforPanels(item);
            }

        }

        //Buttons Click Events
        private void AdddItem(object sender, EventArgs e)
        {
            ShowAddItemModal();
        }
    }
}
