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

namespace DazaBestApplication.Modals
{
    public partial class DecisionModal : Form
    {
        private DecisionModel _decision;

        public DecisionModal(DecisionModel decision)
        {
            _decision = new DecisionModel();
            _decision = decision;
            InitializeComponent();
        }

        //Yes Answer
        private async void YesButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Yes;
        }

        //No Answer
        private async void NoButton_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.No;
        }

        private void DecisionModal_Load(object sender, EventArgs e)
        {
            TitleLabel.Text = _decision.DecisionTitle;
            QuestionLabel.Text = _decision.DecisionQuestion;
        }
    }
}
