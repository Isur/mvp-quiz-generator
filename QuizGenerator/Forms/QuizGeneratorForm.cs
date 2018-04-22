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
        #endregion

        #region PUBLIC

        #endregion

        #region PRIVATE

        #endregion

        private void QuizGeneratorForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSaveQuiz_Click(object sender, EventArgs e)
        {
            SaveQuiz(textBoxQuizName.Text);
        }
    }
}
