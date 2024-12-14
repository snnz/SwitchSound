using System;

namespace SwitchSound
{
  [Flags]
  enum EDeviceState : uint
  {
    Active = 1,
    Disabled = 2,
    NotPresent = 4,
    Unplugged = 8,
    All = Active | Disabled | NotPresent | Unplugged
  }

  enum EDataFlow
  {
    Render,
    Capture,
    All
  }

  enum ERole
  {
    Console,
    Multimedia,
    Communications
  }

  enum StorageAccessMode : uint
  {
    Read,
    Write,
    ReadWrite
  }
}