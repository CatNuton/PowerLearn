using PowerLearn.Animator;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace PowerLearn.Controls
{
    [Designer(typeof(ControlDesignerEx))] // ControlDesignerEx Добавляем для ограничения изменения размеров
    [DefaultProperty("TextPreview")]
    public class GoogleTextBox : Control
    {
        #region -- Свойства --
        public string TextPreview { get; set; } = "Input text";
        public bool Multiline
        {
            get => tbInput.Multiline; set
            {
                tbInput.Multiline = value;
            }
        }
        private Font fontTextPreview = new Font("Arial", 8, FontStyle.Bold);
        public Font FontTextPreview
        {
            get => fontTextPreview;
            set
            {
                // Ограничение, чтобы размер шрифта заголовка нельзя было установить больше, 
                // чем размер основного шрифта
                if (value.Size >= Font.Size)
                    return;
                fontTextPreview = value;
            }
        }

        public Color BorderColor { get; set; } = Color.DeepSkyBlue;
        public Color BorderColorNotActive { get; set; } = Color.DarkGray;

        public string TextInput
        {
            get => tbInput.Text;
            set
            {
                tbInput.Text = value;
                if (!tbInput.Focused)
                    TextPreviewAction(Text.Length > 0);
            }
        }

        public bool UseSystemPasswordChar
        {
            get => tbInput.UseSystemPasswordChar;
            set => tbInput.UseSystemPasswordChar = value;
        }

        public new string Text
        {
            get => tbInput.Text;
            set
            {
                tbInput.Text = value;
                if (!tbInput.Focused)
                    TextPreviewAction(Text.Length > 0);
            }
        }

        public int SelectionStart
        {
            get => tbInput.SelectionStart;
            set => tbInput.SelectionStart = value;
        }

        public int TextLength
        {
            get => tbInput.TextLength;
        }

        #endregion

        #region -- События / Events --

        [Browsable(true)]
        public new event EventHandler TextChanged
        {
            add { tbInput.TextChanged += value; }
            remove { tbInput.TextChanged -= value; }
        }

        [Browsable(true)]
        public new event KeyPressEventHandler KeyPress
        {
            add { tbInput.KeyPress += value; }
            remove { tbInput.KeyPress -= value; }
        }

        #endregion

        #region -- Переменные --

        private readonly StringFormat SF = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };
        private int TopBorderOffset = 0;
        private TextBox tbInput = new TextBox { Dock = DockStyle.Fill};
        private Animation LocationTextPreviewAnim = new Animation();
        private Animation FontSizeTextPreviewAnim = new Animation();

        #endregion

        public GoogleTextBox()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(150, 40);
            Font = new Font("Arial", 11.25F, FontStyle.Regular);
            ForeColor = Color.Black;
            BackColor = Color.White;
            Padding = new Padding(5, 0, 5, 3);
            Cursor = Cursors.IBeam;


            AdjustTextBoxInput();
            Controls.Add(tbInput);

            LocationTextPreviewAnim.Value = tbInput.Location.Y;
            FontSizeTextPreviewAnim.Value = Font.Size;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            TextPreviewAction(Text.Length > 0);
        }

        private void AdjustTextBoxInput()
        {
            tbInput = new TextBox
            {
                Name = "InputBox",
                BorderStyle = BorderStyle.None,
                BackColor = BackColor,
                ForeColor = ForeColor,
                Font = Font,
                Visible = false,
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
            };

            var offset = TextRenderer.MeasureText(TextPreview, FontTextPreview).Height;
            tbInput.Location = new Point(8, Height / 2 - offset);
            tbInput.Size = new Size(Width - 10, tbInput.Height);

            tbInput.LostFocus += TbInput_LostFocus;
            tbInput.GotFocus += tbInput_OnGotFocus;
        }

        private void tbInput_OnGotFocus(object sender, EventArgs e)
        {
            base.OnGotFocus(e);
            TextPreviewAction(true);
        }
        private void TbInput_LostFocus(object sender, EventArgs e)
        {
            base.OnLostFocus(e);
            TextPreviewAction(false);
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            TextPreviewAction(true);
        }

        #region -- Обновление свойств tbInput --
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            tbInput.BackColor = BackColor;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            tbInput.ForeColor = ForeColor;
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            tbInput.Font = Font;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            tbInput.Size = new Size(Width - 10, tbInput.Height);
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;

            g.Clear(Parent.BackColor);

            TopBorderOffset = (int)(g.MeasureString(TextPreview, FontTextPreview).Height / 2);

            var FontTextPreviewActual = new Font(FontTextPreview.FontFamily, FontSizeTextPreviewAnim.Value, FontTextPreview.Style);

            if (!tbInput.Visible && FontTextPreviewActual.Size <= FontTextPreview.Size)
            {
                tbInput.Visible = true;
                tbInput.Focus();
            }
            else if (tbInput.Visible && FontTextPreviewActual.Size > FontTextPreview.Size)
            {
                tbInput.Visible = false;
            }

            var rectBase = new Rectangle(0, TopBorderOffset, Width - 1, Height - 1 - TopBorderOffset);

            var TextPreviewRectSize = g.MeasureString(TextPreview, FontTextPreviewActual).ToSize();
            var rectTextPreview = new Rectangle(Padding.Left, (int)Math.Truncate(LocationTextPreviewAnim.Value), TextPreviewRectSize.Width + Padding.Right, TextPreviewRectSize.Height - Padding.Bottom);

            // Обводка
            g.DrawRectangle(new Pen(tbInput.Text.Length > 0 || tbInput.Focused ?
                BorderColor : BorderColorNotActive), rectBase);

            // Заголовок/Описание
            g.DrawRectangle(new Pen(Parent.BackColor), rectTextPreview);
            g.FillRectangle(new SolidBrush(Parent.BackColor), rectTextPreview);

            // Цвет внутри
            g.FillRectangle(new SolidBrush(BackColor), rectBase);

            g.DrawString(TextPreview, FontTextPreviewActual,
                new SolidBrush(tbInput.Text.Length > 0 || tbInput.Focused ?
                BorderColor : BorderColorNotActive), rectTextPreview, SF);
        }

        private void TextPreviewAction(bool OnTop)
        {
            if (OnTop)
            {
                if (tbInput.Visible == false)
                {
                    LocationTextPreviewAnim = new Animation("TextPreviewLocationY" + Handle, Invalidate, LocationTextPreviewAnim.Value, 0);
                    FontSizeTextPreviewAnim = new Animation("TextPreviewFontSize" + Handle, Invalidate, FontSizeTextPreviewAnim.Value, FontTextPreview.Size);
                }
                else
                {
                    tbInput.Focus();
                    return;
                }
            }
            else
            {
                if (Text.Length == 0)
                {
                    LocationTextPreviewAnim = new Animation("TextPreviewLocationY" + Handle, Invalidate, LocationTextPreviewAnim.Value, tbInput.Location.Y);
                    FontSizeTextPreviewAnim = new Animation("TextPreviewFontSize" + Handle, Invalidate, FontSizeTextPreviewAnim.Value, Font.Size);
                }
                else
                {
                    return;
                }
            }

            LocationTextPreviewAnim.StepDivider = 4;
            FontSizeTextPreviewAnim.StepDivider = 4;

            Animator.Animator.Request(LocationTextPreviewAnim, true);
            Animator.Animator.Request(FontSizeTextPreviewAnim, true);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);

            TextPreviewAction(true);
        }
    }

    internal class ControlDesignerEx : ControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                var sr = SelectionRules.LeftSizeable |
                    SelectionRules.RightSizeable |
                    SelectionRules.Moveable |
                    SelectionRules.Visible;
                return sr;
            }
        }
    }
}
