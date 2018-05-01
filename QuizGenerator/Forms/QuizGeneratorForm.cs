using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator.Forms
{
    public partial class QuizGeneratorForm : Form, Views.IQGView
    {
        #region CONSTRUCTOR
        public QuizGeneratorForm()
        {
            InitializeComponent();
        }
        #endregion
        #region INTERFACE
        public List<string> Answers
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<bool> IsRight
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Question
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string QuizName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public event Func<string, string, List<string>, List<bool>, bool> SaveQuestion;
        public event Func<string, bool> SaveQuiz;
        public event Func<string, bool> DeleteQuiz;
        public event Func<List<string>> GetQuiz;
        #endregion

        #region PUBLIC

        #endregion

        #region PRIVATE

        private void loadQuizList()
        {
            comboBoxQuizList.Items.Clear();
            foreach (string str in GetQuiz())
            {
                comboBoxQuizList.Items.Add(str);
            }
        }
        private void QuizGeneratorForm_Load(object sender, EventArgs e)
        {
            loadQuizList();
        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            if (SaveQuiz(textBoxQuizName.Text))
            {
                MessageBox.Show("Zapisano!");
            }
            else MessageBox.Show("Nie zapisano.");
           
        }

        private void buttonSaveQuestion_Click(object sender, EventArgs e)
        {
            string error = "";
            bool isError = false;
            if (string.IsNullOrWhiteSpace(textBoxQuizName.Text))
            {
                error += "\n Podaj nazwę quizu, do którego chcesz dodać to pytanie!";
                isError = true;
            }
            if(string.IsNullOrWhiteSpace(userControlQuestion.Question))
            {
                error += "\n Zadaj pytanie!";
                isError = true;
            }
            if (!userControlQuestion.IsFill())
            {
                error += "\n Wypełnij wszystkie odpowiedzi lub usuń puste!";
                isError = true;
            }
            if (isError)
            {
                MessageBox.Show(error, "Coś poszło nie tak...");
                return;
            }

            if(SaveQuestion(textBoxQuizName.Text, userControlQuestion.Question, userControlQuestion.AnswersString, userControlQuestion.AnswerIsRight))
            {
                MessageBox.Show("Pytanie zapisane!");
                
            }
            else if(MessageBox.Show("Quiz już istnieje, czy chcesz nadpisać?", "Quiz istnieje!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if(DeleteQuiz(textBoxQuizName.Text))
                {
                    MessageBox.Show("Istniejący quiz " + textBoxQuizName.Text + " został usunięty. Został utworzony nowy o tej samej nazwie!");
                    SaveQuestion(textBoxQuizName.Text, userControlQuestion.Question, userControlQuestion.AnswersString, userControlQuestion.AnswerIsRight);
                }
            }
            userControlQuestion.Clear();
        }


        private void buttonDeleteQuiz_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jesteś pewny, że chcesz usunąć Quiz o nazwie: " + comboBoxQuizList.SelectedItem.ToString() + ". Tej akcji nie można odwrócić!","Usuwanie quizu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (DeleteQuiz(comboBoxQuizList.SelectedItem.ToString()))
                {
                    MessageBox.Show("Quiz " + comboBoxQuizList.SelectedItem.ToString() + " został usunięty. Możesz utworzyć teraz nowy!");
                    loadQuizList();
                }
                else
                    MessageBox.Show("Quiz nie mógł zostać usunięty",":(" ,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void comboBoxQuizList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxQuizList_Click(object sender, EventArgs e)
        {
            loadQuizList();
        }
        #endregion
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (CloseCancel() == false)
            {
                e.Cancel = true;
            };
        }
        public static bool CloseCancel()
        {
            const string message = "Jesteś pewny, że chcesz wyjść? Wszystko zapisałeś?";
            const string caption = "Wyjście";
            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                return true;
            }
            else return false;
        }
    }
}
