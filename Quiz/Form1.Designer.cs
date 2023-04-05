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
            this.points = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSec = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Next = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Quiz = new System.Windows.Forms.GroupBox();
            this.Answer2 = new System.Windows.Forms.RadioButton();
            this.Answer1 = new System.Windows.Forms.RadioButton();
            this.Answer4 = new System.Windows.Forms.RadioButton();
            this.Answer3 = new System.Windows.Forms.RadioButton();
            this.Questions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Quiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // points
            // 
            this.points.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.points.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.points.Location = new System.Drawing.Point(12, 686);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(167, 35);
            this.points.TabIndex = 4;
            this.points.Text = "points";
            this.points.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelMin
            // 
            this.labelMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelMin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMin.Location = new System.Drawing.Point(38, 23);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(122, 32);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "labelMin";
            this.labelMin.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelSec
            // 
            this.labelSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.labelSec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSec.ForeColor = System.Drawing.Color.Snow;
            this.labelSec.Location = new System.Drawing.Point(38, 85);
            this.labelSec.Name = "labelSec";
            this.labelSec.Size = new System.Drawing.Size(122, 32);
            this.labelSec.TabIndex = 6;
            this.labelSec.Text = "labelSec";
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.score.Location = new System.Drawing.Point(12, 606);
            this.score.Name = "score";
            this.score.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.score.Size = new System.Drawing.Size(167, 37);
            this.score.TabIndex = 7;
            this.score.Text = "score";
            this.score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.score.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CloseButton.Location = new System.Drawing.Point(1330, 675);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 46);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.score);
            this.panel1.Controls.Add(this.points);
            this.panel1.Controls.Add(this.labelSec);
            this.panel1.Controls.Add(this.labelMin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 763);
            this.panel1.TabIndex = 8;
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.Enabled = false;
            this.Next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(169, -1);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(1249, 117);
            this.Next.TabIndex = 0;
            this.Next.Text = "Next question";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.Next);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 119);
            this.panel2.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Quiz.Properties.Resources.Screenshot_2023_04_04_1724251;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 118);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Quiz
            // 
            this.Quiz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Quiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Quiz.BackgroundImage")));
            this.Quiz.Controls.Add(this.Answer2);
            this.Quiz.Controls.Add(this.Answer1);
            this.Quiz.Controls.Add(this.Answer4);
            this.Quiz.Controls.Add(this.Answer3);
            this.Quiz.Controls.Add(this.Questions);
            this.Quiz.Controls.Add(this.pictureBox1);
            this.Quiz.Location = new System.Drawing.Point(110, 222);
            this.Quiz.Name = "Quiz";
            this.Quiz.Size = new System.Drawing.Size(1196, 499);
            this.Quiz.TabIndex = 2;
            this.Quiz.TabStop = false;
            this.Quiz.Text = "Quiz";
            // 
            // Answer2
            // 
            this.Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.ForeColor = System.Drawing.Color.White;
            this.Answer2.Location = new System.Drawing.Point(734, 263);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(385, 52);
            this.Answer2.TabIndex = 1;
            this.Answer2.Text = "Answer2";
            this.Answer2.UseVisualStyleBackColor = false;
            this.Answer2.CheckedChanged += new System.EventHandler(this.Answer2_CheckedChanged);
            // 
            // Answer1
            // 
            this.Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.ForeColor = System.Drawing.Color.White;
            this.Answer1.Location = new System.Drawing.Point(203, 263);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(385, 52);
            this.Answer1.TabIndex = 0;
            this.Answer1.Text = "Answer1";
            this.Answer1.UseVisualStyleBackColor = false;
            this.Answer1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Answer4
            // 
            this.Answer4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer4.ForeColor = System.Drawing.Color.White;
            this.Answer4.Location = new System.Drawing.Point(734, 375);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(385, 52);
            this.Answer4.TabIndex = 3;
            this.Answer4.Text = "Answer4";
            this.Answer4.UseVisualStyleBackColor = false;
            this.Answer4.CheckedChanged += new System.EventHandler(this.Answer4_CheckedChanged);
            // 
            // Answer3
            // 
            this.Answer3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer3.ForeColor = System.Drawing.Color.White;
            this.Answer3.Location = new System.Drawing.Point(203, 375);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(385, 52);
            this.Answer3.TabIndex = 2;
            this.Answer3.Text = "Answer3";
            this.Answer3.UseVisualStyleBackColor = false;
            this.Answer3.CheckedChanged += new System.EventHandler(this.Answer3_CheckedChanged);
            // 
            // Questions
            // 
            this.Questions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Questions.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questions.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Questions.Location = new System.Drawing.Point(253, 98);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(824, 97);
            this.Questions.TabIndex = 7;
            this.Questions.Text = "Question";
            this.Questions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Questions.Click += new System.EventHandler(this.Questions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Quiz.Properties.Resources._317189;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(65, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1199, 518);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // QuizForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1451, 763);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Quiz);
            this.Controls.Add(this.CloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuizForm";
            this.Text = "Quiz";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Quiz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Questions;
        private System.Windows.Forms.RadioButton Answer4;
        private System.Windows.Forms.RadioButton Answer3;
        private System.Windows.Forms.RadioButton Answer2;
        private System.Windows.Forms.RadioButton Answer1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSec;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.GroupBox Quiz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

