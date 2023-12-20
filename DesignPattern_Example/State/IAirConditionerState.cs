namespace DesignPattern_Example.State
{
    public abstract class IAirConditionerState
    {
        private AirConditioner _airConditioner { get; set; }
        private double _temp { get; set; }
        public abstract void OpenFan();
        public abstract void AdjustTemp();
        public abstract void CloseFan();
        public AirConditioner AirConditioner 
        {   get => _airConditioner;
            set => _airConditioner = value;
        }
        public double Temp
        {
            get => _temp;
            set => _temp = value;
        }
    }
}
