using System;

namespace FactoryMethod
{
    /// <summary>
    /// Client code
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CardFactory factory = null;
            Console.Write("Enter the debit card name you would like to release (Black / ALLGames): ");
            string clientInput = Console.ReadLine();

            switch (clientInput.ToLower())
            {
                case "black":
                    factory = new TinkoffBlackFactory();
                    break;
                case "allgames":
                    factory = new TinkoffAllGamesFactory();
                    break;
                default:
                    break;
            }

            var debitCard = factory.GetDebitCard();
            debitCard.ShowGeneralInformation();
        }
    }
}
