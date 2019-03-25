using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AbstractFactoryPattern
{
    class AustraliaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Dingo();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Kangaroo();
        }
    }
}
