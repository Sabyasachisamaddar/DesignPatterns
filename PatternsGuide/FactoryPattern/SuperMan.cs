using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class SuperMan : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.Red;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(1);
        }

        public override int GetPowderQuantity()
        {
            return 10;
        }
    }
}
