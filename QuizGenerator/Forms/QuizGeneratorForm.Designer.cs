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
            this.textBoxQuizName = new System.Windows.Forms.TextBox();
            this.labelQuizName = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.userControlQuestion1 = new QuizGenerator.UserControls.userControlQuestion();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Zapisz Quiz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Zapisz pytanie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Usuń pytanie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 398);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Wczytaj Quiz";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 398);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 333);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "-->";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 333);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "<--";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 362);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "Usuń Quiz";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // userControlQuestion1
            // 
            this.userControlQuestion1.Location = new System.Drawing.Point(8, 35);
            this.userControlQuestion1.Name = "userControlQuestion1";
            this.userControlQuestion1.Size = new System.Drawing.Size(278, 292);
            this.userControlQuestion1.TabIndex = 18;
            // 
            // QuizGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 433);
            this.Controls.Add(this.userControlQuestion1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private UserControls.userControlQuestion userControlQuestion1;
    }
}