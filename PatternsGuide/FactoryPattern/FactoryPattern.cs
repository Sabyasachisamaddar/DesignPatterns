using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class FactoryPattern
    {
        public void ImplementPattern()
        {
            ToyCreator creator = null;

            Console.WriteLine("Creating a FireTruck toy");
            creator = new FireTruckCreator();
            creator.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating a SuperMan toy");
            creator = new SuperManCreator();
            creator.MakeToy();
            Console.WriteLine();

            Console.WriteLine("Creating a Duck toy");
            creator = new DuckCreator();
            creator.MakeToy();
            Console.WriteLine();
        }
    }
}
