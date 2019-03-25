using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BuilderPattern
{
    class MenuDirector
    {
        public void Construct(MenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDesert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}
