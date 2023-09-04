using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerLearnChecker
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Tests));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Tests)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "test")]
    public class Test
    {

        [XmlElement(ElementName = "id")]
        public int Id { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "max")]
        public int Max { get; set; }

        [XmlElement(ElementName = "score")]
        public int Score { get; set; }

        [XmlElement(ElementName = "date")]
        public double Date { get; set; }
    }
}