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
        public double Score => GetScore();
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

        private double GetScore()
        {
            var result = 0.0;
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
