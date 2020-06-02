using AbstractFactory.AbstractFactory;
using AbstractFactory.Product;

namespace AbstractFactory.ConcreteFactory
{
    /// <summary>  
    /// The 'ConcreteFactory1' class.  
    /// </summary
    /// </summary>
    public class KawasakiFactory : IMotocycleFactory
    {
        public ICrossMotocycle GetCrossMotocycle()
        {
            return new KawasakiKx250();
        }

        public ISportMotocycle GetSportMotocycle()
        {
            return new KawasakiNinja();
        }
    }
}
