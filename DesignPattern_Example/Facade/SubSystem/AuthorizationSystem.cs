using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.Facade.SubSystem;

public class AuthorizationSystem
{
    public bool DoSomething(string username, string password) 
    {
        // do something
        if (!(username == null || password == null))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
