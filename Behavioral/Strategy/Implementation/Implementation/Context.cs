using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
    public class Context
    {
        private IStrategy _strategy;

        /// <summary>
        /// Ctor
        /// </summary>
        public Context()
        { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });
            string resultStr = string.Empty;
            foreach (var element  in result as List<string>)
            {
                resultStr += element + ",";
            }
            Console.WriteLine(resultStr);
        }
    }
}
