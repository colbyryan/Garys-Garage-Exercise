using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine("The Burgundy Tesla Blazes by you. Zzzmmmmmm");
        }

        public override void Stop()
        {
            Console.WriteLine("The Burgundy Tesla silently stops as if it never moved.");
        }
    }
}
