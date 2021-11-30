using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram truck = new Ram();

            truck.Drive();
            truck.Turn("Left");
            truck.Stop();
            Console.WriteLine();

            fxs.Drive();
            fxs.Turn("Right");
            fxs.Stop();
            Console.WriteLine();

            modelS.Drive();
            modelS.Turn("Left");
            modelS.Stop();
            Console.WriteLine();

            mx410.Drive();
            mx410.Turn("Right");
            mx410.Stop();

        }
    }
}
