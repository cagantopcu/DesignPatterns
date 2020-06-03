using Builder.Brake;
using Builder.Engine;
using Builder.Tyre;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IMotocycle bike = new Motocycle();
            bike.BuildTyre(new Pirelli());
            bike.BuildEngine(new SingleCylinder250cc());
            bike.BuildBrake(new Brembo());

            Console.WriteLine("--- 1 ---");
            Console.WriteLine(bike.GetTyre().GetBrandName());
            Console.WriteLine(bike.GetBrake().GetBrandName());
            Console.WriteLine(bike.GetEngine().GetBrandName());


            IMotocycle bikeTwo = new Motocycle();
            bikeTwo.BuildTyre(new Bridgestone());
            bikeTwo.BuildEngine(new Boxer1200cc());
            bikeTwo.BuildBrake(new Brembo());

            Console.WriteLine("--- 2 ---");
            Console.WriteLine(bikeTwo.GetTyre().GetBrandName());
            Console.WriteLine(bikeTwo.GetBrake().GetBrandName());
            Console.WriteLine(bikeTwo.GetEngine().GetBrandName());

        }
    }
}
