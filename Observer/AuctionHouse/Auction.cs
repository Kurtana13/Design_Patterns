using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AuctionHouse
{
    internal interface IAuction
    {
        void AddBidder(Bidder bidder,double bidPrice);
        void NotifyBidder(Bidder bidder,Bidder outBidder,double newPrice);
    }

    public class Auction : IAuction
    {
        public Bidder currBidder = null; //current bidder
        private readonly string itemName;
        private readonly double itemBasePrice;
        private double? itemBidPrice = null;
        public Auction(string itemName, double itemBasePrice)
        {
            this.itemName = itemName;
            this.itemBasePrice = itemBasePrice;
        }
        public string ItemName { get { return itemName; } }
        public double ItemBasePrice { get { return itemBasePrice; } }
        public double? ItemBidPrice { get { return itemBidPrice; } }
        public void AddBidder(Bidder bidder,double bidPrice)
        {
            if(itemBidPrice == null)
            {
                if (bidder.CheckBalanceForItem(bidPrice) && bidPrice > itemBasePrice)
                {
                    currBidder= bidder;
                    itemBidPrice = bidPrice;
                    Console.WriteLine($"{bidder.Name} has bidden {bidPrice} on {itemName}");
                    return;
                }
                Console.WriteLine($"{bidder.Name} - Not enough money on balance! or you didn't bid more than base price!");
            }
            else
            {
                if (bidder.CheckBalanceForItem(bidPrice) && bidPrice > itemBidPrice)
                {
                    Console.WriteLine($"{bidder.Name} has bidden {bidPrice} on {itemName}");
                    NotifyBidder(currBidder,bidder,bidPrice);
                    currBidder = bidder;
                    itemBidPrice = bidPrice;
                    return;
                }
                Console.WriteLine($"{bidder.Name} - Not enough money on balance! or you didn't bid more than top bidder!");
            }
        }

        public void NotifyBidder(Bidder bidder,Bidder outBidder, double newPrice)
        {
            bidder.FailedPurchase((double)itemBidPrice);
            bidder.AddBalance((double)itemBidPrice);
            Console.WriteLine($"{bidder.Name} has been outbidden by {outBidder.Name} and now the bid is {newPrice}");
        }

    }
}
