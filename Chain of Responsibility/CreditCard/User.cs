using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    public class User
    {
        public string name;
        public AbstractCreditCard creditCard;
        public User(string name, CreditCardType creditCardType)
        {
            this.name = name;
            if(creditCardType == CreditCardType.Bronze)
            {
                creditCard = new BronzeCreditCard(this);
            }
            else if(creditCardType == CreditCardType.Silver)
            {
                creditCard = new SilverCreditCard(this);
            }
            else
            {
                creditCard= new GoldCreditCard(this);
            }
        }
    }
}
