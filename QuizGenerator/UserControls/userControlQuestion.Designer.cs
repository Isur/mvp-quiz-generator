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
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.labelQuestion.Location = new System.Drawing.Point(30, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(54, 18);
            this.labelQuestion.TabIndex = 16;
            this.labelQuestion.Text = "Pytanie";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.Color.Gray;
            this.textBoxQuestion.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxQuestion.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQuestion.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion.Location = new System.Drawing.Point(90, 0);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(200, 22);
            this.textBoxQuestion.TabIndex = 0;
            // 
            // buttonDeleteAnswer
            // 
            this.buttonDeleteAnswer.BackColor = System.Drawing.Color.Gray;
            this.buttonDeleteAnswer.FlatAppearance.BorderSize = 0;
            this.buttonDeleteAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAnswer.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteAnswer.Location = new System.Drawing.Point(147, 28);
            this.buttonDeleteAnswer.Name = "buttonDeleteAnswer";
            this.buttonDeleteAnswer.Size = new System.Drawing.Size(136, 27);
            this.buttonDeleteAnswer.TabIndex = 2;
            this.buttonDeleteAnswer.Text = "Mniej odpowiedzi";
            this.buttonDeleteAnswer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonDeleteAnswer.UseVisualStyleBackColor = false;
            this.buttonDeleteAnswer.Click += new System.EventHandler(this.buttonDeleteAnswer_Click);
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.BackColor = System.Drawing.Color.Gray;
            this.buttonAddAnswer.FlatAppearance.BorderSize = 0;
            this.buttonAddAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddAnswer.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddAnswer.Location = new System.Drawing.Point(5, 28);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(136, 27);
            this.buttonAddAnswer.TabIndex = 1;
            this.buttonAddAnswer.Text = "Więcej odpowiedzi";
            this.buttonAddAnswer.UseVisualStyleBackColor = false;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // userControlAnswer4
            // 
            this.userControlAnswer4.Answer = "";
            this.userControlAnswer4.IsRight = false;
            this.userControlAnswer4.Location = new System.Drawing.Point(8, 148);
            this.userControlAnswer4.Name = "userControlAnswer4";
            this.userControlAnswer4.Size = new System.Drawing.Size(275, 22);
            this.userControlAnswer4.TabIndex = 6;
            // 
            // userControlAnswer3
            // 
            this.userControlAnswer3.Answer = "";
            this.userControlAnswer3.IsRight = false;
            this.userControlAnswer3.Location = new System.Drawing.Point(8, 119);
            this.userControlAnswer3.Name = "userControlAnswer3";
            this.userControlAnswer3.Size = new System.Drawing.Size(275, 22);
            this.userControlAnswer3.TabIndex = 5;
            // 
            // userControlAnswer2
            // 
            this.userControlAnswer2.Answer = "";
            this.userControlAnswer2.IsRight = false;
            this.userControlAnswer2.Location = new System.Drawing.Point(8, 90);
            this.userControlAnswer2.Name = "userControlAnswer2";
            this.userControlAnswer2.Size = new System.Drawing.Size(275, 22);
            this.userControlAnswer2.TabIndex = 4;
            // 
            // userControlAnswer1
            // 
            this.userControlAnswer1.Answer = "";
            this.userControlAnswer1.IsRight = false;
            this.userControlAnswer1.Location = new System.Drawing.Point(8, 61);
            this.userControlAnswer1.Name = "userControlAnswer1";
            this.userControlAnswer1.Size = new System.Drawing.Size(275, 22);
            this.userControlAnswer1.TabIndex = 3;
            // 
            // userControlQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.userControlAnswer4);
            this.Controls.Add(this.userControlAnswer3);
            this.Controls.Add(this.userControlAnswer2);
            this.Controls.Add(this.userControlAnswer1);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.buttonDeleteAnswer);
            this.Controls.Add(this.buttonAddAnswer);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "userControlQuestion";
            this.Size = new System.Drawing.Size(290, 286);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonDeleteAnswer;
        private System.Windows.Forms.Button buttonAddAnswer;
        private userControlAnswer userControlAnswer1;
        private userControlAnswer userControlAnswer2;
        private userControlAnswer userControlAnswer3;
        private userControlAnswer userControlAnswer4;
    }
}
