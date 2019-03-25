using System;

namespace PatternsGuide.AbstractFactoryPattern
{
    internal class Lion : Carnivore
    {
        public override void Eat(Herbivore hervivore)
        {
            Console.WriteLine("{0} eats {1}", this.GetType().Name, hervivore.GetType().Name);
        }
    }
}