using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator.Views
{
    public interface IQGView
    {
        List<string> Answers { get; set; }
        List<bool> IsRight { get; set; }
        string QuizName { get; set; }
        string Question { get; set; }
        event Func<string, string, List<string>, List<bool>, bool> SaveQuestion;
        event Func<string, bool> SaveQuiz;
        event Func<string, bool> DeleteQuiz;
        event Func<List<string>> GetQuiz;
    }
}
