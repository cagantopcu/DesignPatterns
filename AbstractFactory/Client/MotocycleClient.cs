using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Client
{
    /// <summary>
    /// The 'Client' class.
    /// </summary>
    public class MotocycleClient
    {
        ICrossMotocycle crossMotocycle;
        ISportMotocycle sportMotocycle;

        public MotocycleClient(IMotocycleFactory factory)
        {
            crossMotocycle = factory.GetCrossMotocycle();
            sportMotocycle = factory.GetSportMotocycle();
        }

        public string GetSportMotocycleModel()
        {
            return crossMotocycle.GetModel();
        }

        public string GetCrossMotocycleModel()
        {
            return sportMotocycle.GetModel();
        }

    }
}
