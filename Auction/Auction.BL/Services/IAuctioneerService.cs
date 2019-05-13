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
        Task<AuctioneerModel> RegisterAuctioneer(AuctioneerModel auctioneerModel);
        Task<AuctioneerModel> LoginAuctioneer(AuctioneerModel auctioneerModel);
        Task<IEnumerable<AuctioneerModel>> GetAuctioneers();
        Task<AuctioneerModel> EditAuctioneer(AuctioneerModel auctioneerModel);
    }
}
