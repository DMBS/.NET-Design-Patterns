using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var preOrder = new PreOrder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice());
            Console.WriteLine();

            var premiumPreorder = new PremiumPreorder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice());

        }
    }
}
