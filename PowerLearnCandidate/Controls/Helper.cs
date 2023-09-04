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
    internal static class Helper
    {
        internal static GraphicsPath Rounded(this Rectangle rect, float d)
        {
            var result = new GraphicsPath();
            result.AddArc(rect.X, rect.Y, d, d, 180, 90);
            result.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
            result.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
            result.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
            result.CloseFigure();
            return result;
        }

        internal static GraphicsPath Rounded(this Rectangle rect, int p)
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

        internal static int Limit(this int value, int limit)
        {
            if (value > limit)
            {
                return limit;
            }
            return value;
        }
    }
}
