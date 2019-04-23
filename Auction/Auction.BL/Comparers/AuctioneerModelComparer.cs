using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Comparers
{
    class AuctioneerModelComparer : IEqualityComparer<AuctioneerModel>
    {
        public bool Equals(AuctioneerModel x, AuctioneerModel y)
        {
            return x.UserName == y.UserName;
        }

        public int GetHashCode(AuctioneerModel obj)
        {
            return obj.UserName.Length;
        }
    }
}
