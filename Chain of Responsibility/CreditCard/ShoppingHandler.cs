using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public abstract class AbstractShoppingHandler
    {
        protected AbstractShoppingHandler nextHandler;
        public void SetNextHandler(AbstractShoppingHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }
        public abstract void Handler(User user);
    }

    public class BronzeShoppingHandler : AbstractShoppingHandler
    {
        public override void Handler(User user)
        {
            if(user.creditCard.creditCardType != CreditCardType.Bronze)
            {
                nextHandler.Handler(user);
                return;
            }
            user.creditCard.Payment();
        }
    }

    public class SilverShoppingHandler : AbstractShoppingHandler
    {
        public override void Handler(User user)
        {
            if (user.creditCard.creditCardType != CreditCardType.Silver)
            {
                nextHandler.Handler(user);
                return;
            }
            user.creditCard.Payment();
        }
    }

    public class GoldShoppingHandler : AbstractShoppingHandler
    {
        public override void Handler(User user)
        {
            if (user.creditCard.creditCardType != CreditCardType.Gold)
            {
                Console.WriteLine("Get a bronze card peasant!");
                return;
            }
            user.creditCard.Payment();
        }
    }
}
