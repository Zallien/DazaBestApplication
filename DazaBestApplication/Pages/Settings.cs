using DazaBestApplication.Models;
using DazaBestApplication.Models_and_Helpers;
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
    public partial class Settings : Form
    {

        private Form MainForm;
        private ConfigurationModel ConfigurationModel;
        private bool allowEdit = true;

        public Settings(Form _mainform)
        {
            InitializeComponent();
            MainForm = _mainform;
        }

        //Enter Focus Event Handler
        private async void EnterFocusTextBox(object sender, EventArgs e)
        {
            allowEdit = true;
        }

        //Leave Focus Event Handler
        private async void LeaveFocusTextbox(object sender, EventArgs e)
        {
            if (allowEdit)
            {
                await LeaveOrEnterTextbox(sender);
            }
            
        }
        //Enter KeyPress
        private async void EnterKeypressonTextbox(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // optional: prevent the beep sound
                await LeaveOrEnterTextbox(sender);
            }
        }

        //Leave or Enter keypress
        private async Task LeaveOrEnterTextbox(object sender)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Tag.ToString() != null)
            {
                switch (textBox.Tag?.ToString())
                {
                    case "GeneralSettings_BussinessName":
                        ConfigHelper.UpdateConfig(config =>
                        {
                            config.GeneralSettings.BusinessName = textBox.Text;
                        });
                        MessageBox.Show("Business Name updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "GeneralSettings_Contactinfo":
                        ConfigHelper.UpdateConfig(config =>
                        {
                            config.GeneralSettings.ContactInfo = textBox.Text;
                        });
                        MessageBox.Show("Contact Info updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "GeneralSettings_Headermessage":
                        ConfigHelper.UpdateConfig(config =>
                        {
                            config.GeneralSettings.HeaderMessage = textBox.Text;
                        });
                        MessageBox.Show("Header Message updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                await LoadConfig();
                ///allowEdit = false;
            }
        }

        //Main Load
        private async void Settings_Load(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>
            {
                BusinessName,
                ContactInfo,
                HeaderMessage
            };
            foreach (var textBox in textBoxes)
            {
                //textBox.Leave += LeaveFocusTextbox;
                textBox.KeyPress += EnterKeypressonTextbox;
                textBox.Enter += EnterFocusTextBox;
            }
            await LoadConfig();
        }

        //LoadConfigurationModel
        private async Task LoadConfig()
        {
            ConfigurationModel = ConfigHelper.LoadConfig();
            await PopulateTextboxes();
        }

        //Populate Texbos
        private async Task PopulateTextboxes()
        {
            BusinessName.Text = ConfigurationModel.GeneralSettings.BusinessName;
            HeaderMessage.Text = ConfigurationModel.GeneralSettings.HeaderMessage;
            ContactInfo.Text = ConfigurationModel.GeneralSettings.ContactInfo;
        }
    }
}
