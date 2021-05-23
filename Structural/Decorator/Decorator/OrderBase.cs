using System.Collections.Generic;

namespace Decorator
{
    public abstract class OrderBase
    {
        protected List<Product> products = new List<Product>
        {
            new Product {Name = "Phone", Price = 587},
            new Product {Name = "Tablet", Price = 800},
            new Product {Name = "PC", Price = 1000}
        };

        public abstract double CalculateTotalOrderPrice();
    }
}
