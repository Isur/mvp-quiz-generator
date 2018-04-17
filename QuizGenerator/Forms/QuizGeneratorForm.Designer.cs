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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.userControlAnswer2 = new QuizGenerator.UserControls.userControlAnswer();
            this.userControlAnswer1 = new QuizGenerator.UserControls.userControlAnswer();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuizName
            // 
            this.textBoxQuizName.Location = new System.Drawing.Point(89, 9);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Zapisz Quiz";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pytanie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prawidłowa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Odpowiedzi:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(178, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Zapisz pytanie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Usuń pytanie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 361);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 23);
            this.button6.TabIndex = 13;
            this.button6.Text = "Wczytaj Quiz";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(174, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // userControlAnswer2
            // 
            this.userControlAnswer2.Location = new System.Drawing.Point(16, 121);
            this.userControlAnswer2.Name = "userControlAnswer2";
            this.userControlAnswer2.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer2.TabIndex = 3;
            // 
            // userControlAnswer1
            // 
            this.userControlAnswer1.Location = new System.Drawing.Point(16, 93);
            this.userControlAnswer1.Name = "userControlAnswer1";
            this.userControlAnswer1.Size = new System.Drawing.Size(256, 22);
            this.userControlAnswer1.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(145, 296);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(31, 23);
            this.button7.TabIndex = 15;
            this.button7.Text = "-->";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 296);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(31, 23);
            this.button8.TabIndex = 16;
            this.button8.Text = "<--";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(8, 325);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(94, 23);
            this.button9.TabIndex = 17;
            this.button9.Text = "Usuń Quiz";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // QuizGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 396);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.userControlAnswer2);
            this.Controls.Add(this.userControlAnswer1);
            this.Controls.Add(this.labelQuizName);
            this.Controls.Add(this.textBoxQuizName);
            this.Name = "QuizGeneratorForm";
            this.Text = "QuizGeneratorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuizName;
        private System.Windows.Forms.Label labelQuizName;
        private UserControls.userControlAnswer userControlAnswer1;
        private UserControls.userControlAnswer userControlAnswer2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}