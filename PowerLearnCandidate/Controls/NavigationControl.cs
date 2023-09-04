using PowerLearn;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCandidate
{
    public partial class NavigationControl : UserControl
    {
        //якщо можна продивлятися всі питання.
        //      Підсвічування номеру питання,
        //      Клік по номеру питання переводить на це питання
        //      Відповіді можна змінювати в будь який момент
        //якщо не можна продивлятися всі питання
        //      Показувати номер питання та загальну кількість питань 3/10 або 3(10)
        //      Після отримання відповіді її не можна змінити та переходити на наступне питання.
        private Test test;
        private int index;
        public NavigationControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw, true);
        }

        public void Build(Test test)
        {
            this.test = test;
            index = -1;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (test == null || test.Questions == null || test.Questions.Count == 0)
            {
                return;
            }
            var h = ClientRectangle.Height;
            var h2 = h / 2F;
            float w = ClientRectangle.Width - Padding.Left - Padding.Right;
            w /= test.Questions.Count;
            var w2 = w / 2F;
            e.Graphics.TranslateTransform(w2 + Padding.Left, h2);
            for (var i = 0; i < test.Questions.Count; i++)
            {
                var ab = Brushes.Black;
                var af = new Font(Font, FontStyle.Regular);
                if (i == index)
                {
                    ab = Brushes.Blue;
                    af = new Font(Font, FontStyle.Bold | FontStyle.Underline);
                }
                e.Graphics.DrawString($"{i + 1}", af, ab, new Point(0, 0));
                e.Graphics.TranslateTransform(w, 0);
            }
            base.OnPaint(e);
        }

        public void Back()
        {
            if (--index < 0)
            {
                index = 0;
            }
            Invalidate();
        }

        public void Forward()
        {
            if (test == null || test.Questions == null)
            {
                return;
            }
            if (++index >= test.Questions.Count)
            {
                index = test.Questions.Count - 1;
            }
            Invalidate();
        }
    }
}
