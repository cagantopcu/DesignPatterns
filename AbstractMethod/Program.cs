using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory factoryMethod = new Factory();
            //Motocycle bike = factoryMethod.CreateMotocycle();
            //string bikeBrand = bike.Brand;
            //Console.WriteLine(bikeBrand);

            Factory factoryMethod = new Factory();
            IMotocycle bike = factoryMethod.CreateMotocycle(typeof(HondaMotocycle));
            string bikeBrand = bike.Brand;
            Console.WriteLine(bikeBrand);

        }

    }
}
