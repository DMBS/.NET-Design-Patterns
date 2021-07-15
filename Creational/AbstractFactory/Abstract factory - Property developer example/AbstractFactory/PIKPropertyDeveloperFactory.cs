using AbstractFactory.Helpers;
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Class - PIK property developer
    /// </summary>
    public class PIKPropertyDeveloperFactory : PropertyDeveloperAbstractFactory
    {
        /// <summary>
        /// Property deeloper name
        /// </summary>
        public override string PropertyDeveloperName { get => "PIK Inc---"; }
        /// <summary>
        /// Has bank accreditation?
        /// </summary>
        public override bool BankAccreditation { get => false; }
        /// <summary>
        /// Number of houses built 
        /// </summary>
        public override int BuiltPropertyCount { get => 578; }

        /// <summary>
        /// Build property
        /// </summary>
        /// <param name="propertyType">property type</param>
        /// <returns>concrete property</returns>
        public override PropertyTypeBase BuildProperty(PropertyType propertyType)
        {
            if (PropertyType.Panel == propertyType)
                return new PanelProperty();

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
            return new VAO();
        }
    }
}
