using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorThroughIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = GenerateFibonaci();
        }

        public static IEnumerable<int> GenerateFibonaci()
        {
            int prev = 0;
            int current = 1;

            while (true)
            {
                yield return current;

                int tmp = current;
                current = prev + current;
                prev = tmp;
            }
        }
    }
}
