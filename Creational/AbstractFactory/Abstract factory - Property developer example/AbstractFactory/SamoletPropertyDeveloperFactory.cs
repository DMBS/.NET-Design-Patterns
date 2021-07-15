using AbstractFactory.Helpers;
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Class - SAMOLET property developer
    /// </summary>
    public class SamoletPropertyDeveloperFactory : PropertyDeveloperAbstractFactory
    {
        /// <summary>
        /// Property deeloper name
        /// </summary>
        public override string PropertyDeveloperName { get => "SAMOLET=>"; }
        /// <summary>
        /// Has bank accreditation?
        /// </summary>
        public override bool BankAccreditation { get => true; }
        /// <summary>
        /// Number of houses built 
        /// </summary>
        public override int BuiltPropertyCount { get => 10534; }

        /// <summary>
        /// Build property
        /// </summary>
        /// <param name="propertyType">property type</param>
        /// <returns>concrete property</returns>
        public override PropertyTypeBase BuildProperty(PropertyType propertyType)
        {
            if (PropertyType.Brick == propertyType)
                return new BrickProperty();

            else if (PropertyType.Monolith == propertyType)
                return new MonolithProperty();

            else 
                throw new Exception($"Unfortunately, the {PropertyDeveloperName} couldn't build this type of property");
        }

        /// <summary>
        /// Define property location
        /// </summary>
        /// <returns>concrete district</returns>
        public override BaseLocation DefiningTerritory()
        {
            return new ZAO();
        }
    }
}
