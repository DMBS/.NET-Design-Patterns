using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingStrategy.Context
{
    public class CookingContext
    {
        private CookingStrategy _cookingStrategy;

        public string Food { get; set; }

        /// <summary>
        /// Ctor
        /// </summary>
        public CookingContext()
        { }

        public void SetFood (string nameOfFood)
        {
            Food = nameOfFood;
        }

        public void SetStrategy (CookingStrategy cookingStrategy)
        {
            _cookingStrategy = cookingStrategy;
        }

        public void CookWithMe()
        {
            _cookingStrategy.Cook(Food);
            Console.WriteLine("Your dish with selected cooking strategies is already finished");
        }

    }
}
