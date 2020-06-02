using AbstractFactory.AbstractFactory;
using AbstractFactory.Client;
using AbstractFactory.ConcreteFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- Honda -");
            IMotocycleFactory hondaMotocycle= new HondaFactory();
            MotocycleClient hondaMotocycleClient = new MotocycleClient(hondaMotocycle);
            Console.WriteLine(hondaMotocycleClient.GetCrossMotocycleModel());
            Console.WriteLine(hondaMotocycleClient.GetSportMotocycleModel());


            Console.WriteLine("- Kawasaki -");
            IMotocycleFactory kawasakiMotocycle = new KawasakiFactory();
            MotocycleClient kawasakiMotocycleClient = new MotocycleClient(kawasakiMotocycle);
            Console.WriteLine(kawasakiMotocycleClient.GetCrossMotocycleModel());
            Console.WriteLine(kawasakiMotocycleClient.GetSportMotocycleModel());

        }
    }
}
