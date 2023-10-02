using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLearnCreator.Controls
{
    public static class ImageHelper
    {
        public static Image Resize(this Image img, Size desiredSize)
        {
            var ratioW = (float)desiredSize.Width / img.Width;
            var rationH = (float)desiredSize.Height / img.Height;
            var ratio = Math.Min(ratioW, rationH);
            var w = (int)(img.Width * ratio);
            var h = (int)(img.Height * ratio);
            var result = new Bitmap(w, h);
            using (var g = Graphics.FromImage(result))
            {
                g.DrawImage(img, 0, 0, result.Width, result.Height);
            }
            return result;
        }

        public static Image Resize(this Image bmp, int width, int height)
        {
            return bmp.Resize(new Size(width, height));
        }
    }
}
