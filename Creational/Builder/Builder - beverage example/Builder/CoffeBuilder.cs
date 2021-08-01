using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Concreate builder' class
    /// </summary>
    public class CoffeBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            GetBeverage().BeverageName = "Coffe";
        }

        public override void SetMilk()
        {
            GetBeverage().Milk = 45;
        }

        public override void SetPowder()
        {
            GetBeverage().Powder = 20;
        }

        public override void SetSugar()
        {
            GetBeverage().Sugar = 35;
        }

        public override void SetWater()
        {
            GetBeverage().Water = 200;
        }
    }
}
