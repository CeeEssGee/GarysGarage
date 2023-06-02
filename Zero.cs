using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
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
            Console.WriteLine($"The {this.MainColor} Zero zips by you. Yeeeeeooooowwww!");
        }

        public override void Turn()
        {
            Console.WriteLine($"The {this.MainColor} Zero banks to turn right.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Zero screeches to a stop.");
        }
    }
}