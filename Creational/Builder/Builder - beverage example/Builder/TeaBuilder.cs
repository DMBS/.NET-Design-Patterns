using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Concreate builder' class
    /// </summary>
    public class TeaBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            GetBeverage().BeverageName = "Tea";
        }

        public override void SetMilk()
        {
            GetBeverage().Milk = 5;
        }

        public override void SetPowder()
        {
            GetBeverage().Powder = 1;
        }

        public override void SetSugar()
        {
            GetBeverage().Sugar = 50;
        }

        public override void SetWater()
        {
           GetBeverage().Water = 400;
        }
    }
}
