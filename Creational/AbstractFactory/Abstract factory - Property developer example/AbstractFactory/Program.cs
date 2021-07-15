using AbstractFactory.Helpers;
using System;

namespace AbstractFactory
{
    /// <summary>
    /// Client code
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var property = new Property
                (new SamoletPropertyDeveloperFactory(), PropertyType.Brick, FloorsKey.TounHouse);
            var propertyInfo = property.Summary();
            Console.WriteLine(propertyInfo);
            Console.ReadKey();
        }
    }
}
