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
        public bool IsRight { get { return checkBoxRight.Checked; } set { checkBoxRight.Checked = value; } }
        public string Answer { get { return textBoxAnswer.Text; } set { textBoxAnswer.Text = value; } }
        public userControlAnswer()
        {
            InitializeComponent();
        }
    }
}
