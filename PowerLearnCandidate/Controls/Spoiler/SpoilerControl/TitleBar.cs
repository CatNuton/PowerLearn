using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PowerLearnCandidate.Controls
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class TitleBar
    {

        private Color backColor = SystemColors.ActiveCaption;
        [DefaultValue(typeof(Color), "162,188,216")]
        public Color BackColor
        {
            get { return backColor; }
            set
            {
                if (backColor != value)
                {
                    backColor = value;
                    redraw(false);
                }
            }
        }

        private Color foreColor = Color.White;
        [DefaultValue(typeof(Color), "White")]
        public Color ForeColor
        {
            get { return foreColor; }
            set
            {
                if (foreColor != value)
                {
                    foreColor = value;
                    redraw(false);
                }
            }
        }

        private Font font;
        private readonly Action<bool> redraw;

        public virtual Font Font
        {
            get
            {
                return font;
            }
            set
            {
                if (font != value)
                {
                    font = value;
                    redraw(true);
                }
            }
        }

        private Padding padding = new Padding(3);

        [DefaultValue(typeof(Padding), "3")]
        public virtual Padding Padding
        {
            get
            {
                return padding;
            }
            set
            {
                if (padding != value)
                {
                    padding = value;
                    redraw(true);
                }
            }
        }
        [Browsable(false)]
        public string Text { get; set; }
        private TitleAlign titleAlign;
        [DefaultValue(typeof(TitleAlign), "0")]
        public TitleAlign TitleAlign
        {
            get => titleAlign; set
            {
                if (titleAlign != value)
                {
                    titleAlign = value;
                    redraw(false);
                }
            }
        }

        public int Height => (int)(font.GetHeight() + padding.Top + padding.Bottom);

        public TitleBar(Font font, Action<bool> redraw)
        {
            this.font = font;
            this.redraw = redraw;
        }

        public void Draw(Graphics g, Rectangle textBounds)
        {
            using (var b = new SolidBrush(BackColor))
            {
                g.FillRectangle(b, textBounds);
            }

            var sf = new StringFormat
            {
                LineAlignment = StringAlignment.Center,
                Alignment = (StringAlignment)TitleAlign
            };
            var r = new Rectangle(
                textBounds.Left + Padding.Left,
                textBounds.Top,
                textBounds.Width - Padding.Left - Padding.Right,
                textBounds.Height);
            using (var b = new SolidBrush(ForeColor))
            {
                g.DrawString(Text, Font, b, r, sf);
            }
        }

        public override string ToString()
        {
            return Text;
        }
    }

}
