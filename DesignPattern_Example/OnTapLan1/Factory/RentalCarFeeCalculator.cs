using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.OnTapLan1.Factory
{
    public class RentalCarFeeCalculator : FeeCalculatorService
    {
        public override string CalculateMethod()
        {
            return new RentalCarSercice().CalculateFee();
        }
    }
}