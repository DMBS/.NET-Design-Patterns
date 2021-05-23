using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        // Mediator is a behavioral design pattern that reduces coupling between components of a program by making them communicate indirectly, 
        // through a special mediator object.
        // The Mediator makes it easy to modify, extend and reuse individual components because they’re no longer dependend of the dozens of other classes.
        static void Main(string[] args)
        {
            // The client code.
            Component1 component1 = new Component1();
            Component2 component2 = new Component2();
            new ConcreteMediator(component1, component2);

            Console.WriteLine("Client triggers operation A");
            component1.DoA();

            Console.WriteLine();

            Console.WriteLine("Client triggers operation D");
            component2.DoD();
            Console.ReadLine();

        }
    }
}
