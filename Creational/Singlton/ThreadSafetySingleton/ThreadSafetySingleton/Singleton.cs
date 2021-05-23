using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafetySingleton
{
    public sealed class Singleton
    {
        /// <summary>
        /// Ctor
        /// </summary>
        private Singleton() { }

        private static readonly object _lock = new object();
        private static Singleton instance = null;

        public static Singleton Instance
        {
            get
            {
                lock (_lock)
                {
                    if(instance == null)
                    {
                        instance = new Singleton();
                    }

                    return instance;
                }
            }
        }
    }
}
