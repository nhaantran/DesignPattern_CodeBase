
namespace DesignPattern_Example.OnTapLan1.Factory
{
    public class PrintingService : IService
    {
        private double Pages { get; set; }
        private double PricePerPage { get; set; }

        public string CalculateFee()
        {
            return $"Pages: {Pages} * PricePerPage: {PricePerPage}";
        }
    }
}
