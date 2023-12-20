using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Example.State
{
    public class HotState : IAirConditionerState
    {
        public HotState(double temp, AirConditioner airconditioner) 
        {
            this.Temp = temp;
            this.AirConditioner = airconditioner;
        }
        //public void SetAirConditioner(AirConditioner airConditioner)
        //{
        //    _airConditioner = airConditioner;
        //}
        public override void AdjustTemp()
        {
            Console.WriteLine($"[Hot] Temp before adjust: {this.Temp}");
            while (Temp >= 30)
            {
                Temp --;
            };
            Console.WriteLine($"[Hot] Temp after adjust: {this.Temp}");


        }

        public override void CloseFan()
        {
            Temp += 5;
        }

        public override void OpenFan()
        {
            Temp -= 5;
            if(Temp < 30)
            {
                AirConditioner.ChangeState(new BalanceState(this.Temp, this.AirConditioner));
            }
        }
    }
}
