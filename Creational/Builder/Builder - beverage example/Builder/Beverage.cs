using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    /// <summary>
    /// The 'Product' class
    /// </summary>
    public class Beverage
    {
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int Water { get; set; }
        public int Powder { get; set; }
        public string BeverageName { get; set; }

    }
}
