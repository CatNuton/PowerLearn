using PowerLearn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearnCreator.Controls
{
    public class AnswerEventArgs : EventArgs
    {
        public Answer Answer { get; set; }

        public AnswerEventArgs(Answer answer)
        {
            Answer = answer;
        }
    }
}
