using DesignPattern_Example.FactoryMethod.HomeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.FactoryMethod.HomeWork.Model;

public class USA : INation
{
    public void CalculateNewKindOfTax()
    {
        Console.WriteLine("Calculate New Kind Of Tax for USA");
    }
    public void CalculateVAT()
    {
        Console.WriteLine("Calculate VAT for USA");
    }
}
