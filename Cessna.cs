using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine("The White Cessna flases by you like a hurricane. ZzzzzzOoooom");
        }
        public override void Stop()
        {
            Console.WriteLine("The Cessna Rolls down the runway for a mile and stops.");
        }
    }
}
