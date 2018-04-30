using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator
{
    public class Question
    {
        private List<Answer> answers = new List<Answer>();
        public List<Answer> Answers { get { return answers; } set { answers = value; } }
        public string QuestionString { get; set; }
        #region CONSTRUCTOR
        public Question(string question)
        {
            this.QuestionString = question;
        }
        public Question() { }
        #endregion
        #region PUBLIC
        public void AddAnswer(Answer answ)
        {
            answers.Add(answ);
        }
        #endregion
        #region PRIVATE

        #endregion
    }
}
