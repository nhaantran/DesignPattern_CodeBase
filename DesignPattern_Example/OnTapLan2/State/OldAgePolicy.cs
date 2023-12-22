namespace DesignPattern_Example.OnTapLan2.State
{
    public class OldAgePolicy : AgePolicy
    {
        public override string DoEconomyPolicy()
        {
            return "Tăng cường các công việc gia đình, việc lao động nhẹ cho người già, hoạt động dịch vụ nhẹ";
        }

        public override string DoImprovePolicy()
        {
            return "Khuyến khích sinh con thêm Mở rộng tuổi hưu";
        }
    }
}
