using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearnCandidate.Controls
{
    public class EventArgs<T> : System.EventArgs
    {
        public T Value { get; set; }

        public EventArgs(T value)
        {
            Value = value;
        }
    }

    public class StringEventArgs : EventArgs<string>
    {
        public StringEventArgs(string value) : base(value)
        {
        }
    }
}
