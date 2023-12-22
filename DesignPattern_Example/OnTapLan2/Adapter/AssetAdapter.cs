namespace DesignPattern_Example.OnTapLan2.Adapter
{
    public class AssetAdapter : IValuableItem
    {
        private readonly Asset _asset;
        public AssetAdapter(Asset asset)
        {
            _asset = asset;
        }
        public double CalculateValue(int year)
        {
            double depreciation = Math.Pow((1 - _asset.DepreciationRate), (year - _asset.OwnershipDate.Year));
            return _asset.Value * depreciation;
        }
    }
}
