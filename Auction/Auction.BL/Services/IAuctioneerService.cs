using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    public interface IAuctioneerService
    {
        AuctioneerModel RegisterAuctioneer(AuctioneerModel auctioneerModel);
        AuctioneerModel LoginAuctioneer(AuctioneerModel auctioneerModel);
    }
}
