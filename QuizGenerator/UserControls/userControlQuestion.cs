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
        private int answerRight;
        public string Question { get { return textBoxQuestion.Text; } }
        private List<string> answersString = new List<string>();
        private List<bool> answerIsRight = new List<bool>();
        public List<string> AnswersString
        {
            get
            {
                answersString.Clear();
                for(int i=0;i<answerCounter;i++)
                {
                    Console.WriteLine(answers[i].Answer + " right: " + answers[i].IsRight);
                    answersString.Add(answers[i].Answer);
                }
                return answersString;
            }
            set
            {
                
            }
        }
        public List<bool> AnswerIsRight
        { get
            {
                answerIsRight.Clear();
                for (int i = 0; i < answerCounter; i++)
                {
                    answerIsRight.Add(answers[i].IsRight);
                }
                return answerIsRight;
            }
        }
        private int answerCounter;
        private userControlAnswer[] answers = new userControlAnswer[8];
        public userControlQuestion()
        {
            answersString = new List<string>();
            InitializeComponent();
            answers[0] = userControlAnswer1;
            answers[1] = userControlAnswer2;
            answers[2] = userControlAnswer3;
            answers[3] = userControlAnswer4;
            answerCounter = 4;
            
        }   
        public bool IsFill()
        {
            answerRight = 0;
            for(int i = 0; i < answerCounter; i++)
            {
                if (string.IsNullOrWhiteSpace(answers[i].Answer))
                    return false;
                if (answers[i].IsRight == true)
                    answerRight++;
            }

            if (answerRight == 0)
                return false;
            return true;
        }
        public void Clear()
        {
            textBoxQuestion.Text = "";
            for (int i = 0; i < answerCounter; i++)
            {
                answers[i].Answer = "";
                answers[i].IsRight = false;
            }
        }
        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            if (answerCounter < 8)
            {
                userControlAnswer newAnswer = new userControlAnswer();
                this.Controls.Add(newAnswer);
                newAnswer.Width = 275;
                newAnswer.Height = 22;
                newAnswer.Top = 61 + 29 * answerCounter;
                newAnswer.Left = 8;
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
