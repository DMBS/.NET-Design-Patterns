using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    /// <summary>
    /// Strategy interface
    /// </summary>
    public interface ISort<T>
    {
        int[] Sort(T array);
    }
}
