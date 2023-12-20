namespace DesignPattern_Example.Homework512.Decorator
{
    // Concrete Component
    public class FeeService : IFeeService
    {
        private readonly Student _student;
        public double TilteDiscountRatio { get; set; }
        public double ConditionDiscountRatio { get; set; }

        public FeeService(Student student)
        {
            _student = student;
        }

        public double CalculateManualFee()
        {
            var fee = _student.Fee;
            return fee.FeePerCredit * fee.NumberOfCredits * (1 - DiscountRatio());
        }

        public double DiscountRatio()
        {
            return TilteDiscountRatio + ConditionDiscountRatio;
        }
    }
}
