using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AbstractFactoryPattern
{
    class EcoSystem
    {
        private readonly Herbivore _herbivore;
        private readonly Carnivore _carnivore;

        public EcoSystem(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void Run()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
