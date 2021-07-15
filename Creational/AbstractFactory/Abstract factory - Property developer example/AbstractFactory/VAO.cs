using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Class VAO district
    /// </summary>
    public class VAO : BaseLocation
    {
        public override string TerritoryName { get; } = "VAO - east administrative district";
        public override double TerritorySize { get; } = 154.8355;
        public override InfrastructureLevel InfrastructureLevel { get; } = InfrastructureLevel.Low;
    }
}
