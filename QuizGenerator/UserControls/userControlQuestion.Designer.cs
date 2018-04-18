namespace QuizGenerator.UserControls
{
    partial class userControlQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAnswers = new System.Windows.Forms.Label();
            this.labelIsRight = new System.Windows.Forms.Label();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.buttonDeleteAnswer = new System.Windows.Forms.Button();
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.userControlAnswer4 = new QuizGenerator.UserControls.userControlAnswer();
            this.userControlAnswer3 = new QuizGenerator.UserControls.userControlAnswer();
            this.userControlAnswer2 = new QuizGenerator.UserControls.userControlAnswer();
            this.userControlAnswer1 = new QuizGenerator.UserControls.userControlAnswer();
            this.SuspendLayout();
            // 
            // labelAnswers
            // 
            this.labelAnswers.AutoSize = true;
            this.labelAnswers.Location = new System.Drawing.Point(5, 29);
            this.labelAnswers.Name = "labelAnswers";
            this.labelAnswers.Size = new System.Drawing.Size(65, 13);
            this.labelAnswers.TabIndex = 18;
            this.labelAnswers.Text = "Odpowiedzi:";
            // 
            // labelIsRight
            // 
            this.labelIsRight.AutoSize = true;
            this.labelIsRight.Location = new System.Drawing.Point(5, 42);
            this.labelIsRight.Name = "labelIsRight";
            this.labelIsRight.Size = new System.Drawing.Size(63, 13);
            this.labelIsRight.TabIndex = 17;
            this.labelIsRight.Text = "Prawidłowa";
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(5, 6);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(45, 13);
            this.labelQuestion.TabIndex = 16;
            this.labelQuestion.Text = "Pytanie:";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(89, 3);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(183, 20);
            this.textBoxQuestion.TabIndex = 15;
            // 
            // buttonDeleteAnswer
            // 
            this.buttonDeleteAnswer.Location = new System.Drawing.Point(242, 32);
            this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
            this.buttonDeleteAnswer.Size = new System.Drawing.Size(30, 23);
            this.buttonDeleteAnswer.TabIndex = 14;
            this.buttonDeleteAnswer.Text = "-";
            this.buttonDeleteAnswer.UseVisualStyleBackColor = true;
            this.buttonDeleteAnswer.Click += new System.EventHandler(this.buttonDeleteAnswer_Click);
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Location = new System.Drawing.Point(206, 32);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(30, 23);
            this.buttonAddAnswer.TabIndex = 13;
            this.buttonAddAnswer.Text = "+";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // userControlAnswer4
            // 
            this.userControlAnswer4.Location = new System.Drawing.Point(16, 150);
            this.userControlAnswer4.Name = "userControlAnswer4";
            this.userControlAnswer4.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer4.TabIndex = 20;
            // 
            // userControlAnswer3
            // 
            this.userControlAnswer3.Location = new System.Drawing.Point(16, 125);
            this.userControlAnswer3.Name = "userControlAnswer3";
            this.userControlAnswer3.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer3.TabIndex = 19;
            // 
            // userControlAnswer2
            // 
            this.userControlAnswer2.Location = new System.Drawing.Point(16, 100);
            this.userControlAnswer2.Name = "userControlAnswer2";
            this.userControlAnswer2.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer2.TabIndex = 12;
            // 
            // userControlAnswer1
            // 
            this.userControlAnswer1.Location = new System.Drawing.Point(16, 75);
            this.userControlAnswer1.Name = "userControlAnswer1";
            this.userControlAnswer1.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer1.TabIndex = 11;
            // 
            // userControlQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControlAnswer4);
            this.Controls.Add(this.userControlAnswer3);
            this.Controls.Add(this.labelAnswers);
            this.Controls.Add(this.labelIsRight);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.buttonDeleteAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.userControlAnswer2);
            this.Controls.Add(this.userControlAnswer1);
            this.Name = "userControlQuestion";
            this.Size = new System.Drawing.Size(278, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnswers;
        private System.Windows.Forms.Label labelIsRight;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonDeleteAnswer;
        private System.Windows.Forms.Button buttonAddAnswer;
        private userControlAnswer userControlAnswer2;
        private userControlAnswer userControlAnswer1;
        private userControlAnswer userControlAnswer3;
        private userControlAnswer userControlAnswer4;
    }
}
