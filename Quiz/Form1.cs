using Quiz.Model;
using Quiz.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class QuizForm : Form
    {
        private Question question;
        private QuestionService service;
        private Timer timerMin = new Timer();
        private Timer timerSec = new Timer();
        private int minutes = 2;
        private int initMinutes = 0;
        public QuizForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            service = new QuestionService();
            question = service.GetNextQuestion();
            this.LoadQuestion();
            this.TimerLoad();

        }
        

        private void LoadQuestion()
        {
            this.Questions.Text = question.Caption;
            this.Answer1.Text = question.Answers[0].Caption;
            this.Answer2.Text = question.Answers[1].Caption;
            this.Answer3.Text = question.Answers[2].Caption;
            this.Answer4.Text = question.Answers[3].Caption;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            question = service.GetNextQuestion();
            if (question != null )
            {
                this.LoadQuestion();
                this.ClearForm();
            }
            else
            {
                LoadQuizEnd();
            }            
        }

        private void LoadQuizEnd()
        {
            label1.Text = service.GetScore().ToString();
            label2.Text = service.getValue().ToString();
            // value
            this.Next.Enabled = false;
            this.Answer1.Enabled = false;
            this.Answer2.Enabled = false;
            this.Answer3.Enabled = false;
            this.Answer4.Enabled = false;
            this.Answer1.Visible = false;
            this.Answer2.Visible = false;
            this.Answer3.Visible = false;
            this.Answer4.Visible = false;
            this.Questions.Visible = false;
        }

        private void ClearForm()
        {   
            this.Answer1.Checked = false;
            this.Answer2.Checked = false;
            this.Answer3.Checked = false;
            this.Answer4.Checked = false;
            this.Answer1.Enabled = true;
            this.Answer2.Enabled = true;
            this.Answer3.Enabled = true;
            this.Answer4.Enabled = true;

            this.Answer2.BackColor = Color.Transparent;
            this.Answer3.BackColor = Color.Transparent;
            this.Answer4.BackColor = Color.Transparent;
            this.Answer1.BackColor = Color.Transparent;
            this.Next.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Answer1.Checked == false)
            {
                return;
            }
            int correctAnswer = service.checkAnswer(1);
           if (1 != correctAnswer)           
            {
                this.Answer1.BackColor = Color.Red;
            }
            this.AnswerSelected(correctAnswer);
            this.DisableRadioButtons();
            
        }

        private void DisableRadioButtons()
        {
            Answer1.Enabled = false;
            Answer2.Enabled = false;
            Answer3.Enabled = false;
            Answer4.Enabled = false;
        }

        private void AnswerSelected(int correctAnswer)
        {
            this.setGreen(correctAnswer);
            label1.Text = service.GetScore().ToString();
            this.Next.Enabled = true;
        }


        private void setGreen(int answerNo)
        {
            switch(answerNo)
            {
                case 1:
                    this.Answer1.BackColor = Color.Green;
                    break;
                case 2:
                    this.Answer2.BackColor = Color.Green;
                    break;
                case 3:
                    this.Answer3.BackColor = Color.Green;
                    break;
                case 4:
                    this.Answer4.BackColor = Color.Green;
                    break;
            }
        }

        private void Answer3_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Answer3.Checked == false)
            {
                return;
            }

            int correctAnswer = service.checkAnswer(3);
            if (3 != correctAnswer)
            {
                this.Answer3.BackColor = Color.Red;
            }
            this.AnswerSelected(correctAnswer);
            this.DisableRadioButtons();
        }

        private void Answer2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Answer2.Checked == false)
            {
                return;
            }
            int correctAnswer = service.checkAnswer(2);
            if (2 != correctAnswer)
            {
                this.Answer2.BackColor = Color.Red;
            }
            this.AnswerSelected(correctAnswer);
            this.DisableRadioButtons();
        }

        private void Answer4_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Answer4.Checked == false)
            {
                return;
            }
            int correctAnswer = service.checkAnswer(4);
            if (4 != correctAnswer)
            {
                this.Answer4.BackColor = Color.Red;
            }
            this.AnswerSelected(correctAnswer);
            this.DisableRadioButtons();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TimerLoad()
        {
            this.initMinutes = minutes;
            labelMin.Text = (this.minutes).ToString();
           
            timerMin.Interval = (1 * 60 * 1000); // 1 mins
            timerMin.Tick += new EventHandler(timerMin_Tick);
            timerMin.Start();

            labelSec.Text = "0";
            timerSec.Interval = (1000); // 1 sec
            timerSec.Tick += new EventHandler(timerSec_Tick);
            timerSec.Start();
        }
        private void timerMin_Tick(object sender, EventArgs e)
        {
            this.minutes--;
            if (this.minutes == 0)  //if the countdown reaches '0', we stop it
            {
                this.timerSec.Stop();
                this.timerMin.Stop();
                LoadQuizEnd();
            }
            else
            {
                labelMin.Text = (this.minutes - 1).ToString();
            }
        }

        private void timerSec_Tick(object sender, EventArgs e)
        {
            if (minutes == initMinutes)
            {
                labelMin.Text = (this.minutes - 1).ToString();
            }
            if (labelSec.Text == "0")
            {
                labelSec.Text = "59";
            }
            else if (labelSec.Text == "1")
            {
                labelSec.Text = "0";
            }
            else
            {
                labelSec.Text = (int.Parse(labelSec.Text) - 1).ToString();
            }
        }

       
           
            
        
    }
}
