using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Saba Kurtanidze
namespace AuctionHouse
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Auction auction1 = new Auction("PC", 1500);
            Bidder bidder1 = new Bidder("Giorgi", 2000);
            Bidder bidder2 = new Bidder("Demetre", 3000);
            Bidder bidder3 = new Bidder("Avto", 4000);

            auction1.AddBidder(bidder1, 1550);
            auction1.AddBidder(bidder2, 1600);
            auction1.AddBidder(bidder3, 1500);
            Console.Read();
        }
    }
}
