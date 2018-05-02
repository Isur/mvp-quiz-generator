namespace QuizGenerator.UserControls
{
    partial class userControlAnswer
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
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.AutoSize = true;
            this.checkBoxRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBoxRight.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxRight.FlatAppearance.BorderSize = 0;
            this.checkBoxRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRight.Location = new System.Drawing.Point(3, 3);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(12, 11);
            this.checkBoxRight.TabIndex = 0;
            this.checkBoxRight.UseVisualStyleBackColor = true;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.Color.Gray;
            this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxAnswer.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAnswer.ForeColor = System.Drawing.Color.White;
            this.textBoxAnswer.Location = new System.Drawing.Point(24, 0);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(251, 22);
            this.textBoxAnswer.TabIndex = 1;
            // 
            // userControlAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.checkBoxRight);
            this.Name = "userControlAnswer";
            this.Size = new System.Drawing.Size(275, 22);
            this.Load += new System.EventHandler(this.userControlAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.TextBox textBoxAnswer;
    }
}
