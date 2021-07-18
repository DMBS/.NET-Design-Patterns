using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Creator' class
    /// This is an abstract class and declares the factory method, which returns an object of type Product. 
    /// </summary>
    public abstract class CardFactory
    {
        public abstract TinkoffDebitCard GetDebitCard();
    }
}
