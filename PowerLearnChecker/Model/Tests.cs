using System.Collections.Generic;
using System.Xml.Serialization;

namespace PowerLearnChecker
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Tests));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Tests)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "Tests")]
    public class Tests
    {

        [XmlElement(ElementName = "test")]
        public List<Test> Test { get; set; }
    }
}
