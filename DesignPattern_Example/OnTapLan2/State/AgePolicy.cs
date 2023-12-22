namespace DesignPattern_Example.OnTapLan2.State
{
    public abstract class AgePolicy
    {
        protected Government Government;
        protected double _elderProp { get; set; }
        protected double _workerProp { get; set; }
        public abstract string DoEconomyPolicy();
        public abstract string DoImprovePolicy();
        public void CalculateProp(int years)
        {
            var rand = new Random();
            for (int numYear = 0; numYear < years; numYear++)
            {
                _workerProp += rand.Next(-3, 5);
                _elderProp += rand.Next(-2, 2);
            }
            StateChangeCheck();
        }
        protected void StateChangeCheck()
        {
            switch (_workerProp)
            {
                case <= 0.3:
                    Government.AgePolicy = new OldAgePolicy();
                    break;
                case > 0.3 and < 0.5:
                    if(_elderProp < 0.1)
                    {
                        Government.AgePolicy = new OldAgePolicy();
                    }
                    break;
                case >= 0.5:
                    Government.AgePolicy = new OldAgePolicy();
                    break;
                default:
                    break;
            }
        }
    }
}
