using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.AbstractFactory
{
    public interface IMotocycleFactory
    {
        /// <summary>  
        /// The 'AbstractFactory' interface.  
        /// </summary>  
        ICrossMotocycle GetCrossMotocycle();
        ISportMotocycle GetSportMotocycle();
    }
}
