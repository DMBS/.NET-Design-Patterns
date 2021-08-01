using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Builder' class
    /// </summary>
    public abstract class BeverageBuilder
    {
        protected Beverage beverage;
        public abstract void SetBeverageType();
        public abstract void SetWater();
        public abstract void SetSugar();
        public abstract void SetMilk();
        public abstract void SetPowder();

        public void CreateBeverage()
        {
            beverage = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return beverage;
        }


    }
}
