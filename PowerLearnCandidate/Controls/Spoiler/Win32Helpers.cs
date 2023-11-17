using System;
using System.Runtime.InteropServices;

namespace PowerLearnCandidate.Controls
{
    public static class Win32Helpers
    {
        public const int WM_SETCURSOR = 0x0020,
            WM_LBUTTONUP = 0x0202, 
            WM_MOUSEMOVE = 0x0200;
        public const int RDW_INVALIDATE = 0x0001,
            RDW_ERASE = 0x0004,
            RDW_ALLCHILDREN = 0x0080,
            RDW_ERASENOW = 0x0200,
            RDW_UPDATENOW = 0x0100,
            RDW_FRAME = 0x0400;
        public const int WM_NCCALCSIZE = 0x0083,
            WM_NCMOUSEMOVE = 0xA0,
            WM_NCPAINT = 0x85,
            WM_NCMOUSEHOVER = 0x2A0,
            WM_NCMOUSELEAVE = 0x2A2,
            WM_NCLBUTTONDOWN = 0xA1,
            WM_NCLBUTTONUP = 0xA2,
            WM_NCLBUTTONDBLCLK = 0xA3,
            WM_NCRBUTTONDOWN = 0xA4,
            WM_NCRBUTTONUP = 0xA5,
            WM_NCRBUTTONDBLCLK = 0xA6,
            WM_NCMBUTTONDOWN = 0xA7,
            WM_NCMBUTTONUP = 0xA8,
            WM_NCMBUTTONDBLCLK = 0xA9,
            WM_NCHITTEST = 0x0084;
        public const int SWP_FRAMECHANGED = 0x0020,
            SWP_NOMOVE = 0x0002,
            SWP_NOSIZE = 0x0001,
            SWP_NOZOORDER = 0x0004;
        public const int WS_BORDER = 0x00800000,
            WS_CAPTION = 0x00C00000,
            WS_EX_CLIENTEDGE = 0x00000200;

        public const int HTNOWHERE = 0x0,
            HTBORDER = 18,
            HTHSCROLL = 0x6,
            HTVSCROLL = 0x7,
            HTCLIENT = 0x1,
            HTCAPTION = 0x2;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int left, top, right, bottom;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct NCCALCSIZE_PARAMS
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
            public RECT[] rgrc;
            public WINDOWPOS lppos;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct WINDOWPOS
        {
            public IntPtr hwnd;
            public IntPtr hwndInsertAfter;
            public int x;
            public int y;
            public int cx;
            public int cy;
            public uint flags;
        }
        public const int NM_FIRST = 0;
        public const int NM_CLICK = NM_FIRST - 2;
        public const int WM_REFLECT = 0x2000;
        public const int WM_NOFITY = 0x004e;
        public const int WM_CTLCOLORSCROLLBAR = 0x0137;
        public const int TME_HOVER = 0x1,
            TME_NONCLIENT = 0x10,
            TME_LEAVE = 0x2;
        [StructLayout(LayoutKind.Sequential)]
        public struct NMHDR
        {
            public IntPtr hwndFrom;
            public IntPtr idFrom;
            public int code;
        }
        [StructLayout(LayoutKind.Sequential)]
        public struct TRACK_MOUSE_EVENT
        {
            public uint cbSize;
            public uint dwFlags;
            public IntPtr hwndTrack;
            public uint dwHoverTime;
            public static readonly TRACK_MOUSE_EVENT Empty;
        }
        [DllImport("user32.dll")]
        public static extern int TrackMouseEvent(out TRACK_MOUSE_EVENT lpEventTrack);
        [DllImport("user32.dll")]
        public static extern bool InvalidateRect(IntPtr hWnd, RECT lpRect, bool bErase);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool GetClientRect(IntPtr hWnd, out RECT lpRect);
        [DllImport("user32")]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);
        [DllImport("user32.dll")]
        public static extern int GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32.dll")]
        public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprc, IntPtr hrgn, int flags);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll")]
        public static extern int SetCursor(IntPtr cursorHandle);

        public static short Loword(this IntPtr value) => unchecked((short)value);
        public static short Hiword(this IntPtr value) => unchecked((short)((uint)value >> 16));
    }
}