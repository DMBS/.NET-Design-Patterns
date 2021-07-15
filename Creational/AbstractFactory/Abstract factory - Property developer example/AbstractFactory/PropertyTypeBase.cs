using AbstractFactory.Helpers;
using System.Collections.Generic;

namespace AbstractFactory
{
    /// <summary>
    /// Base class of property type
    /// </summary>
    public abstract class PropertyTypeBase 
    {
        /// <summary>
        /// Property floors
        /// </summary>
        public abstract Dictionary<FloorsKey, int> Floors { get; }

        /// <summary>
        /// Property class
        /// </summary>
        public abstract PropertyClass PropertyClass { get; }

        /// <summary>
        /// Property lifetime
        /// </summary>
        public abstract int Lifetime { get; }
    }
}
