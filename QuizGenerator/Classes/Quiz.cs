using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator.Classes
{
    public class Quiz
    {
        private List<Question> questions = new List<Question>();
        public string Name { get; set; }
        public List<Question> Questions { get { return questions; } set { questions = value; } }
        #region CONSTRUCTOR
        public Quiz(string name)
        {
            this.Name = name;
        }
        #endregion
        #region PUBLIC
        public void AddQuestion(Question q)
        {
             questions.Add(q);
        }
    
        #endregion
        #region PRIVATE

        #endregion
    }
}
