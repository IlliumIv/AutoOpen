﻿using System.Runtime.InteropServices;
using System.Threading;
using SharpDX;

namespace AutoOpen.Utils
{
    internal class Mouse
    {
        public enum MouseEvents
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010
        }

        public const int DELAY_MOVE = 5;
        public const int DELAY_CLICK = 5;

        [DllImport("user32.dll")]
        public static extern bool SetCursorPos(int x, int y);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        public static Point GetCursorPosition()
        {
            GetCursorPos(out Point lpPoint);

            return lpPoint;
        }

        [DllImport("user32.dll")]
        private static extern void Mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool BlockInput(bool block);


        public static void MoveMouse(Vector2 pos)
        {
            SetCursorPos((int) pos.X, (int) pos.Y);
            Thread.Sleep(DELAY_MOVE);
        }

        public static void LeftDown(int delay)
        {
            Mouse_event((int) MouseEvents.LeftDown, 0, 0, 0, 0);
            Thread.Sleep(DELAY_CLICK + delay);
        }

        public static void LeftUp(int delay)
        {
            Mouse_event((int) MouseEvents.LeftUp, 0, 0, 0, 0);
            Thread.Sleep(DELAY_CLICK + delay);
        }

        public static void RightDown(int delay)
        {
            Mouse_event((int) MouseEvents.RightDown, 0, 0, 0, 0);
            Thread.Sleep(DELAY_CLICK + delay);
        }

        public static void RightUp(int delay)
        {
            Mouse_event((int) MouseEvents.RightUp, 0, 0, 0, 0);
            Thread.Sleep(DELAY_CLICK + delay);
        }

        public static void BlockInput_(bool block)
        {
            BlockInput(block);
        }
    }
}