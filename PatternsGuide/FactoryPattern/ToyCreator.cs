using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    abstract class ToyCreator
    {
        protected abstract Toy CreateToy();

        public void MakeToy()
        {
            Toy toy = CreateToy();
            int grams = toy.GetPowderQuantity();
            preparePowder(grams);
            selectMold(toy);
            injectPowder(grams);
            TimeSpan heatingTime = toy.GetHeatingTime();
            heatMold(heatingTime);
            extractToy();
            ConsoleColor color = toy.GetColor();
            paintToy(color);
        }

        private void paintToy(ConsoleColor color)
        {
            Console.WriteLine("Painting the Toy in {0} color",color);
        }

        private void extractToy()
        {
            Console.WriteLine("Extracting the Toy");
        }

        private void heatMold(TimeSpan heatingTime)
        {
            Console.WriteLine("Heating till {0} time", heatingTime);
        }

        private void injectPowder(int grams)
        {
            Console.WriteLine("Injecting {0} grams of powder", grams);
        }

        private void selectMold(Toy toy)
        {
            Console.WriteLine("Selecting mold {0}", toy.GetType().Name);
        }

        private void preparePowder(int grams)
        {
            Console.WriteLine("Preparing {0} grams of Powder", grams);
        }
    }
}
