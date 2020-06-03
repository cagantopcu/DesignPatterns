using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.Brake
{
    public class Brembo : IBrake
    {
        public string GetBrandName() => "Brembo";
    }
}
