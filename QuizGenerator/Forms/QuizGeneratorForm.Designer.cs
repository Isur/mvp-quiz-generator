namespace QuizGenerator.Forms
{
    partial class QuizGeneratorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizGeneratorForm));
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.labelQuizName = new System.Windows.Forms.Label();
            this.buttonSaveQuiz = new System.Windows.Forms.Button();
            this.buttonSaveQuestion = new System.Windows.Forms.Button();
            this.comboBoxQuizList = new System.Windows.Forms.ComboBox();
            this.buttonDeleteQuiz = new System.Windows.Forms.Button();
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.userControlQuestion = new QuizGenerator.UserControls.userControlQuestion();
            this.SuspendLayout();
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.Location = new System.Drawing.Point(97, 9);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(183, 20);
            this.textBoxQuizName.TabIndex = 0;
            // 
            // labelQuizName
            // 
            this.labelQuizName.AutoSize = true;
            this.labelQuizName.Location = new System.Drawing.Point(5, 9);
            this.labelQuizName.Name = "labelQuizName";
            this.labelQuizName.Size = new System.Drawing.Size(70, 13);
            this.labelQuizName.TabIndex = 1;
            this.labelQuizName.Text = "Nazwa Quizu";
            // 
            // buttonSaveQuiz
            // 
            this.buttonSaveQuiz.Location = new System.Drawing.Point(8, 362);
            this.buttonSaveQuiz.Name = "buttonSaveQuiz";
            this.buttonSaveQuiz.Size = new System.Drawing.Size(124, 23);
            this.buttonSaveQuiz.TabIndex = 6;
            this.buttonSaveQuiz.Text = "Zapisz Quiz";
            this.toolTipDelete.SetToolTip(this.buttonSaveQuiz, "Zapisz Quiz o podanej nazwie.");
            this.buttonSaveQuiz.UseVisualStyleBackColor = true;
            this.buttonSaveQuiz.Click += new System.EventHandler(this.buttonSaveQuiz_Click);
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.Location = new System.Drawing.Point(152, 362);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(120, 23);
            this.buttonSaveQuestion.TabIndex = 7;
            this.buttonSaveQuestion.Text = "Zapisz pytanie";
            this.toolTipDelete.SetToolTip(this.buttonSaveQuestion, "Zapisz pytanie do Quizu o podanej nazwie.");
            this.buttonSaveQuestion.UseVisualStyleBackColor = true;
            this.buttonSaveQuestion.Click += new System.EventHandler(this.buttonSaveQuestion_Click);
            // 
            // comboBoxQuizList
            // 
            this.comboBoxQuizList.FormattingEnabled = true;
            this.comboBoxQuizList.Location = new System.Drawing.Point(98, 398);
            this.comboBoxQuizList.Name = "comboBoxQuizList";
            this.comboBoxQuizList.Size = new System.Drawing.Size(174, 21);
            this.comboBoxQuizList.TabIndex = 9;
            this.comboBoxQuizList.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuizList_SelectedIndexChanged);
            this.comboBoxQuizList.Click += new System.EventHandler(this.comboBoxQuizList_Click);
            // 
            // buttonDeleteQuiz
            // 
            this.buttonDeleteQuiz.Location = new System.Drawing.Point(8, 396);
            this.buttonDeleteQuiz.Name = "buttonDeleteQuiz";
            this.buttonDeleteQuiz.Size = new System.Drawing.Size(84, 23);
            this.buttonDeleteQuiz.TabIndex = 8;
            this.buttonDeleteQuiz.Text = "Usuń Quiz";
            this.toolTipDelete.SetToolTip(this.buttonDeleteQuiz, "Wybierz Quiz, który chcesz usunąć z listy obok.");
            this.buttonDeleteQuiz.UseVisualStyleBackColor = true;
            this.buttonDeleteQuiz.Click += new System.EventHandler(this.buttonDeleteQuiz_Click);
            // 
            // toolTipDelete
            // 
            this.toolTipDelete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // userControlQuestion
            // 
            this.userControlQuestion.AnswersString = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlQuestion.AnswersString")));
            this.userControlQuestion.Location = new System.Drawing.Point(8, 35);
            this.userControlQuestion.Name = "userControlQuestion";
            this.userControlQuestion.Size = new System.Drawing.Size(278, 292);
            this.userControlQuestion.TabIndex = 1;
            // 
            // QuizGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 433);
            this.Controls.Add(this.userControlQuestion);
            this.Controls.Add(this.buttonDeleteQuiz);
            this.Controls.Add(this.comboBoxQuizList);
            this.Controls.Add(this.buttonSaveQuestion);
            this.Controls.Add(this.buttonSaveQuiz);
            this.Controls.Add(this.labelQuizName);
            this.Controls.Add(this.textBoxQuizName);
            this.Name = "QuizGeneratorForm";
            this.Text = "QuizGeneratorForm";
            this.Load += new System.EventHandler(this.QuizGeneratorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuizName;
        private System.Windows.Forms.Label labelQuizName;
        private System.Windows.Forms.Button buttonSaveQuiz;
        private System.Windows.Forms.Button buttonSaveQuestion;
        private System.Windows.Forms.ComboBox comboBoxQuizList;
        private System.Windows.Forms.Button buttonDeleteQuiz;
        private UserControls.userControlQuestion userControlQuestion;
        private System.Windows.Forms.ToolTip toolTipDelete;
    }
}