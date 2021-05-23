using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = new Collection();
            collection[0] = new Item("Item0");
            collection[1] = new Item("Item1");
            collection[2] = new Item("Item2");
            collection[3] = new Item("Item3");
            collection[4] = new Item("Item4");
            collection[5] = new Item("Item5");
            collection[6] = new Item("Item6");
            collection[7] = new Item("Item7");
            collection[8] = new Item("Item8");
            collection[9] = new Item("Item9");

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 2;

            Console.WriteLine("Iterating over collection:");

            for(Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
