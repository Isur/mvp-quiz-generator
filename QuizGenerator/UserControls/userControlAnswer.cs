using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGenerator.UserControls
{
    public partial class userControlAnswer : UserControl
    {
        public bool IsRight { get { return checkBoxRight.Checked; } }
        public string Answer { get { return textBoxAnswer.Text; } }
        public userControlAnswer()
        {
            InitializeComponent();
        }
    }
}
