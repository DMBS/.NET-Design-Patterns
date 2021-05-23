using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ClientContext();
            var timer = new Stopwatch();

            timer.Start();
            context.SetStrategy(new SelectionSort());
            var selectionArrayResult = context.DoWork();
            timer.Stop();
            Console.WriteLine("Selection sorting/ Execution time: {0}ms", timer.ElapsedMilliseconds);
            selectionArrayResult.ToList().ForEach(item => Console.WriteLine(item.ToString()));

            timer.Start();
            context.SetStrategy(new BubbleSort());
            var bubbleArrayResult = context.DoWork();
            timer.Stop();
            Console.WriteLine("Bubble sorting:/ Execution time: {0}ms", timer.ElapsedMilliseconds);
            bubbleArrayResult.ToList().ForEach(item => Console.WriteLine(item.ToString()));

            Console.ReadLine();
        }
    }
}
