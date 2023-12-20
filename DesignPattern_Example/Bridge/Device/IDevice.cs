using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Bridge.Device;

public interface IDevice
{
    public void Enable();
    public int GetVolumn();
    public void SetVolumn(int volumn);
    public int GetChannel();
    public void SetChannel(int channel);
}
