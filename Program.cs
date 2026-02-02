using System;

namespace SwitchSound
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        var devices = (IMultimediaDeviceEnumerator)new MultimediaDeviceEnumerator();
        var defaultDevice = devices.GetDefaultAudioEndpoint(EDataFlow.Render, ERole.Multimedia);
        var defaultId = defaultDevice.Id;
        var defaultName = defaultDevice.Name();

        if (args.Length < 1)
          foreach (var device in devices.EnumAudioEndpoints(EDataFlow.Render, EDeviceState.Active).ToEnumerable())
          {
            var id = device.Id;
            var name = device.Name();
            Console.WriteLine("{0}{1}\n {2}\n", (id == defaultId || name == defaultName) ? "*" : " ", name, id);
          }
        else
        {
          var newDefault = args[0];
          if (newDefault == defaultId || newDefault == defaultName)
          {
            if (args.Length < 2) return;
            newDefault = args[1];
          }

          foreach (var device in devices.EnumAudioEndpoints(EDataFlow.Render, EDeviceState.Active).ToEnumerable())
          {
            var id = device.Id;
            if (id == newDefault || device.Name() == newDefault)
            {
              ((IPolicyConfig)new PolicyConfig()).SetDefaultEndpoint(id, ERole.Multimedia);
              break;
            }
          }
        }
      }
      catch (Exception e)
      {
        Console.Error.WriteLine(e.Message);
      }
    }
  }
}
