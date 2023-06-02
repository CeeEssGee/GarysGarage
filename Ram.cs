using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram growls by you. Rrrrrruuummmbbblllle!");
        }

        public override void Turn()
        {
            System.Console.WriteLine($"The {this.MainColor} Ram slowly turns right.");
        }

        public override void Stop()
        {
            System.Console.WriteLine($"The {this.MainColor} Ram eases to a stop.");
        }
    }
}