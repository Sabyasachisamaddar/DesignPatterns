using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class Duck : Toy
    {
        public override ConsoleColor GetColor()
        {
            return ConsoleColor.DarkYellow;
        }

        public override TimeSpan GetHeatingTime()
        {
            return TimeSpan.FromMinutes(3);
        }

        public override int GetPowderQuantity()
        {
            return 5;
        }
    }
}
