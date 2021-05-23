using CookingStrategy.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CookingContext();

            Console.WriteLine("What kind of food do you want to cook?");
            var food = Console.ReadLine();
            context.SetFood(food);

            Console.WriteLine("What is the strategy do you want to choose for cooking (1 - BoiledStrategy, 2 - GrillStrategy, 3 - BakedStrategy)");
            var key = Console.ReadLine();
            int strategyKey = int.Parse(key.ToString());

            switch (strategyKey)
            {
                case 1:
                    context.SetStrategy(new BoiledStrategy());
                    context.CookWithMe();
                    break;
                case 2:
                    context.SetStrategy(new GrillStrategy());
                    context.CookWithMe();
                    break;
                case 3:
                    context.SetStrategy(new BakedStrategy());
                    context.CookWithMe();
                    break;
                default:
                    Console.WriteLine("Your strategy key is wrong. Please try it again");
                    break;
            }
        }
    }
}
