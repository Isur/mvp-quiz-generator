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
        public Quiz() { }
        #endregion
        #region PUBLIC
        public void AddQuestion(Question q)
        {
             questions.Add(q);
        }
        public void showEverything()
        {
            Console.WriteLine("Quiz Name: " + Name);
            foreach(Question q in questions)
            {
                Console.WriteLine("Question string: " + q.QuestionString);
                foreach(Answer ans in q.Answers)
                {
                    Console.WriteLine("Answer string: " + ans.AnswerString + " // Answer is right: " + ans.IsRight);
                }
            }
        }
        #endregion
        #region PRIVATE

        #endregion
    }
}
