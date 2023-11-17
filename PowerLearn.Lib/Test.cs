using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PowerLearn
{
    public class Test
    {
        [Category("Test")]
        public string Name { get; set; }
        [XmlAttribute, Category("Test")]
        public string Description { get; set; }
        [Category("Test")]
        public string Type { get; set; }
        [Browsable(false)]
        public Person Author { get; set; }
        [Category("Test"), DisplayName("Can lerners see all questions?")]
        public bool CanLernersSeeAllQuestions { get; set; }
        [Browsable(false)]
        public float MaxScore => GetMaxScore();
        [Browsable(false)]
        public int Id { get; set; }
        [Browsable(false)]
        public Person Candidate { get; set; }
        [Browsable(false)]
        public bool Uploaded { get; set; }

        public Test()
        {
            var guid = Guid.NewGuid();
            Id = guid.GetHashCode();
            Uploaded = false;
        }

        private float GetMaxScore()
        {
            var result = 0f;
            foreach (var item in Questions)
            {
                result += GetQuestionsMaxScore(item);
            }
            return result;
        }

        private float GetQuestionsMaxScore(Question q)
        {
            var result = 0f;
            if (q.Type == QuestionType.SingleAnswer)
            {
                result = q.Answers[0].Weight;
            }
            else if (q.Type == QuestionType.MultipleAnswers)
            {
                result = q.MaxScore;
            }
            return result;
        }

        [Browsable(false)]
        public List<Question> Questions { get; set; } = new List<Question> { };
        [Browsable(false)]
        public float Score => GetScore();

        private float GetScore()
        {
            var result = 0f;
            foreach (var item in Questions)
            {
                result += item.Score;
            }
            return result;
        }
    }
}
