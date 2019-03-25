using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BuilderPattern
{
    class KidsMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
            _menu.Add("Burger");           
        }

        public override void BuildDesert()
        {
            _menu.Add("Ice Cream");
        }

        public override void BuildDrink()
        {
            
        }

        public override void BuildFries()
        {
            _menu.Add("Fries");
        }

        public override void BuildToy()
        {
            _menu.Add("Toy");
        }

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}
