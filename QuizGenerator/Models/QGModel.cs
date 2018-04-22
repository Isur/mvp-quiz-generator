using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGenerator.Classes;
using System.Xml;
namespace QuizGenerator.Models
{
    public class QGModel
    {
        #region FIELDS PROPERTIES
        List<Quiz> quiz;
        Question newQuestion;
        Answer newAnswer;
        #endregion
        #region CONSTRUCTOR
        public QGModel()
        {

        }
        #endregion
        #region PUBLIC
        public bool SaveQuestion(string quizName, string question, List<string> answers, List<bool> isRight)
        {
            foreach(Quiz q in quiz)
            {
                if(q.Name == quizName)
                {
                    newQuestion = new Question(question);
                    for(int i = 0; i < answers.Count;i++)
                    {
                        newAnswer = new Answer(answers[i],isRight[i]);
                        newQuestion.AddAnswer(newAnswer);
                    }
                    

                    break;
                }
            }
            return new bool();
        }
        public bool SaveQuiz(string quizName)
        {
            if(quiz != null)
            {
                foreach(Quiz q in quiz)
                {
                    if(q.Name == quizName)
                    {
                        return saveQuiz(q);
                    }
                }
            }
            Quiz newQuiz = new Quiz(quizName);
            Question g = new Question("Pytanie nr 1");
            Answer a = new Answer("Odpowiedz nr 1", true);
            g.AddAnswer(a);
            newQuiz.AddQuestion(g);
            g = new Question("Pytanie nr 2?");
            a = new Answer("Odpowiedz nr 1", false);
            g.AddAnswer(a);
            a = new Answer("Odpowiedz nr 2", true);
            g.AddAnswer(a);
            a = new Answer("Odpowiedz nr 3", false);
            g.AddAnswer(a);
            newQuiz.AddQuestion(g);
            g = new Question("Pytanie nr 3?");
            a = new Answer("Odpowiedz nr 1", false);
            g.AddAnswer(a);
            a = new Answer("Odpowiedz nr 2", true);
            g.AddAnswer(a);
            a = new Answer("Odpowiedz nr 3", false);
            g.AddAnswer(a);
            a = new Answer("Odpowiedz nr 4", true);
            g.AddAnswer(a);
            newQuiz.AddQuestion(g);

            return saveQuiz(newQuiz);
        }

        #endregion
        #region PRIVATE

        private  bool saveQuiz(Quiz quizz)
        {
            try { if (System.IO.File.Exists("quiz.xml")) System.IO.File.Delete("quiz.xml"); }
            catch (Exception) { return false; }
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create("quiz.xml",settings))
            {
                

                writer.WriteStartDocument();
                writer.WriteStartElement("Quiz");
                writer.WriteElementString("QuizName", quizz.Name);
                foreach(Question q in quizz.Questions)
                {
                    writer.WriteStartElement("Question");
                    writer.WriteElementString("QuestionContent", q.QuestionString);
                    
                    foreach(Answer a in q.Answers)
                    {
                        writer.WriteStartElement("Answer");
                        writer.WriteElementString("AnswerContent", a.AnswerString);
                        writer.WriteElementString("IsRight", a.IsRight.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            return true;
        }
        #endregion
    }
}
