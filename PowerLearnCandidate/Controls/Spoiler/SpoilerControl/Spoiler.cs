using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static PowerLearnCandidate.Controls.Win32Helpers;

namespace PowerLearnCandidate.Controls
{
    public class Spoiler : Panel
    {
        private readonly TitleBar titleBar;
        private bool showTitlebar = true;
        [DefaultValue(true)]
        public bool ShowTitlebar
        {
            get { return showTitlebar; }
            set
            {
                if (showTitlebar != value)
                {
                    showTitlebar = value;
                    RecalculateClientSize();
                    Redraw();
                }
            }
        }

        public string CollapsedText
        {
            get => collapsedText; set
            {
                if (collapsedText != value)
                {
                    collapsedText = value;
                    titleBar.Text = collapsedText;
                    Redraw();
                }
            }
        }

        public string UncollapsedText
        {
            get => uncollapsedText; set
            {
                if (uncollapsedText != value)
                {
                    uncollapsedText = value;
                    titleBar.Text = uncollapsedText;
                    Redraw();
                }
            }
        }

        private int fullHeight;
        private bool collapsed;
        private string collapsedText;
        private string uncollapsedText;
        public TitleBar TitleBar => titleBar;

        [DefaultValue(false)]
        public bool Collapsed
        {
            get
            {
                return collapsed;
            }
            set
            {
                if (collapsed != value)
                {
                    collapsed = value;
                    ToggleCollapsed();
                    Redraw();
                }
            }
        }


        public Spoiler()
        {
            titleBar = new TitleBar(Font, new Action<bool>(recalc =>
            {
                if (recalc)
                {
                    RecalculateClientSize();
                }
                Redraw();
            }));
        }

        private void ToggleCollapsed()
        {
            if (collapsed)
            {
                fullHeight = Height;
                Height = titleBar.Height;
                titleBar.Text = collapsedText;
            }
            else
            {
                Height = fullHeight;
                titleBar.Text = uncollapsedText;
            }
        }


        public virtual Rectangle GetTitlebarRectangle()
        {
            return new Rectangle(0, 0, Width, titleBar.Height);
        }

        protected virtual void OnTitleMouseClick(MouseEventArgs e)
        {
            Collapsed = !collapsed;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            switch (m.Msg)
            {
                case WM_NCPAINT:
                    WmNCPaint(ref m);
                    break;
                case WM_NCCALCSIZE:
                    WmNCCalcSize(ref m);
                    break;
                case WM_SETCURSOR:
                    if (m.LParam.Loword() == HTNOWHERE)
                    {
                        switch (m.LParam.Hiword())
                        {
                            case WM_LBUTTONUP:
                                OnTitleMouseClick(new MouseEventArgs(MouseButtons.Left, 1, Cursor.Position.X, Cursor.Position.Y, -1));
                                break;
                            case WM_MOUSEMOVE:
                                if (Cursor.Current != Cursors.Hand)
                                {
                                    Cursor.Current = Cursors.Hand;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    else if (m.LParam.Loword() == HTCLIENT)
                    {
                        switch (m.LParam.Hiword())
                        {
                            case WM_MOUSEMOVE:
                                if (Cursor.Current != Cursors.Default)
                                {
                                    Cursor.Current = Cursors.Default;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }

        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (collapsed)
            {
                Height = titleBar.Height;
                return;
            }
            base.OnSizeChanged(e);
            Redraw();
        }

        private void Redraw()
        {
            RedrawWindow(Handle, IntPtr.Zero, IntPtr.Zero,
               RDW_FRAME | RDW_INVALIDATE | RDW_UPDATENOW);
        }

        private void RecalculateClientSize()
        {
            SetWindowPos(this.Handle, IntPtr.Zero, 0, 0, 0, 0,
                SWP_NOSIZE | SWP_NOMOVE | SWP_FRAMECHANGED | SWP_NOZOORDER);
        }

        private void WmNCCalcSize(ref Message m)
        {
            var h = ShowTitlebar ? titleBar.Height : 0;
            var b = (int)BorderStyle;

            if (m.WParam != IntPtr.Zero)
            {
                var nccsp = (NCCALCSIZE_PARAMS)Marshal.PtrToStructure(m.LParam, typeof(NCCALCSIZE_PARAMS));
                nccsp.rgrc[0].top += h - b;
                nccsp.rgrc[0].bottom -= 0;
                nccsp.rgrc[0].left += 0;
                nccsp.rgrc[0].right -= 0;
                Marshal.StructureToPtr(nccsp, m.LParam, true);
                InvalidateRect(this.Handle, nccsp.rgrc[0], true);
                m.Result = IntPtr.Zero;
            }
        }

        private void WmNCPaint(ref Message m)
        {
            if (!ShowTitlebar)
            {
                return;
            }

            var dc = GetWindowDC(Handle);
            using (var g = Graphics.FromHdc(dc))
            {
                titleBar.Draw(g, GetTitlebarRectangle());

                if (BorderStyle != BorderStyle.None)
                {
                    using (var p = new Pen(titleBar.BackColor))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                    }
                }
            }
            ReleaseDC(Handle, dc);
            m.Result = IntPtr.Zero;
        }

        public override Size GetPreferredSize(Size proposedSize)
        {
            var size = base.GetPreferredSize(proposedSize);
            if (ShowTitlebar)
            {
                size.Height += titleBar.Height;
            }

            return size;
        }

        protected override void OnRightToLeftChanged(EventArgs e)
        {
            base.OnRightToLeftChanged(e);
            RecalculateClientSize();
            Redraw();
        }
    }
}