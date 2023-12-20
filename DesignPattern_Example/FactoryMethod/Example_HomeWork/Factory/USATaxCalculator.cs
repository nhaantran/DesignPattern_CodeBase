using DesignPattern_Example.FactoryMethod.HomeWork.Interface;
using DesignPattern_Example.FactoryMethod.HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.FactoryMethod.HomeWork.Factory;

internal class USATaxCalculator : TaxFactoryCalculator
{
    public override INation Nation()
    {
        return new USA();
    }
}
