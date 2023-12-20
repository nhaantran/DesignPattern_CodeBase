using DesignPattern_Example.FactoryMethod.HomeWork.Interface;
using DesignPattern_Example.FactoryMethod.HomeWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.FactoryMethod.HomeWork.Factory;

public class VietNamTaxCalculator : TaxFactoryCalculator
{
    public override INation Nation()
    {
        return new VietNam();
    }
}
