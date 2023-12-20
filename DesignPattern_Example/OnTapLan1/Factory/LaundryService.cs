namespace DesignPattern_Example.OnTapLan1.Factory
{
    public class LaundryService : IService
    {
        private double Weights { get; set; }
        private double PricePerWeight { get; set; }

        public string CalculateFee()
        {
            return $"Weights: {Weights} * PricePerWeight: {PricePerWeight}";
        }
    }
}
