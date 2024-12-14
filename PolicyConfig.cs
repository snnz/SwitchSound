using System;
using System.Runtime.InteropServices;

namespace SwitchSound
{
  [Guid("F8679F50-850A-41CF-9C72-430F290290C8")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  internal interface IPolicyConfig
  {
    void GetMixFormat();
    void GetDeviceFormat();
    void ResetDeviceFormat();
    void SetDeviceFormat();
    void GetProcessingPeriod();
    void SetProcessingPeriod();
    void GetShareMode();
    void SetShareMode();
    void GetPropertyValue();
    void SetPropertyValue();
    void SetDefaultEndpoint([MarshalAs(UnmanagedType.LPWStr)] string pszDeviceName, ERole role);
  }

  [ComImport, Guid("870AF99C-171D-4F9E-AF0D-E63DF40C2BC9")]
  class PolicyConfig
  {
  }
}