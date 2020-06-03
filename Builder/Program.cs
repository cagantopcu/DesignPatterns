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
            MotocycleBuilder bikeBuilder = new MotocycleBuilder();
            bikeBuilder.SetBrake(new Brembo()).SetEngine(new SingleCylinder250cc()).SetTyre(new Pirelli());
            
            Motocycle bike = new Motocycle(bikeBuilder);

            Console.WriteLine("--- Bike 1 ---");
            Console.WriteLine(bike.GetTyre().GetBrandName());
            Console.WriteLine(bike.GetBrake().GetBrandName());
            Console.WriteLine(bike.GetEngine().GetBrandName());


            MotocycleBuilder bikeBuilder2 = new MotocycleBuilder();
            bikeBuilder2.SetBrake(new Brembo()).SetEngine(new Boxer1200cc()).SetTyre(new Bridgestone());

            Motocycle bike2 = new Motocycle(bikeBuilder2);

            Console.WriteLine("--- Bike 2 ---");
            Console.WriteLine(bike2.GetTyre().GetBrandName());
            Console.WriteLine(bike2.GetBrake().GetBrandName());
            Console.WriteLine(bike2.GetEngine().GetBrandName());
            
        }
    }
}
