using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Property developer factory base class
    /// </summary>
    public abstract class PropertyDeveloperAbstractFactory
    {
        /// <summary>
        /// Property developer name
        /// </summary>
        /// 
        public abstract string PropertyDeveloperName { get; }
        /// <summary>
        /// Has bank accreditation?
        /// </summary>
        public abstract bool BankAccreditation { get; }

        /// <summary>
        /// Number of houses built 
        /// </summary>
        public abstract int BuiltPropertyCount { get; }

        /// <summary>
        /// Define property location
        /// </summary>
        /// <returns>concrete district</returns>
        public abstract BaseLocation DefiningTerritory();

        /// <summary>
        /// Build property
        /// </summary>
        /// <param name="propertyType">property type</param>
        /// <returns>concrete property</returns>
        public abstract PropertyTypeBase BuildProperty(PropertyType propertyType);
    }
}
