using System;

namespace Builder
{
    /// <summary>
    /// Client code
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var director = new BeverageDirector();
            var coffe = director.MakeBeverage(new CoffeBuilder());
            var tea = director.MakeBeverage(new TeaBuilder());

            Console.ReadKey();
        }
    }
}
