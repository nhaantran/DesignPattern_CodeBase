namespace DesignPattern_Example.Homework512.Decorator
{
    public class StudentWithTitlesDecorator : FeeDecorator
    {
        protected readonly List<Title> titles = new();
        public StudentWithTitlesDecorator(IFeeService iFeeService) : base(iFeeService)
        {
        }

        public override double CalculateDiscountRatio()
        {
            double? titleFee;
            double discountFee = 0.0;
            foreach (var title in titles)
            {
                switch (title)
                {
                    case Title.TOT:
                        titleFee = 0.15;
                        break;
                    case Title.XuatXacNamHoc:
                        titleFee = 0.1;
                        break;
                    case Title.CongHien:
                        titleFee = 0.08;
                        break;
                    default:
                        titleFee = 0.0;
                        break;
                }
                if (titleFee > discountFee || discountFee == 0.0)
                {
                    discountFee = (double)titleFee;
                }
            }
            return discountFee;
        }
        public void AddTitles(List<Title> titles)
        {
            if (titles.Count > 0)
            {
                this.titles.AddRange(titles);
            }

        }
    }
}
