using System.Runtime.InteropServices;

namespace SwitchSound
{
  [Guid("A95664D2-9614-4F35-A746-DE8DB63617E6")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  interface IMultimediaDeviceEnumerator
  {
    IMultimediaDeviceCollection EnumAudioEndpoints(EDataFlow dataFlow, EDeviceState stateMask);
    IMultimediaDevice GetDefaultAudioEndpoint(EDataFlow dataFlow, ERole role);
  }

  [ComImport, Guid("BCDE0395-E52F-467C-8E3D-C4579291692E")]
  class MultimediaDeviceEnumerator
  {
  }
}
