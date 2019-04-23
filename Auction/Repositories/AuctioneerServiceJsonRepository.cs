using Auction.BL.Models;
using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    class AuctioneerServiceJsonRepository : IAuctioneerService
    {
        HashSet<AuctioneerModel> auctioneers;

        public AuctioneerServiceJsonRepository()
        {
            auctioneers = new HashSet<AuctioneerModel>(new AuctioneerModelComparer());

        }

        public bool LoginAuctioneer(AuctioneerModel auctioneerModel)
        {
            throw new NotImplementedException();
        }

        public AuctioneerModel RegisterAuctioneer(AuctioneerModel auctioneerModel)
        {
            throw new NotImplementedException();
        }
    }
}
