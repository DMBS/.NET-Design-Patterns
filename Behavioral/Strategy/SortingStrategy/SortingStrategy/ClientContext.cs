using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    /// <summary>
    /// Client side that provide sort - strategy
    /// </summary>
    public class ClientContext
    {
        private ISort<int[]> _strategy;

        /// <summary>
        /// Ctor
        /// </summary>
        public ClientContext()
        { }

        /// <summary>
        /// Set strategy
        /// </summary>
        /// <param name="strategy"></param>
        public void SetStrategy(ISort<int[]> strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Do some sorting work
        /// </summary>
        /// <returns></returns>
        public int[] DoWork()
        {
            var sortedArray = _strategy.Sort(new int[] { 1, 34, 56, 77, 23, 10, 55} );
            return sortedArray;
        }
    }
}
