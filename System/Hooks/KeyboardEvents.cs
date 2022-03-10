
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MemoryManipulator
{
    class KeyboardEvents
    {
        private struct Flags
        {
            public const int WM_KEYDOWN = 0x0100,
                WH_KEYBOARD_LL = 13;
        }

        // Hook - Refrences
        private static IntPtr hookID = IntPtr.Zero;
        private static Win32.LowLevelKeyboardProc cachedCallback = HookCallback;

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (Program.overlay.visible)
            {
                // Only process key events while overlay is visible, thus target window is focused
                if (nCode >= 0 && wParam == (IntPtr)Flags.WM_KEYDOWN)
                {
                    if (Program.IsLoaded && Handle((Keys)Marshal.ReadInt32(lParam)))
                        // Consume event - prevents input in game
                        return (IntPtr)1;
                }
            }

            return Win32.CallNextHookEx(hookID, nCode, wParam, lParam);
        }
        private static bool Handle(Keys key)
        {
            Manipulation manipulation;
            Color color;
            int choice;

            // Handle key press
            switch (key)
            {
                case Keys.NumPad1:
                    // Toggle 'Edit Player'
                    choice = 0;
                    break;
                case Keys.NumPad2:
                    // Toggle 'Edit Item'
                    choice = 1;
                    break;
                case Keys.NumPad3:
                    // Toggle 'Edit NPC'
                    choice = 2;
                    break;
                default:
                    return false;
            }

            manipulation = Program.manipulations[choice];
            color = manipulation.enabled ? Color.Black : Color.White;

            // Apply color to label and toggle memory byte manipulation
            if (manipulation.Toggle())
                Program.overlay.ColorLabel(color, choice);

            return true;
        }

        // Hook
        // - Management
        public void Start()
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                hookID = Win32.SetWindowsHookEx(Flags.WH_KEYBOARD_LL, cachedCallback, Win32.GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        public void Stop()
        {
            Win32.UnhookWindowsHookEx(hookID);
        }
    }
}
