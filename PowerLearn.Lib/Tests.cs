using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearn
{
    public class Tests : List<Test>
    {
        public new void Add(Test test)
        {
            base.Add(test);
        }
    }
}
