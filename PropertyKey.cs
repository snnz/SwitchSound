using System;
using System.Runtime.InteropServices;

namespace SwitchSound
{
  [StructLayout(LayoutKind.Sequential)]
  struct PropertyKey
  {
    public Guid FormatId;
    public uint PropertyId;

    public PropertyKey(Guid formatId, uint propertyId)
    {
      FormatId = formatId;
      PropertyId = propertyId;
    }
  }
}