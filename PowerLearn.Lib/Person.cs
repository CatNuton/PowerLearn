using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerLearn
{
    public class Person
    {
        public FullName Name { get; set; } 

        public Person()
        {
            Name = new FullName();
        }

        [XmlIgnore]
        public int Id { get; internal set; }
        
        public override string ToString()
        {
            return $"{Name}";
        }

        //public Person Copy()
        //{
        //    //return new Person(Name, Age);
        //}
    }
}
