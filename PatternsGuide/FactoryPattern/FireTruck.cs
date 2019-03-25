using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class FireTruck : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkRed;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(2);
        }

        public override int GetPowderQuantity()
        {
            return 20;
        }
    }
}
