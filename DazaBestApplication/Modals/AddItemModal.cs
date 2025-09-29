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
    public partial class AddItemModal : Form
    {
        private System.Windows.Forms.Timer fadeTimer;
        private ItemServices itemservices = new ItemServices();

        public AddItemModal()
        {
            InitializeComponent();
        }

        //Main Load
        private async void AddItemModal_Load(object sender, EventArgs e)
        {
            FadeIn();
            ItemServices itemservices = new ItemServices();
            await itemservices.GetAllItems();
        }

        //FadeIn Animation
        private void FadeIn()
        {
            this.Opacity = 0;

            fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 30;
            fadeTimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    fadeTimer.Stop();
                    fadeTimer.Dispose();
                }
            };
            fadeTimer.Start();
        }

        //Add Item
        private async Task Additem()
        {
            string ItemName = ItemNametxt.Text.Trim();
            decimal ItemPrice = decimal.Parse(ItemPricetxt.Text.Trim());
            DateTime DateCreated = DateTime.Now;
            var newitem = new InsertItem()
            {
                ItemName = ItemName,
                ItemPrice = ItemPrice,
                DateCreated = DateCreated
            };

            bool IsItemAdded = await itemservices.AddItem(newitem);
            if (IsItemAdded)
            {
                await ItemEventHandlers.InvokeItemChanged();
                MessageBox.Show("Item Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClosethisModal();
            }
            else
            {
                MessageBox.Show("Failed to Add Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Close Modal
        private void ClosethisModal()
        {
            ItemNametxt.Text = "";
            ItemPricetxt.Text = "";
            this.Close();
            this.DialogResult = DialogResult.OK;
        }


        //Button Click Events
        private async void AddItemButton_Click(object sender, EventArgs e)
        {
            await Additem();
        }

        private void CloseModal_Click(object sender, EventArgs e)
        {
            ClosethisModal();
        }
    }
}
