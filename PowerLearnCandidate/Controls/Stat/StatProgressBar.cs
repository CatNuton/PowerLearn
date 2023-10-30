using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCandidate.Controls.Stat
{
    public class StatProgressBar : Control
    {
        private float _value;
        private string leftText;
        private string rightText;
        private Color leftColor;
        private Color rightColor;

        public float Value
        {
            get => _value; set
            {
                if (_value == value)
                {
                    return;
                }
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Value is out of range!");
                }
                _value = value;
                Invalidate();
            }
        }
        public string LeftText
        {
            get => leftText; set
            {
                if (leftText == value)
                {
                    return;
                }
                leftText = value;
                Invalidate();
            }
        }
        public string RightText
        {
            get => rightText; set
            {
                if (rightText == value)
                {
                    return;
                }
                rightText = value;
                Invalidate();
            }
        }
        public Color LeftColor
        {
            get => leftColor; set
            {
                if (leftColor == value)
                {
                    return;
                }
                leftColor = value;
                Invalidate();
            }
        }
        public Color RightColor
        {
            get => rightColor; set
            {
                if (rightColor == value)
                {
                    return;
                }
                rightColor = value;
                Invalidate();
            }
        }

        public StatProgressBar()
        {
            SetStyle(ControlStyles.UserPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }
    }
}
