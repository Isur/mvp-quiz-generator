using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator.Forms
{
    public partial class QuizGeneratorForm : Form, Views.IQGView
    {
        #region CONSTRUCTOR
        public QuizGeneratorForm()
        {
            InitializeComponent();
        }
        #endregion
        #region INTERFACE
        public List<string> Answers
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<bool> IsRight
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string QuizName
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion
        #region PUBLIC

        #endregion
        #region PRIVATE

        #endregion
    }
}
