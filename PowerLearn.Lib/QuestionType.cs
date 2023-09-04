using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearn
{
    public enum QuestionType
    {
        [Description("Question With Multiple Answers")]
        MultipleAnswers,
        [Description("Question With Single Answer")]
        SingleAnswer
    }
}
