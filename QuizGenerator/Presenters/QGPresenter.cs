using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator.Presenters
{
    public class QGPresenter
    {
        Views.IQGView view;
        Models.QGModel model;

        public QGPresenter(Views.IQGView view, Models.QGModel model)
        {
            this.view = view;
            this.model = model;
            view.SaveQuestion += saveQuestion;
            view.SaveQuiz += saveQuiz;
        }

        private bool saveQuestion(string quizName, string question, List<string> answers, List<bool> isRight)
        {
            return model.SaveQuestion(quizName, question, answers, isRight);
        }
        private bool saveQuiz(string quizName)
        {
            return model.SaveQuiz(quizName);
        }
    }
}
