namespace FactoryMethod
{
    /// <summary>
    /// The 'Concrete creator' class
    /// This may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    /// </summary>
    public class TinkoffBlackFactory : CardFactory
    {
        public override TinkoffDebitCard GetDebitCard()
        {
            return new TinkoffBlack();
        }
    }
}
