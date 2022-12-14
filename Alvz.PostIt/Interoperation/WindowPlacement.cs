using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Alvz.PostIt.Interoperation
{
    [Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct WINDOWPLACEMENT
    {
        public int Length;
        public int Flags;
        public int ShowCmd;
        public POINT MinPosition;
        public POINT MaxPosition;
        public RECT Rect;
    }
}
