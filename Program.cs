using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelY = new Tesla();
            Cessna mx410 = new Cessna();
            Ram pickup = new Ram();


            fxs.MainColor = "Black";
            modelY.MainColor = "Blue";
            mx410.MainColor = "White";
            pickup.MainColor = "Red";

            fxs.MaximumOccupancy = 2;
            modelY.MaximumOccupancy = 5;
            mx410.MaximumOccupancy = 3;
            pickup.MaximumOccupancy = 4;

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelY.Drive();
            modelY.Turn();
            modelY.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            pickup.Drive();
            pickup.Turn();
            pickup.Stop();

        }
    }
}