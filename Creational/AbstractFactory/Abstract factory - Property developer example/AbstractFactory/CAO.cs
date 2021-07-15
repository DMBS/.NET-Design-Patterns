using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Class CAO district
    /// </summary>
    public class CAO : BaseLocation
    {
        public override string TerritoryName { get; } = "CAO - central administrative district";
        public override double TerritorySize { get; } = 153.0343;
        public override InfrastructureLevel InfrastructureLevel { get; } = InfrastructureLevel.High;
    }
}
