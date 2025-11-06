using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class AccountDisplay
    {
        public Guid AccountId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public List<SecurityQuestionwithId>? AllSecurityQuestions { get; set; }
    }

    public class SecurityQuestionwithId
    {
        public Guid QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
