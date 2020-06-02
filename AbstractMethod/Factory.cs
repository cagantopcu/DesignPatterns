using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Factory
    {
        public Motocycle CreateMotocycle()
        {
            return new Motocycle();
        }

        public IMotocycle CreateMotocycle(Type TBike)
        {
            IMotocycle bikeInstance = null;

            if (TBike == typeof(KawasakiMotocycle))
            {
                bikeInstance = new KawasakiMotocycle();
            }
            if (TBike == typeof(HondaMotocycle))
            {
                bikeInstance = new HondaMotocycle();
            }

            return bikeInstance;
        }
    }
}
