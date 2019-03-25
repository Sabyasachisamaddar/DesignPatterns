using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    abstract class Toy
    {
        public abstract int GetPowderQuantity();
        public abstract TimeSpan GetHeatingTime();
        public abstract ConsoleColor GetColor();
    }
}
