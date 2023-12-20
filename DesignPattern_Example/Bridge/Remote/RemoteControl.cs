using DesignPattern_Example.Bridge.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Bridge.Remote;

public abstract class RemoteControl
{
    protected IDevice _device;

    protected RemoteControl(IDevice device)
    {
        _device = device;
    }
    public virtual void GetResultForDemo() 
    {
        Console.WriteLine("Current Channel: "+this._device.GetChannel());
        Console.WriteLine("Current Volumn: "+this._device.GetVolumn());
        Console.ReadLine(); 
    }
    public virtual void TogglePower() 
    {
        this._device.Enable();
    }
    public virtual void VolumnDown() 
    {
        this._device.SetVolumn(_device.GetVolumn() - 1);
    }
    public virtual void ChannelUp() 
    {
        this._device.SetChannel(_device.GetChannel() + 1);
    }
}
