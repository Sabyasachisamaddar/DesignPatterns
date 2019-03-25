using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BuilderPattern
{
    class BuilderPattern
    {
        public void ImplementPattern()
        {
            MenuDirector director = new MenuDirector();

            MenuBuilder builder1 = new BurgerMenuBuilder();
            director.Construct(builder1);
            Console.WriteLine("Menu is {0}", builder1.GetResult().ToString());

            MenuBuilder builder2 = new SaladMenuBuilder();
            director.Construct(builder2);
            Console.WriteLine("Menu is {0}", builder2.GetResult().ToString());

            MenuBuilder builder3 = new KidsMenuBuilder();
            director.Construct(builder3);
            Console.WriteLine("Menu is {0}", builder3.GetResult().ToString());
        }
    }
}

