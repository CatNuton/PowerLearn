using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearn.Controls
{
    public static class RoundedHelper
    {
        public static GraphicsPath Rounded(this Rectangle rect, float d)
        {
            var result = new GraphicsPath();
            result.AddArc(rect.X, rect.Y, d, d, 180, 90);
            result.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            result.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            result.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            result.CloseFigure();
            return result;
        }

        public static GraphicsPath Rounded(this Rectangle rect, int p)
        {
            if (p == 0)
            {
                var gp = new GraphicsPath();
                gp.AddRectangle(rect);
                return gp;
            }
            var d = rect.Height * p / 100f;
            if (rect.Height > rect.Width)
            {
                d = rect.Width * p / 100f;
            }
            return rect.Rounded(d);
        }

        public static int Limit(this int value, int limit)
        {
            if (value > limit)
            {
                return limit;
            }
            return value;
        }

        public static float Area(this Size size)
        {
            return size.Width * size.Height;
        }
    }
}
