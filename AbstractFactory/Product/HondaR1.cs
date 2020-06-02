using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Product
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class HondaR1 : ISportMotocycle
    {
        public string GetModel()
        {
            return "HondaR1";
        }
    }
}
