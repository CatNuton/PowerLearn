using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCandidate.Controls
{
    public abstract class Rounded : Button
    {
        protected bool mouseEntered;
        protected SolidBrush textBrush;
        protected LinearGradientBrush hoverBrush;
        protected SolidBrush backBrush;
        private int rounding;
        private bool isRounded;

        public Color HoverColor1 { get; set; }
        public Color HoverColor2 { get; set; }

        protected Rounded()
        {
            SetStyle(ControlStyles.UserPaint
                | ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.ResizeRedraw
                | ControlStyles.SupportsTransparentBackColor, true);
        }

        public bool IsRounded
        {
            get => isRounded; set
            {
                if (isRounded == value)
                {
                    return;
                }
                isRounded = value;
                SetPath();
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
                rounding = value.Limit(100);
                SetPath();
                Invalidate();
            }
        }

        private void SetPath()
        {
            if (isRounded)
            {
                Path = ClientRectangle.Rounded(rounding);
            }
            else
            {
                Path = ClientRectangle.Rounded(0);
            }
        }

        protected GraphicsPath Path { get; private set; } = new GraphicsPath();

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            textBrush = new SolidBrush(ForeColor);
            backBrush = new SolidBrush(BackColor);

            hoverBrush = new LinearGradientBrush(new Point(0, 0),
                     new Point(0, Height),
                     Color.FromArgb(100, HoverColor1),
                     Color.FromArgb(150, HoverColor2));
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseEntered = true;
            Cursor = Cursors.Hand;
            Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseEntered = false;
            Cursor = Cursors.Default;
            Invalidate();
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            textBrush = new SolidBrush(ForeColor);
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            backBrush = new SolidBrush(BackColor);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetPath();
        }

        protected void DrawText(Graphics g)
        {
            var sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            g.DrawString(Text, Font, textBrush, Width / 2f, Height / 2f, sf);
        }
    }
}
