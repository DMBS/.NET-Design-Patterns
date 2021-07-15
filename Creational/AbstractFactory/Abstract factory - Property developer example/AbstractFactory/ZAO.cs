using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Class ZAO district
    /// </summary>
    public class ZAO : BaseLocation
    {
        public override string TerritoryName { get; } = "ZAO - west administrative district";
        public override double TerritorySize { get; } = 153.0343;
        public override InfrastructureLevel InfrastructureLevel { get; } = InfrastructureLevel.Medium;
    }
}
