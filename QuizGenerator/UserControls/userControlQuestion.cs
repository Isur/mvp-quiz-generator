using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator.UserControls
{
    public partial class userControlQuestion : UserControl
    {
        private int answerCounter;
        private userControlAnswer[] answers = new userControlAnswer[8];
        public userControlQuestion()
        {
            InitializeComponent();
            answers[0] = userControlAnswer1;
            answers[1] = userControlAnswer2;
            answers[2] = userControlAnswer3;
            answers[3] = userControlAnswer4;
            answerCounter = 4;
        }   

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            if (answerCounter < 8)
            {
                userControlAnswer newAnswer = new userControlAnswer();
                this.Controls.Add(newAnswer);
                newAnswer.Width = 256;
                newAnswer.Height = 22;
                newAnswer.Top = 75 + 25 * answerCounter;
                newAnswer.Left = 16;
                answers[answerCounter] = newAnswer;
                answerCounter++;               
            }
            System.Console.WriteLine(answerCounter);
        }

        private void buttonDeleteAnswer_Click(object sender, EventArgs e)
        {
            if(answerCounter > 2)
            {
                this.Controls.Remove(answers[answerCounter-1]);
                answerCounter--;
            }
            System.Console.WriteLine(answerCounter);
        }
    }
}
