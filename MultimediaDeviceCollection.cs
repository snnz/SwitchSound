using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SwitchSound
{
  [Guid("0BD7A1BE-7A1A-44DB-8397-CC5392387B5E")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  interface IMultimediaDeviceCollection
  {
    uint Count { get; }
    IMultimediaDevice this[uint index] { get; }
  }

  static class MultimediaDeviceCollection
  {
    public static IEnumerable<IMultimediaDevice> ToEnumerable(this IMultimediaDeviceCollection collection)
    {
      for (uint i = 0, n = collection.Count; i < n; ++i)
        yield return collection[i];
    }
  }
}