using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGenerator.Views
{
    interface IQGView
    {
        List<string> Answers { get; set; }
        List<bool> IsRight { get; set; }
        string QuizName { get; set; }
    }
}
