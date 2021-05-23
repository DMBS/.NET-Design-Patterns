using System;

namespace LazySingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = Singleton.Instance;
            var s2 = Singleton.Instance;

            if (s1 == s2) { Console.WriteLine("Objects are the same instance"); }
            Console.ReadLine();
        }
    }
}
