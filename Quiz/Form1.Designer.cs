namespace Quiz
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.label1 = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Quiz = new System.Windows.Forms.GroupBox();
            this.Questions = new System.Windows.Forms.Label();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Next = new System.Windows.Forms.Button();
            this.Quiz.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 488);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(1285, 34);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(58, 16);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "labelMin";
            this.labelMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSec
            // 
            this.labelSec.AutoSize = true;
            this.labelSec.Location = new System.Drawing.Point(1360, 34);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(61, 16);
            this.labelSec.TabIndex = 6;
            this.labelSec.Text = "labelSec";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quiz.BackgroundImage")));
            this.Quiz.Controls.Add(this.Questions);
            this.Quiz.Controls.Add(this.label2);
            this.Quiz.Controls.Add(this.Answer4);
            this.Quiz.Controls.Add(this.Answer3);
            this.Quiz.Controls.Add(this.Answer2);
            this.Quiz.Controls.Add(this.label1);
            this.Quiz.Controls.Add(this.Answer1);
            this.Quiz.Location = new System.Drawing.Point(110, 135);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(1266, 529);
            this.Quiz.TabIndex = 2;
            this.Quiz.TabStop = false;
            this.Quiz.Text = "Quiz";
            // 
            // Questions
            // 
            this.Questions.AutoSize = true;
            this.Questions.Location = new System.Drawing.Point(341, 32);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(60, 16);
            this.Questions.TabIndex = 4;
            this.Questions.Text = "Question";
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.BackColor = System.Drawing.Color.Transparent;
            this.Answer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Answer4.Location = new System.Drawing.Point(161, 139);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(79, 20);
            this.Answer4.TabIndex = 3;
            this.Answer4.Text = "Answer4";
            this.Answer4.UseVisualStyleBackColor = false;
            this.Answer4.CheckedChanged += new System.EventHandler(this.Answer4_CheckedChanged);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.BackColor = System.Drawing.Color.Transparent;
            this.Answer3.ForeColor = System.Drawing.Color.Fuchsia;
            this.Answer3.Location = new System.Drawing.Point(161, 69);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(79, 20);
            this.Answer3.TabIndex = 2;
            this.Answer3.Text = "Answer3";
            this.Answer3.UseVisualStyleBackColor = false;
            this.Answer3.CheckedChanged += new System.EventHandler(this.Answer3_CheckedChanged);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.BackColor = System.Drawing.Color.Transparent;
            this.Answer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Answer2.Location = new System.Drawing.Point(18, 139);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(79, 20);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "Answer2";
            this.Answer2.UseVisualStyleBackColor = false;
            this.Answer2.CheckedChanged += new System.EventHandler(this.Answer2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1312, 705);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 46);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.BackColor = System.Drawing.Color.Transparent;
            this.Answer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Answer1.Location = new System.Drawing.Point(36, 69);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(79, 20);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "Answer1";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Fuchsia;
            this.Next.BackgroundImage = global::Quiz.Properties.Resources.Mike_Tyson_Portrait;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Enabled = false;
            this.Next.Image = global::Quiz.Properties.Resources.Mike_Tyson_Portrait;
            this.Next.Location = new System.Drawing.Point(667, 12);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(236, 100);
            this.Next.TabIndex = 0;
            this.Next.Text = "СЛЕДВАЩ ВЪПРОС";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1451, 763);
            this.Controls.Add(this.labelSec);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.Quiz.ResumeLayout(false);
            this.Quiz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Quiz;
        private System.Windows.Forms.Label Questions;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Next;
    }
}

