using System;
using System.Runtime.InteropServices;

namespace SwitchSound
{
  [StructLayout(LayoutKind.Sequential)]
  struct PropVariant
  {
    short vt;
    short wReserved1;
    short wReserved2;
    short wReserved3;
    IntPtr LPWSTR;

    public string AsString => (VarEnum)vt == VarEnum.VT_LPWSTR ? Marshal.PtrToStringUni(LPWSTR) : null;
  }
}