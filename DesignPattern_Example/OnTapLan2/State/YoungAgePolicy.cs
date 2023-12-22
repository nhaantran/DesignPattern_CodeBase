namespace DesignPattern_Example.OnTapLan2.State
{
    public class YoungAgePolicy : AgePolicy
    {
        public override string DoEconomyPolicy()
        {
            return "Phát triển các dịch vụ giáo dục, vui chơi, giải trí";
        }
        public override string DoImprovePolicy()
        {
            return "Mở rộng độ tuổi lao động thấp hơn";
        }
    }
}
