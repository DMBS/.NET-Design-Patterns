using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    // Fabric of Fabrics
    class Program
    {
        static void Main(string[] args)
        {
            ICarsFactory factory1 = new ToyotaFactory();
            factory1.CreateSedan();
            factory1.CreateCoupe();
            ICarsFactory factory2 = new FordFactory();
            factory2.CreateSedan();
            factory2.CreateCoupe();
            Console.ReadLine();
        }
    }
}
