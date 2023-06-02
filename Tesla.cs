using System;

namespace Garage
{
    public class Tesla : Vehicle  // Electric car
    {
        public double BatteryKWh { get; set; }
        // public string MainColor { get; set; }
        // public int MaximumOccupancy { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }

        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla blazes by you. MMMmmmmmmmmmmm!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {this.MainColor} Tesla squeals around a right turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Tesla silently stops.");
        }
    }
}