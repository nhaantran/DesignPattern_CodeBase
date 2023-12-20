namespace DesignPattern_Example.Homework512.Decorator
{
    public abstract class FeeDecorator : IFeeService
    {
        protected IFeeService IFeeService { get; set; }
        protected FeeDecorator(IFeeService iFeeService)
        {
            IFeeService = iFeeService;
        }
        public double CalculateManualFee()
        {
            return IFeeService.CalculateManualFee();
        }

        public double DiscountRatio()
        {
            return IFeeService.DiscountRatio();
        }
        public abstract double CalculateDiscountRatio();
    }
}
