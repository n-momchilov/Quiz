using Quiz.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Quiz.Repository
{
    public class QuestionRepository
    {

        //public List<Question> Questions{ get; set; }
        private List<Question> questions;

        public List<Question> Questions
        {
            get
            {
                if (questions == null)
                {
                    questions = readJSON();
                }

                return questions;
            }

        }

        public Question RetrunQuestion(int questionPosition)
        {
            if (Questions == null)
            {
                return null;
            }
            if (questionPosition + 1 <= Questions.Count)
            {
                return Questions[questionPosition];
            }

            return null;
        }

        private List<Question> readJSON()
        {
            
            string fileName = AppDomain.CurrentDomain.BaseDirectory + @"Json\questions.json";
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<Question>>(jsonString);

        }
    }
}
