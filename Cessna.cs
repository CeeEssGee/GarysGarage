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
            Console.WriteLine($"The {this.MainColor} Cessna flashes by you like a hurricane. Zoooooom!");
        }

        public override void Turn()
        {
            System.Console.WriteLine($"The {this.MainColor} Cessna banks right.");
        }

        public override void Stop()
        {
            System.Console.WriteLine($"The {this.MainColor} Cessna rolls down the runway before coming to a stop.");
        }
    }
}