using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.FactoryPattern
{
    class DuckCreator : ToyCreator
    {
        protected override Toy CreateToy()
        {
            return new Duck();
        }
    }
}
