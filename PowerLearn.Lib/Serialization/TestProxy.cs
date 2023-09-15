using PowerLearn;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace PowerLearn.Serialization
{
    [XmlRoot("Test")]
    public class TestProxy : IXmlSerializable
    {
        private Test test;
        public Test Test => test;

        public TestProxy()
        {

        }

        public TestProxy(Test test)
        {
            this.test = test;
        }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            test = new Test();
            test.Name = reader.GetAttribute(nameof(test.Name));
            test.Description = reader.GetAttribute(nameof(test.Description));
            test.Type = reader.GetAttribute(nameof(test.Type));
            var id = int.Parse(reader.GetAttribute(nameof(test.Id)));
            if (id != 0)
            {
                test.Id = id;
            }
            test.CanLernersSeeAllQuestions = bool.Parse(reader.GetAttribute(nameof(test.CanLernersSeeAllQuestions)));
            test.Uploaded = bool.Parse(reader.GetAttribute(nameof(test.Uploaded)));
            reader.Read(); // Test to author
            test.Author = reader.Deserialize<Person>(nameof(test.Author));
            test.Candidate = reader.Deserialize<Person>(nameof(test.Candidate));
            test.Questions = new List<Question> ();
            if (reader.IsEmptyElement)
            {
                return;
            }
            var rst = reader.ReadSubtree();
            rst.Read(); //Author to questions
            while (rst.Read() && rst.IsStartElement())
            {
                var q = ReadQuestion(rst);
                test.Questions.Add(q);
            }
        }

        private static Question ReadQuestion(XmlReader reader)
        {
            var qt = reader.GetAttribute(nameof(Question.Text));
            var qtype = reader.GetAttribute(nameof(Question.Type));
            var type = (QuestionType)Enum.Parse(typeof(QuestionType), qtype);
            var q = new Question(qt, type);
            reader.Read(); // Question to answers
            q.Answers = reader.Deserialize<List<Answer>>(nameof(q.Answers));
            if (reader.IsEmptyElement)
            {
                reader.Read();
                return q;
            }
            var imgBase64 = reader.ReadElementContentAsString();
            q.Image = imgBase64.ToImage();
            return q;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString(nameof(Test.Name), Test.Name);
            writer.WriteAttributeString(nameof(Test.Description), Test.Description);
            writer.WriteAttributeString(nameof(Test.Type), Test.Type);
            writer.WriteAttributeString(nameof(Test.Id), Test.Id.ToString());
            writer.WriteAttributeString(nameof(Test.CanLernersSeeAllQuestions), Test.CanLernersSeeAllQuestions.ToString());
            writer.WriteAttributeString(nameof(Test.Uploaded), Test.Uploaded.ToString());
            //NewMethod(Test.Author, writer, "Author");
            Test.Author.Serialize(writer, nameof(Test.Author));
            Test.Candidate.Serialize(writer, nameof(Test.Candidate));   
            writer.WriteStartElement(nameof(Test.Questions));
            foreach (var q in Test.Questions)
            {
                writer.WriteStartElement("Question");
                writer.WriteAttributeString(nameof(q.Text), q.Text);
                writer.WriteAttributeString(nameof(q.Type), q.Type.ToString());
                q.Answers.Serialize(writer, "Answers");
                writer.WriteStartElement("Image");
                if (q.Image != null)
                {
                    writer.WriteString(q.Image.ToBase64());
                }
                writer.WriteEndElement();//Image
                writer.WriteEndElement();//Question
            }
            writer.WriteEndElement();//Questions
        }

        //private void NewMethod<T>(T o, XmlWriter writer, string root)
        //{
        //    var xmlra = new XmlRootAttribute(root);
        //    var sr = new XmlSerializer(typeof(T), xmlra);//Test.Author.GetType()
        //    sr.Serialize(writer, o);
        //}
        
    }
}
