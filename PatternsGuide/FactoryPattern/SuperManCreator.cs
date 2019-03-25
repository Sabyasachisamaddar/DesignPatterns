using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class SuperManCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new SuperMan();
        }
    }
}
