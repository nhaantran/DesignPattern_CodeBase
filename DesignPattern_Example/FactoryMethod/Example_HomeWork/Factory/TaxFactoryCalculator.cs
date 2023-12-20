using DesignPattern_Example.FactoryMethod.HomeWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.FactoryMethod.HomeWork.Factory;

public abstract class TaxFactoryCalculator
{
    private INation SetUpNation() => Nation();
    public abstract INation Nation();
    public void CalculateVAT()
    {
        SetUpNation().CalculateVAT();
    }
    public void CalculateNewKindOfTax()
    {
        SetUpNation().CalculateNewKindOfTax();
    }
}
