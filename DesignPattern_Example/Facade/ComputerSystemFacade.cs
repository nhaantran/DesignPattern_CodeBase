using DesignPattern_Example.Facade.SubSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Facade;

public class ComputerSystemFacade
{
    public void LoginCompterSystem(string userName, string passWord, bool isBoot)
    {
        if (isBoot)
        {
            var bootInformation = BootSystem.BootCode();
            Console.WriteLine($"BootCode for something: {bootInformation}");
        }
        var authorizationSystem = new AuthorizationSystem();
        var authorizationReulst = authorizationSystem.DoSomething(userName, passWord);
        if (authorizationReulst)
        {
            CPU.Start();
        }
    }
}
