using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemBackEnd.Models
{
    public class SecurityQuestions
    {
        [Key]
        public int Row { get; set; }
        public Guid QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public Guid AccountId { get; set; }
    }
}
