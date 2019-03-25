using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AbstractFactoryPattern
{
   abstract  class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }
}
