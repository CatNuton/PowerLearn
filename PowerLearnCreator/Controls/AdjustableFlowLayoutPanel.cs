using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerLearnCreator.Controls
{
    public class AdjustableFlowLayoutPanel : FlowLayoutPanel
    {
        public AdjustableFlowLayoutPanel()
        {
            HorizontalScroll.Maximum = 0;
            WrapContents = false;
            AutoScroll = true;
            FlowDirection = FlowDirection.TopDown;
        }

        private void ResizeControls()
        {
            foreach (Control control in Controls)
            {
                control.Width = CalcControlWidth(control);
            }
        }

        private int CalcControlWidth(Control control)
        {
            return ClientRectangle.Width - Padding.Left - Padding.Right - control.Margin.Right - control.Margin.Left;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            ResizeControls();
        }

        protected override void OnPaddingChanged(EventArgs e)
        {
            base.OnPaddingChanged(e);
            ResizeControls();
        }
        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            e.Control.Width = CalcControlWidth(e.Control);
            ScrollControlIntoView(e.Control);
        }
    }
}
