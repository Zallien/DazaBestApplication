using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class InsertSecurityQuestion
    {
        public Guid AccountId { get; set; }
        public List<InsertSecurityQuestionAnswer> AllQuestionAnswers { get; set; }
    }

    public class InsertSecurityQuestionAnswer
    {
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
