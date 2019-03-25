using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.AbstractFactoryPattern
{
    public class AbstractFactoryPattern
    {
        public void ImplementPattern()
        {
            var factory1 = new AfricaFactory();
            var ecoSystem1 = new EcoSystem(factory1);
            ecoSystem1.Run();

            var factory2 = new AustraliaFactory();
            var ecoSystem2 = new EcoSystem(factory2);
            ecoSystem2.Run();
        }
    }
}
