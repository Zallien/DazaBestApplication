using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.ServiceModels
{
    public class SucurityQuestionModel
    {

        public Guid QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }

    public class SucurityQuestionAnswerModel
    {
        public Guid AccountId { get; set; }
        public List<SucurityQuestionModel> SucurityQuestions { get; set; }
    }
}
