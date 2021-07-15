using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Base district class fo the futere property
    /// </summary>
    public abstract class BaseLocation
    {
        /// <summary>
        /// District name
        /// </summary>
        public abstract string TerritoryName { get; }

        /// <summary>
        /// District size
        /// </summary>
        public abstract double TerritorySize { get; }

        /// <summary>
        /// The level of a district infrastructure
        /// </summary>
        public abstract InfrastructureLevel InfrastructureLevel { get; }
    }
}
