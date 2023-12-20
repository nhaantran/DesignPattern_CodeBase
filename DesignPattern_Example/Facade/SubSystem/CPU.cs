using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Facade.SubSystem;

public static class CPU
{
    public static void Start() 
    {
        Console.WriteLine("CPU is starting...");
    }
}
