using AbstractFactory.Helpers;

namespace AbstractFactory
{
    /// <summary>
    /// Class of property (home) that will come out of any factory. (Specific product) 
    /// </summary>
    public class Property
    {
        private PropertyTypeBase _propertyType;
        private string _propertyDeveloperName;
        private BaseLocation _baseLocation;
        private FloorsKey _floorsKey;


        /// <summary>
        /// Property class
        /// </summary>
        public PropertyClass PropertyClass { get => _propertyType.PropertyClass; }

        /// <summary>
        /// Property floors
        /// </summary>
        public int Floors { get => GetPropertyFloors(); }

        /// <summary>
        /// The name of the property developer
        /// </summary>
        public string PropertyDeveloperName { get => _propertyDeveloperName; }

        /// <summary>
        /// Property district
        /// </summary>
        public string District { get => _baseLocation.TerritoryName; }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="factory">concrete factory</param>
        public Property(PropertyDeveloperAbstractFactory factory, PropertyType propertyType, FloorsKey floorsKey)
        {
            _propertyDeveloperName = factory.PropertyDeveloperName;
            _propertyType = factory.BuildProperty(propertyType);
            _baseLocation = factory.DefiningTerritory();
            _floorsKey = floorsKey;
        }

        /// <summary>
        /// Get property floors
        /// </summary>
        public int GetPropertyFloors()
        {
            return _propertyType.Floors[_floorsKey];
        }
        
        /// <summary>
        /// Get overall property information
        /// </summary>
        /// <returns>overall information about property</returns>
        public string Summary() 
        {
            return
                $"Your property has class - '{PropertyClass}'\nYour property developer - '{PropertyDeveloperName}'\n" +
                $"Your district name - '{District}'\nThe height of the building - '{Floors}' floors ";
        }
    }
}
