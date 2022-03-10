using System;

namespace MemoryManipulator
{
    public enum WindowState { NORMAL, MINIMIZED, MAXIMIZED, OTHER }

    static class WindowStates
    {
        public static WindowState Get(IntPtr handle)
        {
            Win32.WINDOWPLACEMENT placement = new Win32.WINDOWPLACEMENT();
            Win32.GetWindowPlacement(handle, ref placement);

            switch (placement.showCmd)
            {
                case 1:
                    return WindowState.NORMAL;
                case 2:
                    return WindowState.MINIMIZED;
                case 3:
                    return WindowState.MAXIMIZED;
                default:
                    break;
            }

            return WindowState.OTHER;
        }
    }
}
