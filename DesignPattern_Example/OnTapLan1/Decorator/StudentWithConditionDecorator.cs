namespace DesignPattern_Example.Homework512.Decorator
{
    public class StudentWithConditionDecorator : FeeDecorator
    {
        protected Condition condition = new();

        public StudentWithConditionDecorator(IFeeService iFeeService) : base(iFeeService)
        {
        }

        public void AddConditon(Condition condition)
        {
            this.condition = condition;
        }

        public override double CalculateDiscountRatio()
        {
            double discountFee = 0.0;
            switch (condition)
            {
                case Condition.Poor:
                    discountFee = 0.8;
                    break;
                case Condition.NearPoor:
                    discountFee = 0.5;
                    break;
                default:
                    break;
            }
            return discountFee;
        }
    }
}
