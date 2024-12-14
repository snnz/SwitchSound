using System;
using System.Runtime.InteropServices;

namespace SwitchSound
{
  [Guid("D666063F-1587-4E43-81F1-B948E807363F")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  interface IMultimediaDevice
  {
    void Activate();
    IPropertyStore OpenPropertyStore(StorageAccessMode accessMode);
    string Id { [return : MarshalAs(UnmanagedType.LPWStr)] get; }
  }

  static class MultimediaDevice
  {
    static PropertyKey PKEY_DEVICE_FRIENDLY_NAME = new PropertyKey(new Guid("A45C254E-DF1C-4EFD-8020-67D146A850E0"), 14);
    public static string Name(this IMultimediaDevice device) => device.OpenPropertyStore(StorageAccessMode.Read).GetValue(ref PKEY_DEVICE_FRIENDLY_NAME).AsString;
  }
}