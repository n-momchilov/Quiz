using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quiz.Model;
using Quiz.Repository;

namespace Quiz.Service
{
    public class QuestionService
    {
        private QuestionRepository repository = new QuestionRepository();
        private int counter = 0;
        private Question currentQuestion;
        private int score = 0;

        public Question GetNextQuestion()
        {
            Question question = repository.RetrunQuestion(counter);
            counter++;
            currentQuestion = question;
            return question;
        }

        public int GetScore()
        {
            return score;
        }

        public int checkAnswer(int checkedNumber)
        {
            if (checkedNumber == currentQuestion.CorrectAnswerNumber)
            {
                this.IncreaseScore();
            }

            return currentQuestion.CorrectAnswerNumber;
        }

        public int getValue()
        {
            if (this.score <= 600)
            {
                return 3;
            }
            if (this.score <= 800)
            {
                return 4;
            }
            if (this.score <= 1000)
            {
                return 5;
            }
            if (this.score <= 1200)
            {
                return 6;
            }

            // else if
            return 2;
        }

        private void IncreaseScore()
        {
            this.score += 100;
        }
       


        
    }
}
