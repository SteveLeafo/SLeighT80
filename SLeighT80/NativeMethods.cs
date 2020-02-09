using System;
using System.Runtime.InteropServices;
using System.Text;

namespace SLeighT80
{
    class NativeMethods
    {
        // Sound api functions
        [DllImport("winmm.dll", CharSet = CharSet.Unicode)]
        internal  static extern Int32 mciSendString(string command,
             [MarshalAs(UnmanagedType.LPWStr)]  StringBuilder buffer, 
            int bufferSize, IntPtr hwndCallback);

    }
}
