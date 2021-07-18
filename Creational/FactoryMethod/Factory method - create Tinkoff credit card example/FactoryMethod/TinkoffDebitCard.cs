using FactoryMethod.Helpers;
using System;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Product' abstract class
    /// </summary>
    public abstract class TinkoffDebitCard
    {
        /// <summary>
        /// Type of payment system
        /// </summary>
        public abstract PaymentSystem PaymentSystem { get; }

        /// <summary>
        /// Class of the debit card
        /// </summary>
        public abstract ClassType ClassType { get; }

        /// <summary>
        /// Percent on the balance in debit card
        /// </summary>
        public abstract double PercentOnTheBalance { get; }

        /// <summary>
        /// The debit card maintenance
        /// </summary>
        public abstract decimal Maintenance { get; }

        public virtual void ShowGeneralInformation()
        {
            Console.WriteLine($"We realesed a Tinkoff debit card.'\nYour debit card payment system is - '{PaymentSystem}'\n" +
                $"Your debit card class type is - '{ClassType}'\nThe percent of the balance on your type of debit card is - '{PercentOnTheBalance}' %\n" +
                $"The price for the maintenance of your debit card is {Maintenance} RUB ");
            Console.ReadLine();
        }

    }
}
