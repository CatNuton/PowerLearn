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
        public static Image TryResize(this Image img, int treshold)
        {
            if (img.Width <= treshold && img.Height <= treshold)
            {
                return img;
            }
            var ratio = img.Height / (float)img.Width;//10/30=0.33
            var size = new Size();
            if (img.Width > img.Height)
            {
                size.Width = treshold;
                size.Height = (int)(ratio * size.Width);
            }
            else if (img.Width < img.Height)
            {
                size.Height = treshold;
                size.Width = (int)(size.Height / ratio);
            }
            else
            {
                size.Height = treshold;
                size.Width = treshold;
            }
            var result = new Bitmap(size.Width, size.Height);
            using (var g = Graphics.FromImage(result))
            {
                g.DrawImage(img, 0, 0, size.Width, size.Height);
            }
            return result;
        }
    }
}
