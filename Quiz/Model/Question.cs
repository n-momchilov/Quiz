using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Model
{
   public class Question
    {
        public string Caption { get; set; }
        public List<Answer> Answers { get; set; }
        public int CorrectAnswerNumber { get; set; }

        public Question()
        {
            this.Answers = new List<Answer>();
        }

        public void addAnswer(Answer answer)
        {
            this.Answers.Add(answer);
        }
    }
}
