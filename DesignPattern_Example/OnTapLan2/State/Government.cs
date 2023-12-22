namespace DesignPattern_Example.OnTapLan2.State
{
    public class Government
    {
        public AgePolicy AgePolicy { get; set;}
        private readonly int _year;

        public Government(int year)
        {
            AgePolicy = new GoldAgePolicy();
            _year = year;
        }

        public void PrintEconomyAndImprovePolicyTillYearX(int yearX)
        {
            var time = yearX - _year;
            AgePolicy.CalculateProp(time);
            Console.WriteLine($"Our policy are: {AgePolicy.DoEconomyPolicy()}");
            Console.WriteLine($"Our policy are: {AgePolicy.DoImprovePolicy}");
        }
    }
}
