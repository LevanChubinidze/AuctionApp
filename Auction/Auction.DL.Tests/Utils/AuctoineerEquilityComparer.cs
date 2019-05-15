using Auction.BL.Models;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Tests.Utils
{
    struct AuctoineerEquilityComparer : IEqualityComparer<Auctioneer>
    {
        public bool Equals(Auctioneer x, Auctioneer y)
        {
            return
                   x.FirstName == y.FirstName
                && x.LastName == y.LastName
                && x.UserName == y.UserName
                && x.Password == y.Password
                && x.IsAdmin == y.IsAdmin;
        }

        public int GetHashCode(Auctioneer obj)
        {
            return obj.Id;
        }
    }

    struct AuctoineerModelEquilityComparer : IEqualityComparer<AuctioneerModel>
    {
        public bool Equals(AuctioneerModel x, AuctioneerModel y)
        {
            return
                 x.FirstName == y.FirstName
              && x.LastName == y.LastName
              && x.UserName == y.UserName
              && x.Password == y.Password
              && x.IsAdmin == y.IsAdmin;
        }

        public int GetHashCode(AuctioneerModel obj)
        {
            return obj.Id;
        }
    }
}
