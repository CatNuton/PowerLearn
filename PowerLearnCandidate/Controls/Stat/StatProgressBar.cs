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
        private float _value = 50;
        private string leftText;
        private string rightText;
        private Color leftColor = Color.FromArgb(102, 187, 106);
        private Color rightColor = Color.FromArgb(255, 112, 67);
        private int rounding = 30;
        private readonly SolidBrush leftBrush;
        private readonly SolidBrush rightBrush;
        private readonly SolidBrush textBrush;
        private readonly SolidBrush gapBrush = new SolidBrush(Color.White);
        private const int gap = 1;

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
                leftBrush.Color = leftColor;
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
                rightBrush.Color = rightColor;
                Invalidate();
            }
        }
        public int Rounding
        {
            get => rounding; set
            {
                if (rounding == value)
                {
                    return;
                }
                rounding = value;
                Invalidate();
            }
        }

        public StatProgressBar()
        {
            SetStyle(ControlStyles.UserPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor, true);
            textBrush = new SolidBrush(Color.Black);
            leftBrush = new SolidBrush(leftColor);
            rightBrush = new SolidBrush(rightColor);
            ForeColor = Color.White;
            BackColor = Color.Transparent;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            var h = e.Graphics.MeasureString(leftText, Font).Height;
            h = Math.Max(h, e.Graphics.MeasureString(rightText, Font).Height);
            var rect = new Rectangle(ClientRectangle.Location, new Size(ClientRectangle.Width - 1, (int)(ClientSize.Height - h)));
            var rounded = rect.Rounded(rounding);
            e.Graphics.FillPath(rightBrush, rounded);
            var w = (int)(Value * (rect.Width - gap) / 100);
            var progressRect = new Rectangle(rect.Location, new Size(w, rect.Height));
            e.Graphics.SetClip(progressRect);
            e.Graphics.FillPath(leftBrush, rounded);
            e.Graphics.ResetClip();
            var gapRect = new Rectangle(rect.Location, new Size(gap, rect.Height));
            gapRect.Offset(w, 0);
            e.Graphics.FillRectangle(gapBrush, gapRect);
            var percentFont = new Font(Font.FontFamily, rect.Height * 0.85f, FontStyle.Bold, GraphicsUnit.Pixel);
            var sf = new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Far };
            var tpv = (Value / 100).ToString("p1");
            var tw = e.Graphics.MeasureString(tpv, percentFont).Width;
            if (tw <= progressRect.Width)
            {
                e.Graphics.DrawString(tpv, percentFont, textBrush, progressRect, sf);
            }
            else
            {
                e.Graphics.DrawString(tpv, percentFont, textBrush, gapRect.Right, 0);
            }
            sf.LineAlignment = StringAlignment.Far;
            if (Value > 0)
            {
                sf.Alignment = StringAlignment.Near;
                e.Graphics.DrawString(leftText, Font, leftBrush, ClientRectangle, sf);
            }
            if (Value < 100)
            {
                sf.Alignment = StringAlignment.Far;
                e.Graphics.DrawString(rightText, Font, rightBrush, ClientRectangle, sf);
            }
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textBrush.Color = ForeColor;
        }
    }
}
