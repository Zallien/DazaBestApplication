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
using SystemBackEnd.Services;

namespace DazaBestApplication.Modals
{
    public partial class SecurityQuestionModal : Form
    {
        private Form Mainform;
        private InsertSecurityQuestion insertSecurityQuestion;
        private SecurityQuestionServices SecurityQuestionServices;
        private Guid AccountId;
        private LoggedinAccount theLoggedInAccount = Program.theLoggedInAccount;

        public SecurityQuestionModal(Form mainform)
        {
            InitializeComponent();
            Mainform = mainform;
            AccountId = Program.theLoggedInAccount.AccountId;
        }
        //Insert Security Questions and Answers
        private async Task EnterSecurityQuestion()
        {
            SecurityQuestionServices = new SecurityQuestionServices(new SystemBackEnd.BackEndDBContext());
            insertSecurityQuestion = new InsertSecurityQuestion()
            {
                AccountId = AccountId,
                AllQuestionAnswers = new List<InsertSecurityQuestionAnswer>()
                {
                    new InsertSecurityQuestionAnswer()
                    {
                        Question = Question1.Text,
                        Answer = Answer1.Text
                    },
                    new InsertSecurityQuestionAnswer()
                    {
                        Question = Question2.Text,
                        Answer = Answer2.Text
                    },
                    new InsertSecurityQuestionAnswer()
                    {
                        Question = Question3.Text,
                        Answer = Answer3.Text
                    }
                }
            };
            bool isSuccess = await SecurityQuestionServices.AddSecurityQuestionAsync(insertSecurityQuestion);
            if (!isSuccess)
            {
                MessageBox.Show("An Error Occured", "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (theLoggedInAccount.NewlyLoggedIn == true)
                {
                    LoginServices loginServices = new LoginServices(new SystemBackEnd.BackEndDBContext());
                    bool SuccessChangingFirstTimeLogout = await loginServices.ChangeFirstTimeLogout(theLoggedInAccount.AccountId);
                }
                this.Close();
                this.DialogResult.Equals(DialogResult.OK);
            }

        }



        //Events
        private async void ValidateBtn_Click(object sender, EventArgs e)
        {
            await EnterSecurityQuestion();
        }
    }
}
