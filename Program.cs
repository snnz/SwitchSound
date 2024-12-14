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
        var default_id = devices.GetDefaultAudioEndpoint(EDataFlow.Render, ERole.Multimedia).Id;

        if (args.Length < 1)
          foreach (var device in devices.EnumAudioEndpoints(EDataFlow.Render, EDeviceState.Active).ToEnumerable())
          {
            var id = device.Id;
            Console.WriteLine("{0}{1}\n {2}\n", id == default_id ? "*" : " ", device.Name(), id);
          }
        else
        {
          var new_default_id = args[0];
          if (new_default_id == default_id)
          {
            if (args.Length < 2) return;
            new_default_id = args[1];
          }
          ((IPolicyConfig)new PolicyConfig()).SetDefaultEndpoint(new_default_id, ERole.Multimedia);
        }
      }
      catch (Exception e)
      {
        Console.Error.WriteLine(e.Message);
      }
    }
  }
}
