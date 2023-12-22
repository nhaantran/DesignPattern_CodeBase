namespace DesignPattern_Example.OnTapLan2.Adapter
{
    public class IntellectualPropertyAdapter : IValuableItem
    {
        private readonly IntellectualProperty _intellectualProperty;

        public IntellectualPropertyAdapter(IntellectualProperty intellectualProperty)
        {
            _intellectualProperty = intellectualProperty;
        }

        public double CalculateValue(int year)
        {
            if (year >= _intellectualProperty.PublishYear)
            {
                return _intellectualProperty.InfluenceScore * 10000000 * (year - _intellectualProperty.PublishYear);
            }
            return 0.0;
        }
    }
}
