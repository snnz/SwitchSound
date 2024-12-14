using System.Runtime.InteropServices;

namespace SwitchSound
{
  [Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  interface IPropertyStore
  {
    void GetCount();
    void GetAt();
    PropVariant GetValue(ref PropertyKey propertyKey);
  }
}