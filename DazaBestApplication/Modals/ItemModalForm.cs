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
using SystemBackEnd;

namespace DazaBestApplication.Modals
{
    public partial class ItemModalForm : Form
    {
        private System.Windows.Forms.Timer _fadetimer;
        private ItemServices itemservices = new ItemServices(new BackEndDBContext());
        private Guid _updateitemid;
        private string _actionbutton;

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
                _actionbutton = "AddItem";
            }
            else if (Item.Action == "EditItem")
            {
                label1.Text = "Edit Item";
                AddItemButton.Text = "Save Changes";
                _actionbutton = "EditItem";
                if (Item.EditItem != null)
                {
                    _updateitemid = Item.EditItem.ItemID;
                    ItemNametxt.Text = Item.EditItem.ItemName;
                    ItemPricetxt.Text = Item.EditItem.ItemPrice.ToString();
                }
            }
        }
        //Main Load
        private async void AddItemModal_Load(object sender, EventArgs e)
        {
            FadeIn();
        }
        //FadeIn Animation
        private void FadeIn()
        {
            this.Opacity = 0;

            _fadetimer = new System.Windows.Forms.Timer();
            _fadetimer.Interval = 30;
            _fadetimer.Tick += (s, args) =>
            {
                if (this.Opacity < 1)
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    _fadetimer.Stop();
                    _fadetimer.Dispose();
                }
            };
            _fadetimer.Start();
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
            itemservices = new ItemServices(new BackEndDBContext());
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
            itemservices = new ItemServices(new BackEndDBContext());
            bool IsItemUpdated = await itemservices.UpdateItem(_updateitemid, updateditem);
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




        //Events
        private async void AddItemButton_Click(object sender, EventArgs e)
        {
            if (_actionbutton == "AddItem")
            {
                if (string.IsNullOrWhiteSpace(ItemNametxt.Text) || string.IsNullOrWhiteSpace(ItemPricetxt.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    await Additem();
                }

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

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            ClosethisModal();
        }

        private void ItemNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void ItemPricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void ItemPricetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
