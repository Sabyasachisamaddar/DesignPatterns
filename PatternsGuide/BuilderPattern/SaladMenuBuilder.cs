using System;
using System.Collections.Generic;
using System.Text;

namespace PatternsGuide.BuilderPattern
{
    class SaladMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
            _menu.Add("Salad");
        }

        public override void BuildDesert()
        {
            _menu.Add("Ice Cream");
        }

        public override void BuildDrink()
        {
            _menu.Add("Coke");
        }

        public override void BuildFries()
        {
            _menu.Add("Fries");
        }

        public override void BuildToy()
        {
            //throw new NotImplementedException();
        }

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}
