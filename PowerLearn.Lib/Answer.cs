using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearn
{
    public class Answer
    {
        public string Text { get; set; } = "New Answer";
        [Browsable(false)]
        public string EnteredAnswer { get; set; }
        public float Weight { get; set; }
        [Browsable(false)]
        public bool IsRight { get; set; } 
        [Browsable(false)]
        public bool IsChecked { get; set; }
    }
}
