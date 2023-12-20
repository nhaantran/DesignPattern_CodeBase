using DesignPattern_Example.Bridge.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Bridge.Remote;

public class RadioRemote : RemoteControl
{
    public RadioRemote(IDevice device) : base(device)
    {
    }

    public override void ChannelUp()
    {
        this._device.SetChannel(this._device.GetChannel() + 5);
    }
}
