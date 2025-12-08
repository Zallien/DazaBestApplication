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
    public partial class NotificationModal : Form
    {
        private string _message;
        private string _title;

        public NotificationModal(NotificationModel _notificationmodel)
        {
            InitializeComponent();
            _message = _notificationmodel.Details;
            _title = _notificationmodel.Title;
        }

        private void NotificationModal_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = _title;
            detailslabel.Text = _message;
        }

        private async void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            await Task.CompletedTask;
        }
    }
}
