using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.State
{
    public class BalanceState : IAirConditionerState
    {
        public BalanceState(double temp, AirConditioner airConditioner) 
        {
            this.Temp = temp;
            this.AirConditioner = airConditioner;
        }
        public override void AdjustTemp()
        {
            Console.WriteLine($"[Balance] Temp before adjust: {this.Temp}");
            while(Temp > 24)
            {
                Temp--;
            };
            while(Temp < 24)
            {
                Temp++;
            };
            Console.WriteLine($"[Balance] Temp after adjust: {this.Temp}");
        }

        public override void CloseFan()
        {
            Temp += 6;
            if (Temp >= 30)
            {
                AirConditioner.ChangeState(new HotState(this.Temp, this.AirConditioner));
            }
        }

        public override void OpenFan()
        {
            Temp --;
        }
    }
}
