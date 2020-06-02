using AbstractFactory.AbstractFactory;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory
{
    /// <summary>  
    /// The 'ConcreteFactory2' class.  
    /// </summary>  
    public class HondaFactory : IMotocycleFactory
    {
        public ICrossMotocycle GetCrossMotocycle()
        {
            return new HondaCrf250();
        }

        public ISportMotocycle GetSportMotocycle()
        {
            return new HondaR1();
        }
    }
}
