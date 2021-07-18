using FactoryMethod.Helpers;

namespace FactoryMethod
{
    /// <summary>
    /// The 'Concrete' TinkoffBlack product 
    /// </summary>
    public class TinkoffBlack : TinkoffDebitCard
    {
        public override PaymentSystem PaymentSystem
        {
            get
            {
                return PaymentSystem.MASTERCARD;
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
                return 3.5D;
            }
        }
        public override decimal Maintenance
        {
            get
            {
                return 0M;
            }
        }
    }
}
