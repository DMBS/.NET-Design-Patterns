using FactoryMethod.Helpers;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Concrete' TinkoffAllGames product 
    /// </summary>
    public class TinkoffAllGames : TinkoffDebitCard
    {
        public override PaymentSystem PaymentSystem
        {
            get
            {
                return PaymentSystem.VISA;
            }
        }
        public override ClassType ClassType
        {
            get
            {
                return ClassType.Classic;
            }
        }
        public override double PercentOnTheBalance
        {
            get
            {
                return 4D;
            }
        }
        public override decimal Maintenance
        {
            get
            {
                return 99M;
            }
        }
    }
}
