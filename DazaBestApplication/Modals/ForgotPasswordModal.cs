using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemBackEnd;
using SystemBackEnd.ServiceModels;
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class ForgotPasswordModal : Form
    {

        private Form MainForm;
        private SucurityQuestionAnswerModel sucurityQuestionAnswerModel = new SucurityQuestionAnswerModel();
        private Panel overlay;

        public ForgotPasswordModal(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
        }


        //Search Security Question using Username
        private async Task<SucurityQuestionAnswerModel> GetSecurityQuestionwithAccountId()
        {

            try
            {
                using (var context = new BackEndDBContext())
                {
                    LoginServices loginServices = new LoginServices(context);
                    sucurityQuestionAnswerModel = await loginServices.SucurityQuestionAnswerModel(ForgotUsernameTxt.Text);
                    if (sucurityQuestionAnswerModel.SucurityQuestions.Count == 0)
                    {
                        MessageBox.Show("This Account has not provided the Security Question", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }

                }
            }
            catch (Exception ex)
            {

            }

            return sucurityQuestionAnswerModel;


        }
        //Show Security Questions
        private async Task ShowSecurityQuestions()
        {
            try
            {

                var sucurityQuestionAnswerModel = new SucurityQuestionAnswerModel();
                sucurityQuestionAnswerModel = await GetSecurityQuestionwithAccountId();
                if (sucurityQuestionAnswerModel == null)
                {
                    return;
                }
                if (sucurityQuestionAnswerModel.SucurityQuestions.Count > 0)
                {
                    //Display Questions
                    await ShowQuestionPanel();
                    question1.Text = sucurityQuestionAnswerModel.SucurityQuestions[0].Question;
                    question2.Text = sucurityQuestionAnswerModel.SucurityQuestions[1].Question;
                    question3.Text = sucurityQuestionAnswerModel.SucurityQuestions[2].Question;
                }

            }
            catch (Exception ex)
            {

            }
        }
        //Show Question Panel
        private async Task ShowQuestionPanel()
        {
            //Generate a Overlay Panel
            overlay = new Panel();
            overlay.Location = new Point(0, 0);
            overlay.Parent = this;
            overlay.Size = this.Size;
            overlay.BackColor = Color.FromArgb(77, 0, 0, 0);
            overlay.BringToFront();


            Size _allppanelsize = QuestionPanel.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            QuestionPanel.Location = _allproductlocation;
            QuestionPanel.Visible = true;
            QuestionPanel.BringToFront();
        }
        //Validate Answers
        private async Task ValidateAnswers()
        {
            try
            {
                if (sucurityQuestionAnswerModel.SucurityQuestions[0].Answer == answer1.Text &&
                    sucurityQuestionAnswerModel.SucurityQuestions[1].Answer == answer2.Text &&
                    sucurityQuestionAnswerModel.SucurityQuestions[2].Answer == answer3.Text)
                {
                    //Show Reset Password Panel
                    await ShowResetPasswordPanel();
                }
                else
                {
                    MessageBox.Show("Incorrect Answers", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

            }
        }
        //Show Reset Password Panel
        private async Task ShowResetPasswordPanel()
        {
            Size _allppanelsize = ResetPassPanel.Size;
            var _allproductlocation = new Point((this.Width - _allppanelsize.Width) / 2, (this.Height - _allppanelsize.Height) / 2);
            ResetPassPanel.Location = _allproductlocation;
            ResetPassPanel.Visible = true;
            ResetPassPanel.BringToFront();
            QuestionPanel.Visible = false;
        }
        //Change Password
        private async Task ChangePassword()
        {
            try
            {
                if (newpasswordtxt.Text != reenterpasswordtxt.Text)
                {
                    MessageBox.Show("Passwords Not Matched", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var context = new BackEndDBContext())
                {
                    LoginServices loginServices = new LoginServices(context);
                    bool isChanged = await loginServices.ChangePassword(sucurityQuestionAnswerModel.AccountId, newpasswordtxt.Text);
                    if (isChanged)
                    {
                        MessageBox.Show("Password Successfully Changed", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("An Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }



        //Main Load
        private void ForgotPasswordModal_Load(object sender, EventArgs e)
        {
            QuestionPanel.Visible = false;
            ResetPassPanel.Visible = false;
        }


        //Events
        private void btncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (ForgotUsernameTxt.Text == "")
            {
                MessageBox.Show("Username First Dumbass", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            await ShowSecurityQuestions();
        }
        private async void ValidateBtn_Click(object sender, EventArgs e)
        {
            await ValidateAnswers();
        }
        private async void ResetPassBtn_Click(object sender, EventArgs e)
        {
            await ChangePassword();
        }
        private void CancelBtn2_Click(object sender, EventArgs e)
        {
            overlay.Dispose();
            ResetPassPanel.Visible = false;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            overlay.Dispose();
            QuestionPanel.Visible = false;
        }
    }
}
