using AbstractFactory.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Product
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class KawasakiNinja : ISportMotocycle
    {
        public string GetModel()
        {
            return "KawasakiNinja";
        }
    }
}
