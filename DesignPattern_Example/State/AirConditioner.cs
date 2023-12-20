namespace DesignPattern_Example.State
{
    public class AirConditioner
    {
        private IAirConditionerState _airConditionerState { get; set; }
        public AirConditioner(double temp)
        {
            this._airConditionerState = new BalanceState(temp, this);
        }
        public void OpenFan()
        {
            _airConditionerState.OpenFan();
        }
        public void CloseFan()
        {
            _airConditionerState.CloseFan();
        }
        public void AdjustTemp()
        {
            _airConditionerState.AdjustTemp();
        }
        public void ChangeState(IAirConditionerState newState)
        {
            _airConditionerState = newState;
        }
    }
}
