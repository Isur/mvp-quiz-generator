using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator
{
    class Question
    {
        List<Answer> Answers { get; set; }
        string question;
        #region CONSTRUCTOR
        public Question(string question)
        {
            this.question = question;
        }
        #endregion
        #region PUBLIC
        void AddAnswer(Answer newAnswer)
        {
            Answers.Add(newAnswer);
        }
        #endregion
        #region PRIVATE

        #endregion
    }
}
