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
        }
    }
}
