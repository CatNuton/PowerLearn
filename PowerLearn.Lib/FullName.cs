using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerLearn
{
    public class FullName
    {
        [XmlAttribute("first")]
        public string FirstName { get; set; }
        [XmlAttribute]
        public string LastName { get; set; }
        [XmlAttribute]
        public string Patronym { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {Patronym}";
        }
    }
}
