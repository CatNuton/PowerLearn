using PowerLearn.Controls;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PowerLearn.Controls
{
    public class RoundedButton : Rounded
    {
        public RoundedButton() : base()
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(Parent.BackColor);
            //e.Graphics.SetClip(Path);
            if (Enabled)
            {
                e.Graphics.FillPath(backBrush, Path); 
            }
            else
            {
                e.Graphics.FillPath(SystemBrushes.Control, Path);
            }
            DrawText(e.Graphics);
            if (mouseEntered)
            {
                e.Graphics.FillPath(hoverBrush, Path);
            }
        }
    }
}