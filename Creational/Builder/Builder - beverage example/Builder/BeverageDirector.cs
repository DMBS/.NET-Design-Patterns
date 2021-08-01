using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class BeverageDirector
    {
        public Beverage MakeBeverage (BeverageBuilder beverageBuilder)
        {
            beverageBuilder.CreateBeverage();
            beverageBuilder.SetBeverageType();
            beverageBuilder.SetMilk();
            beverageBuilder.SetPowder();
            beverageBuilder.SetSugar();
            beverageBuilder.SetWater();

            return beverageBuilder.GetBeverage();

        }
    }
}
