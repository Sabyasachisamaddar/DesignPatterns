using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class FireTruckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new FireTruck();
        }
    }
}
