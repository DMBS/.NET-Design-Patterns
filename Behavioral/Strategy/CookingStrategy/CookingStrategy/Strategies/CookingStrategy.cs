using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingStrategy
{
    public abstract class CookingStrategy
    {
        public abstract void Cook(string food);
    }
}
