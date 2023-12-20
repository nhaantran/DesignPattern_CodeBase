namespace DesignPattern_Example.OnTapLan1.Factory
{
    public class LaundryFeeCalculator : FeeCalculatorService
    {
        public override string CalculateMethod()
        {
            return new LaundryService().CalculateFee();
        }
    }
}
