using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Product
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class HondaCrf250 : ICrossMotocycle
    {
        public string GetModel()
        {
            return "HondaCrf250";
        }
    }
}
