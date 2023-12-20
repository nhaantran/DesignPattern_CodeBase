namespace DesignPattern_Example.OnTapLan1.Factory
{
    public class RentalCarSercice : IService
    {
        private double Hours { get; set; }
        private double PricePerHour { get; set; }

        public string CalculateFee()
        {
            return $"Hours: {Hours} * PricePerHour: {PricePerHour}";
        }
    }
}
