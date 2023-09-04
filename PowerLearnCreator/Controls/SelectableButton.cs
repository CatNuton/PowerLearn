using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Controls
{
    public class SelectableButton : Button
    {
        private bool selected;

        public bool Selected
        {
            get => selected; set
            {
                if (selected == value)
                {
                    return;
                }
                selected = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Selected && !Focused)
            {
                var rect = ClientRectangle;
                rect.Inflate(-1, -1);
                e.Graphics.DrawRectangle(Pens.LightGreen, rect);
            }
        }
    }
}
