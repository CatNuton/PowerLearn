﻿using PowerLearn.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCandidate.Controls
{
    public class RectangleFigure : Control
    {
        private Color color = Color.LightGray;
        private SolidBrush brush;
        private int rounding;

        public Color Color
        {
            get => color; set
            {
                if (color == value)
                {
                    return;
                }
                color = value;
                brush.Color = color;
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

        public RectangleFigure()
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            var rect = ClientRectangle.Rounded(rounding);
            e.Graphics.SetClip(rect);
            e.Graphics.FillPath(brush, rect);
        }
    }
}
