using PowerLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearnCreator.Controls
{
    public class QuestionEventArgs : EventArgs
    {
        public Question Question { get; set; }

        public QuestionEventArgs(Question question)
        {
            Question = question;
        }
    }
}
