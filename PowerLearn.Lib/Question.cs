using System.Collections.Generic;
using System.Drawing;
using System.Xml.Serialization;
using System;

namespace PowerLearn
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer> { };
        public float Score => GetScore();
        public float MaxScore => GetMaxScore();

        private float GetMaxScore()
        {
            var r = 0f;
            foreach (var item in Answers)
            {
                if (item.IsRight)
                {
                    r += item.Weight;
                }
            }
            return r;
        }

        [XmlIgnore]
        public Image Image { get; set; }
        public QuestionType Type { get; private set; }

        public Question(QuestionType type) : this("", type)
        {

        }

        public Question(string text, QuestionType type)
        {
            Text = text;
            Type = type;
        }

        public Question() : this(QuestionType.MultipleAnswers)
        {
        }

        private float GetScore()
        {
            var result = 0f;
            if (Type == QuestionType.MultipleAnswers)
            {
                foreach (var item in Answers)
                {
                    if (item.IsChecked && item.IsRight)
                    {
                        result += item.Weight;
                    }
                }
            }
            else if (Type == QuestionType.SingleAnswer)
            {
                var answer = Answers[0];
                var answerText = answer.Text.Trim();
                var enteredText = answer.EnteredAnswer.Trim();
                if (answerText.Equals(enteredText, StringComparison.OrdinalIgnoreCase))
                {
                    result = answer.Weight;
                }
            }
            return result;
        }
    }
}
