using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public enum CreditCardType{
        Bronze,
        Silver,
        Gold
    }
    public abstract class AbstractCreditCard
    {
        protected User user;
        public CreditCardType creditCardType;
        public AbstractCreditCard(User user)
        {
            this.user = user;
        }
        public abstract void Payment();
    }
    public class BronzeCreditCard : AbstractCreditCard
    {
        public BronzeCreditCard(User user) : base(user)
        {
            creditCardType = CreditCardType.Bronze;
        }

        public override void Payment()
        {
            Console.WriteLine("10% Cut-off on the product");
        }
    }
    public class SilverCreditCard : AbstractCreditCard
    {
        public SilverCreditCard(User user) : base(user)
        { 
            creditCardType= CreditCardType.Silver;
        }

        public override void Payment()
        {
            Console.WriteLine("20% Cut-off on the product");
        }
    }
    public class GoldCreditCard : AbstractCreditCard
    {
        public GoldCreditCard(User user) : base(user)
        {
            creditCardType = CreditCardType.Gold;
        }

        public override void Payment()
        {
            Console.WriteLine("30% Cut-off on the product");
        }
    }
}
