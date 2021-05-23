using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoThreadSafeSingleton
{
    public sealed class Singleton
    {
        /// <summary>
        /// Ctor
        /// </summary>
        private Singleton()
        {}

        private static Singleton instance = null;

        public static Singleton Instance
        {
            get
            {
                if (instance == null) { instance = new Singleton(); }
                return instance;
            }
        }
    }
}
