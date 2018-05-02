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
            this.textBoxQuizName.BackColor = System.Drawing.Color.Gray;
            this.textBoxQuizName.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQuizName.ForeColor = System.Drawing.Color.White;
            this.textBoxQuizName.Location = new System.Drawing.Point(102, 12);
            this.textBoxQuizName.Name = "textBoxQuizName";
            this.textBoxQuizName.Size = new System.Drawing.Size(200, 22);
            this.textBoxQuizName.TabIndex = 0;
            // 
            // labelQuizName
            // 
            this.labelQuizName.AutoSize = true;
            this.labelQuizName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuizName.ForeColor = System.Drawing.Color.White;
            this.labelQuizName.Location = new System.Drawing.Point(4, 12);
            this.labelQuizName.Name = "labelQuizName";
            this.labelQuizName.Size = new System.Drawing.Size(92, 18);
            this.labelQuizName.TabIndex = 1;
            this.labelQuizName.Text = "Nazwa Quizu";
            // 
            // buttonSaveQuiz
            // 
            this.buttonSaveQuiz.BackColor = System.Drawing.Color.Gray;
            this.buttonSaveQuiz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSaveQuiz.FlatAppearance.BorderSize = 0;
            this.buttonSaveQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveQuiz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.buttonSaveQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonSaveQuiz.Location = new System.Drawing.Point(12, 384);
            this.buttonSaveQuiz.Name = "buttonSaveQuiz";
            this.buttonSaveQuiz.Size = new System.Drawing.Size(290, 31);
            this.buttonSaveQuiz.TabIndex = 3;
            this.buttonSaveQuiz.Text = "Zapisz Quiz";
            this.toolTipDelete.SetToolTip(this.buttonSaveQuiz, "Zapisz Quiz o podanej nazwie.");
            this.buttonSaveQuiz.UseVisualStyleBackColor = false;
            this.buttonSaveQuiz.Click += new System.EventHandler(this.buttonSaveQuiz_Click);
            // 
            // buttonSaveQuestion
            // 
            this.buttonSaveQuestion.BackColor = System.Drawing.Color.Gray;
            this.buttonSaveQuestion.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSaveQuestion.FlatAppearance.BorderSize = 0;
            this.buttonSaveQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveQuestion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.buttonSaveQuestion.ForeColor = System.Drawing.Color.White;
            this.buttonSaveQuestion.Location = new System.Drawing.Point(12, 347);
            this.buttonSaveQuestion.Name = "buttonSaveQuestion";
            this.buttonSaveQuestion.Size = new System.Drawing.Size(290, 31);
            this.buttonSaveQuestion.TabIndex = 2;
            this.buttonSaveQuestion.Text = "Zapisz pytanie";
            this.toolTipDelete.SetToolTip(this.buttonSaveQuestion, "Zapisz pytanie do Quizu o podanej nazwie.");
            this.buttonSaveQuestion.UseVisualStyleBackColor = false;
            this.buttonSaveQuestion.Click += new System.EventHandler(this.buttonSaveQuestion_Click);
            // 
            // comboBoxQuizList
            // 
            this.comboBoxQuizList.BackColor = System.Drawing.Color.Gray;
            this.comboBoxQuizList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQuizList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxQuizList.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxQuizList.ForeColor = System.Drawing.Color.White;
            this.comboBoxQuizList.FormattingEnabled = true;
            this.comboBoxQuizList.Location = new System.Drawing.Point(12, 458);
            this.comboBoxQuizList.Name = "comboBoxQuizList";
            this.comboBoxQuizList.Size = new System.Drawing.Size(290, 24);
            this.comboBoxQuizList.TabIndex = 5;
            this.comboBoxQuizList.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuizList_SelectedIndexChanged);
            this.comboBoxQuizList.Click += new System.EventHandler(this.comboBoxQuizList_Click);
            // 
            // buttonDeleteQuiz
            // 
            this.buttonDeleteQuiz.BackColor = System.Drawing.Color.Gray;
            this.buttonDeleteQuiz.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteQuiz.FlatAppearance.BorderSize = 0;
            this.buttonDeleteQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteQuiz.Font = new System.Drawing.Font("Palatino Linotype", 9.75F);
            this.buttonDeleteQuiz.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteQuiz.Location = new System.Drawing.Point(12, 421);
            this.buttonDeleteQuiz.Name = "buttonDeleteQuiz";
            this.buttonDeleteQuiz.Size = new System.Drawing.Size(290, 31);
            this.buttonDeleteQuiz.TabIndex = 4;
            this.buttonDeleteQuiz.Text = "Usuń Quiz";
            this.toolTipDelete.SetToolTip(this.buttonDeleteQuiz, "Wybierz Quiz, który chcesz usunąć z listy poniżej.");
            this.buttonDeleteQuiz.UseVisualStyleBackColor = false;
            this.buttonDeleteQuiz.Click += new System.EventHandler(this.buttonDeleteQuiz_Click);
            // 
            // toolTipDelete
            // 
            this.toolTipDelete.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // userControlQuestion
            // 
            this.userControlQuestion.AnswersString = ((System.Collections.Generic.List<string>)(resources.GetObject("userControlQuestion.AnswersString")));
            this.userControlQuestion.BackColor = System.Drawing.Color.DimGray;
            this.userControlQuestion.ForeColor = System.Drawing.Color.White;
            this.userControlQuestion.Location = new System.Drawing.Point(12, 34);
            this.userControlQuestion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userControlQuestion.Name = "userControlQuestion";
            this.userControlQuestion.Size = new System.Drawing.Size(290, 306);
            this.userControlQuestion.TabIndex = 1;
            // 
            // QuizGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(311, 489);
            this.Controls.Add(this.userControlQuestion);
            this.Controls.Add(this.buttonDeleteQuiz);
            this.Controls.Add(this.comboBoxQuizList);
            this.Controls.Add(this.buttonSaveQuestion);
            this.Controls.Add(this.buttonSaveQuiz);
            this.Controls.Add(this.labelQuizName);
            this.Controls.Add(this.textBoxQuizName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "QuizGeneratorForm";
            this.ShowIcon = false;
            this.Text = "QuizGenerator";
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
        private System.Windows.Forms.ToolTip toolTipDelete;
        private UserControls.userControlQuestion userControlQuestion;
    }
}