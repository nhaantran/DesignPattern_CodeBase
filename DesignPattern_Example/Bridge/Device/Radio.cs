using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Bridge.Device;

public class Radio : IDevice
{
    private bool Status;
    private int Channel;
    private int Volumn;

    public Radio(bool status, int channel, int volumn)
    {
        Status = status;
        Channel = channel;
        Volumn = volumn;
    }
    public void Enable()
    {
        this.Status = true;
    }
    public int GetChannel()
    {
        return this.Channel;
    }

    public int GetVolumn()
    {
        return this.Volumn;
    }
    public void SetChannel(int channel)
    {
        this.Channel = channel > 0 ? channel : 1;
    }
    public void SetVolumn(int volumn)
    {
        this.Volumn= volumn;
    }
}
