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
    public partial class ItemModalForm : Form
    {
        private System.Windows.Forms.Timer fadeTimer;
        private ItemServices itemservices = new ItemServices();
        private Guid UpdateItemID;
        private string ActionButton;

        public ItemModalForm(ItemModal Item)
        {
            InitializeComponent();
            CheckAction(Item);
        }

        //Check if Add or Edit
        private void CheckAction(ItemModal Item)
        {
            if (Item.Action == "AddItem")
            {
                label1.Text = "Add New Item";
                AddItemButton.Text = "Add Item";
                ActionButton = "AddItem";
            }
            else if (Item.Action == "EditItem")
            {
                label1.Text = "Edit Item";
                AddItemButton.Text = "Save Changes";
                ActionButton = "EditItem";
                if (Item.EditItem != null)
                {
                    UpdateItemID = Item.EditItem.ItemID;
                    ItemNametxt.Text = Item.EditItem.ItemName;
                    ItemPricetxt.Text = Item.EditItem.ItemPrice.ToString();
                }
            }
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

        //Edit Item
        private async Task EditItem()
        {
            string ItemName = ItemNametxt.Text.Trim();
            decimal ItemPrice = decimal.Parse(ItemPricetxt.Text.Trim());
            DateTime DateModified = DateTime.Now;
            var updateditem = new InsertItem()
            {
                ItemName = ItemName,
                ItemPrice = ItemPrice,
            };
            bool IsItemUpdated = await itemservices.UpdateItem(UpdateItemID, updateditem);
            if (IsItemUpdated)
            {
                await ItemEventHandlers.InvokeItemChanged();
                MessageBox.Show("Item Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClosethisModal();
            }
            else
            {
                MessageBox.Show("Failed to Update Item", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (ActionButton == "AddItem")
            {
                await Additem();
            }
            else
            {
                await EditItem();
            }

            
        }
        private void CloseModal_Click(object sender, EventArgs e)
        {
            ClosethisModal();
        }
    }
}
