namespace DesignPattern_Example.OnTapLan2.State
{
    public class GoldAgePolicy : AgePolicy
    {
        public override string DoEconomyPolicy()
        {
            return "Tăng các ngành tiêu dùng, thương mại điện tử, công nghiệp nặng";
        }

        public override string DoImprovePolicy()
        {
            return "";
        }
    }
}
