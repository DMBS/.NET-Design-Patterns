using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AF
{
    public class ToyotaFactory : ICarsFactory
    {
        public ICoupe CreateCoupe()
        {
            return new ToyotaCoupe();
        }

        public ISedan CreateSedan()
        {
            return new ToyotaSedan();
        }

        public IUniversal CreateUniversal()
        {
            return new ToyotaUniversal();
        }
    }
}
