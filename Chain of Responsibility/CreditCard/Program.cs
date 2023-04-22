using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractShoppingHandler bronzeHanlder = new BronzeShoppingHandler();
            AbstractShoppingHandler silverHanlder = new SilverShoppingHandler();
            AbstractShoppingHandler goldHandler = new GoldShoppingHandler();

            bronzeHanlder.SetNextHandler(silverHanlder);
            silverHanlder.SetNextHandler(goldHandler);

            User user1 = new User("Demetre", CreditCardType.Bronze);
            User user2 = new User("Giorgi", CreditCardType.Silver);
            User user3 = new User("Avto", CreditCardType.Gold);

            bronzeHanlder.Handler(user3);
            bronzeHanlder.Handler(user1);
            bronzeHanlder.Handler(user2);

            Console.ReadLine();
        }
    }
}



