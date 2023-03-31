using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHouse
{
    public class Bidder
    {
        public Bidder(string name, double balance = 0)
        {
            this.name = name;
            this.balance = balance;
        }
        private string name;
        private double balance;
        private double authorizationHoldBalance = 0;
        public string Name { get { return name; } }
        public double Balance { get { return balance; } }
        public double AuthorizationHoldBalance { get { return authorizationHoldBalance; } }       
        
        public void TransferToAuthHoldBalance(double balance)
        {
            this.balance -= balance;
            authorizationHoldBalance += balance;
        }
        public void SuccessfulPurchase(double balance)
        {
            authorizationHoldBalance -= balance;
        }
        public void FailedPurchase(double balance)
        {
            authorizationHoldBalance -= balance;
            this.balance += balance;
        }
        public bool CheckBalanceForItem(double price)
        {
            return balance >= price;
        }
        public void AddBalance(double balance)
        {
            this.balance += balance;
        }
    }
}
