using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms.QuizGeneratorForm view = new Forms.QuizGeneratorForm();
            Models.QGModel model = new Models.QGModel();
            Presenters.QGPresenter presenter = new Presenters.QGPresenter(view, model);
            Application.Run(view);
        }
    }
}
