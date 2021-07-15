using AbstractFactory.Helpers;
using System.Collections.Generic;

namespace AbstractFactory
{
    /// <summary>
    /// Class - brick property
    /// </summary>
    public class BrickProperty : PropertyTypeBase
    {
        public override Dictionary<FloorsKey, int> Floors
        {
            get
            {
                return new Dictionary<FloorsKey, int> { {FloorsKey.TounHouse, 2}, { FloorsKey.Duplex, 2 }, { FloorsKey.Regular, 5 } };
            }
        }
        public override PropertyClass PropertyClass
        {
            get
            {
                return PropertyClass.Elite;
            }
        }
        public override int Lifetime
        {
            get
            {
                return 150;
            }
        }
    }
}
