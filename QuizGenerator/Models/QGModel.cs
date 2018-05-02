using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizGenerator.Classes;
using System.Xml;
using System.IO;
namespace QuizGenerator.Models
{
    public class QGModel
    {
        #region FIELDS PROPERTIES
        List<Quiz> quiz = new List<Quiz>();
        Question newQuestion;
        Answer newAnswer;
        #endregion
        #region CONSTRUCTOR
        public QGModel()
        {

        }
        #endregion
        #region PUBLIC
        public List<string> GetQuiz()
        {
            List<string> xmlFiles = new List<string>();
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            foreach(string str in files)
            {
                Console.WriteLine(str);
                Console.WriteLine(Path.GetExtension(str));
                if (Path.GetExtension(str) == ".xml")
                {
                    xmlFiles.Add(Path.GetFileName(str.Split('.')[0]));
                }
            }
            
            return xmlFiles;
        }
        public bool DeleteQuiz(string quizName)
        {
            string toDelete;
            if (!quizName.EndsWith(".xml"))
            {
                toDelete = quizName + ".xml";
            }
            else toDelete = quizName;
            Console.WriteLine("To delete: " + AppDomain.CurrentDomain.BaseDirectory + toDelete);
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + toDelete))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + toDelete);
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool SaveQuestion(string quizName, string question, List<string> answers, List<bool> isRight)
        {

            if(Array.IndexOf(Directory.GetFileSystemEntries(AppDomain.CurrentDomain.BaseDirectory), AppDomain.CurrentDomain.BaseDirectory+ quizName + ".xml") >= 0)
            {
                Console.WriteLine("Quiz already Exsists, want to override it?");
                return false;
            }
            Quiz q;
            q = findQuiz(quizName);
            newQuestion = new Question(question);
            for(int i = 0; i < answers.Count;i++)
            {
                newAnswer = new Answer(answers[i],isRight[i]);
                newQuestion.AddAnswer(newAnswer);
            }
            q.AddQuestion(newQuestion);
            return true;
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

            return saveQuiz(newQuiz);
        }

        #endregion
        #region PRIVATE
        private Quiz findQuiz(string quizName)
        {
            foreach (Quiz q in quiz)
            {
                if(q.Name == quizName)
                {
                    return q;
                }
            }
            Quiz newQuiz = new Quiz(quizName);
            quiz.Add(newQuiz);
            return newQuiz;
        }
        private  bool saveQuiz(Quiz quizz)
        {
            try { if (System.IO.File.Exists(quizz.Name + ".xml")) System.IO.File.Delete(quizz.Name+".xml"); }
            catch (Exception) { return false; }
            if (quizz.Questions.Count == 0) return false;
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            using (XmlWriter writer = XmlWriter.Create(quizz.Name + ".xml",settings))
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
