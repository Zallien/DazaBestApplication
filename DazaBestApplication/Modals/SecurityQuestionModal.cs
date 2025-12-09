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

        private string[] Questions = new string[]
        {
            "What was your childhood nickname?",
            "In what city did you meet your spouse/significant other?",
            "What is the name of your favorite childhood friend?",
            "What street did you live on in third grade?",
            "What is your oldest sibling's birthday month and year? (e.g., January 1900)",
            "What is the middle name of your youngest child?",
            "What is your oldest sibling's middle name?",
            "What school did you attend for sixth grade?",
            "What was your childhood phone number including area code? (e.g., 000-000-0000)",
            "What is your maternal grandmother's maiden name?"
        };
        private List<string> PickedQuestions = new List<string>() ;



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
        //Populate all Questions combo box
        private async Task PopulateQuestionswithrandomquestion()
        {
            List<ComboBox> questionComboBoxes = new List<ComboBox>() { Question1, Question2, Question3 };
            Random rand = new Random();
            for (int i = 0; i < questionComboBoxes.Count; i++)
            {
                int index;
                do
                {
                    index = rand.Next(Questions.Length);
                } while (PickedQuestions.Contains(Questions[index]));
                PickedQuestions.Add(Questions[index]);
                questionComboBoxes[i].Text = Questions[index];
            }
            await RefreshItems();
        }
        private async Task RefreshItems()
        {
            //store selected questions
            List<ComboBox> questionComboBoxes = new List<ComboBox>() { Question1, Question2, Question3 };
            PickedQuestions = new();
            foreach (var cb in questionComboBoxes)
            {
                PickedQuestions.Add(cb.Text);
            }
            foreach (var cb in questionComboBoxes)
            {
                cb.Items.Clear();
                foreach (string q in Questions)
                {
                    if (PickedQuestions.Contains(q))
                    {
                        continue;
                    }
                    cb.Items.Add(q);
                }
            }
        }



        //Events
        private async void ValidateBtn_Click(object sender, EventArgs e)
        {
            await EnterSecurityQuestion();
        }
        private void Questions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (sender is ComboBox cb)
            {
                RefreshItems();
            }

        }

        private async void SecurityQuestionModal_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            await PopulateQuestionswithrandomquestion();
            this.Opacity = 1;
        }
    }
}
