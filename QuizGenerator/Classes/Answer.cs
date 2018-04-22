using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator
{
    public class Answer
    {
        public string AnswerString { get; set; }
        public bool IsRight { get; set; }

        #region CONSTRUCTOR
        public Answer(string answer, bool isRight)
        {
            this.AnswerString = answer;
            this.IsRight = isRight;
        }
        #endregion
        #region PUBLIC

        #endregion
        #region PRIVATE

        #endregion
    }
}
