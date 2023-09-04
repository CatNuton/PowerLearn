using System;
using System.Drawing;

namespace PowerLearnCreator.Controls
{
    public class AddImageEventArgs : EventArgs
    {
        public Image Image { get; set; }

        public AddImageEventArgs(Image image)
        {
            Image = image;
        }
    }
}