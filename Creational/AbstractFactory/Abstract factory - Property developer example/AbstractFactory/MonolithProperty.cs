using AbstractFactory.Helpers;
using System.Collections.Generic;

namespace AbstractFactory
{
    /// <summary>
    /// Class - monolith property
    /// </summary>
    public class MonolithProperty : PropertyTypeBase
    {
        public override Dictionary<FloorsKey, int> Floors
        {
            get
            {
                return new Dictionary<FloorsKey, int> { { FloorsKey.Simple, 9 }, { FloorsKey.Europe, 22 }, { FloorsKey.Tower, 30 } };
            }
        }
        public override PropertyClass PropertyClass
        {
            get
            {
                return PropertyClass.Comfort;
            }
        }
        public override int Lifetime
        {
            get
            {
                return 100;
            }
        }
    }
}
