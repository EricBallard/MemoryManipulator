using System;
namespace MemoryManipulator
{
    class WindowEvents
    {

        private struct WinEvent
        {
            public const uint EVENT_SYSTEM_FOREGROUND = 0x0003,
            EVENT_SYSTEM_MOVESIZESTART = 0x000A,
            EVENT_SYSTEM_MOVESIZEEND = 0x000B,
            EVENT_SYSTEM_MINIMIZESTART = 0x0016,
            EVENT_SYSTEM_MINIMIZEEND = 0x0017,
            EVENT_OBJECT_LOCATIONCHANGE = 0x800B;
        }

        const string targetName = "Terraria: Manipulated!", overlayName = "MemoryManipulator (1.0)";

        private IntPtr hookID = IntPtr.Zero;

        // Need to ensure delegate is not collected while we're using it,
        // storing it in a class field is simplest way to do this.
        Win32.WinEventDelegate procDelegate = new Win32.WinEventDelegate(WinEventProc);

        public void Start()
        {
            hookID = Win32.SetWinEventHook(WinEvent.EVENT_SYSTEM_FOREGROUND, WinEvent.EVENT_OBJECT_LOCATIONCHANGE, IntPtr.Zero, procDelegate, 0, 0, 0);
        }

        public void Stop()
        {
            Win32.UnhookWinEvent(hookID);
        }

        private static void WinEventProc(IntPtr hWinEventHook, uint eventType,
            IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
        {

            switch (eventType)
            {
                case WinEvent.EVENT_SYSTEM_MINIMIZESTART:
                    // Start of minimize window - a focus window event will fire after

                    Minimize(hwnd);
                    break;
                case WinEvent.EVENT_SYSTEM_MINIMIZEEND:
                    // Start of restore (un-minimzed) window
                    Minimize(hwnd);
                    break;
                case WinEvent.EVENT_SYSTEM_FOREGROUND:
                    // Focus window has changed
                    Focus(hwnd);
                    break;
                case WinEvent.EVENT_SYSTEM_MOVESIZESTART:
                case WinEvent.EVENT_SYSTEM_MOVESIZEEND:
                    // Start/End of window move or resize
                    MoveAndSize(hwnd);
                    break;
                case WinEvent.EVENT_OBJECT_LOCATIONCHANGE:
                    if (Program.overlay.visible)
                    {
                        string title = Win32.GetWindowTitle(hwnd);

                        switch (title)
                        {
                            case targetName:
                                break;
                            default:
                                return;
                        }

                        // Game has been toggled to/from windowed/maximized windowed
                        WindowState state = WindowStates.Get(hwnd);

                        // User has restored game window - we have seperate func for minimize, so lets not interfer with it
                        if (Program.overlay.windowState != WindowState.MINIMIZED)
                            Program.overlay.SizeToTarget();

                        // Update overlay with our current state
                        Program.overlay.windowState = state;
                    }
                    break;
                default:
                    return;
            }
        }

        // Handle unique events
        private static void Minimize(IntPtr handle)
        {
            if (Program.overlay.visible)
            {
                // Hide overlay when user minimizes game window
                Program.overlay.Toggle();
            }
            else if (Win32.GetWindowTitle(handle).Equals(targetName))
            {
                // Show overlay when users restores game window
                Program.overlay.Toggle();
                Program.overlay.SizeToTarget();
            }
        }
        private static void Focus(IntPtr handle)
        {
            string title = Win32.GetWindowTitle(handle);

            if (Program.overlay.visible)
            {

                // Overlay is visible - did user focus another window?
                switch (title)
                {
                    // Ignore target windows
                    case overlayName:
                    case targetName:
                        return;
                    default:
                        // User is focusing another window - hide overlay
                        Program.overlay.Toggle();
                        break;
                }
            }
            else
            {
                // Overlay not visible - should we show it?
                switch (title)
                {
                    case overlayName:
                        // Overlay will temporarily grab focus - ignore this
                        return;
                    case targetName:
                        // User is focusing target game - show overlay
                        Program.overlay.Toggle();
                        break;
                }
            }
        }

        private static bool startOfMove = false;
        private static void MoveAndSize(IntPtr handle)
        {
            if (Program.overlay.visible)
            {
                // Verify user is moving game window
                if (Win32.GetWindowTitle(handle).Equals(targetName))
                {
                    // Hide
                    startOfMove = !startOfMove;
                    Program.overlay.Toggle();
                }
            }
            else if (startOfMove)
            {
                // Update overlay bounds
                Program.overlay.SizeToTarget();

                // Show
                startOfMove = !startOfMove;
                Program.overlay.Toggle();
            }
        }
    }
}
