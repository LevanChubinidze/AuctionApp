using Auction.BL.Models;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Tests.Utils
{
    internal static class AuctioneerExtentions
    {
        public static bool IsEqualTo(this Auctioneer @this, Auctioneer auctioneer)
        {
            return
                  @this.FirstName == auctioneer.FirstName
               && @this.LastName == auctioneer.LastName
               && @this.UserName == auctioneer.UserName
               && @this.Password == auctioneer.Password
               && @this.IsAdmin  == auctioneer.IsAdmin;
        }

        public static bool IsEqualTo(this AuctioneerModel @this, AuctioneerModel auctioneer)
        {
            return
                  @this.FirstName == auctioneer.FirstName
               && @this.LastName == auctioneer.LastName
               && @this.UserName == auctioneer.UserName
               && @this.Password == auctioneer.Password
               && @this.IsAdmin == auctioneer.IsAdmin;
        }

        public static bool IsEqualTo(this AuctioneerModel @this, Auctioneer auctioneer)
        {
            return
                  @this.FirstName == auctioneer.FirstName
               && @this.LastName == auctioneer.LastName
               && @this.UserName == auctioneer.UserName
               && @this.Password == auctioneer.Password
               && @this.IsAdmin == auctioneer.IsAdmin;
        }

        public static bool IsEqualTo(this Auctioneer @this, AuctioneerModel auctioneer)
        {
            return auctioneer.IsEqualTo(@this);
        }

    }
}
