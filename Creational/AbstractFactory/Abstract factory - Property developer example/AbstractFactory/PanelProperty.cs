using AbstractFactory.Helpers;
using System.Collections.Generic;

namespace AbstractFactory
{
    /// <summary>
    /// Class - panel property
    /// </summary>
    public class PanelProperty : PropertyTypeBase
    {
        public override Dictionary<FloorsKey, int> Floors
        {
            get
            {
                return new Dictionary<FloorsKey, int> { { FloorsKey.Hrushevka, 5 }, { FloorsKey.Sovetskii, 9 }, { FloorsKey.Modern, 9 } };
            }
        }
        public override PropertyClass PropertyClass
        {
            get
            {
                return PropertyClass.Econom;
            }
        }
        public override int Lifetime
        {
            get
            {
                return 50;
            }
        }
    }
}
