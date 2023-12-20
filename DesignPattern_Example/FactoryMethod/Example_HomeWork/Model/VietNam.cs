using DesignPattern_Example.FactoryMethod.HomeWork.Interface;

namespace DesignPattern_Example.FactoryMethod.HomeWork.Model;

public class VietNam : INation
{
    public void CalculateNewKindOfTax()
    {
        Console.WriteLine("Calculate New Kind Of Tax for Viet Nam");
    }

    public void CalculateVAT()
    {
        Console.WriteLine("Calculate VAT for Viet Nam");
    }
}