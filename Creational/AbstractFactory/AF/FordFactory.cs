using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    public class FordFactory : ICarsFactory
    {
        public ICoupe CreateCoupe()
        {
            return new FordCoupe();
        }

        public ISedan CreateSedan()
        {
            return new FordSedan();
        }

        public IUniversal CreateUniversal()
        {
            return new FordUniversal();
        }
    }
}
