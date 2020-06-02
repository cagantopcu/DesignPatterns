using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Product
{
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class KawasakiKx250 : ICrossMotocycle
    {
        public string GetModel()
        {
            return "KawasakiKx250";
        }
    }
}
