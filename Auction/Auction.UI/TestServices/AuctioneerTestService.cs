using Auction.BL.Models;
using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.UI.TestServices
{
     public class AuctioneerTestService : IAuctioneerService
    {
        static List<AuctioneerModel> auctioneers = new List<AuctioneerModel>
        {
            new AuctioneerModel
            {
                Id = 1,
                FirstName = "მალხაზა",
                LastName= "მალხაზიშვილი",
                UserName = "malxaza123",
                Password = "1234",
                IsAdmin = false,
            },
             new AuctioneerModel
            {
                Id = 2,
                FirstName = "ჯემალა",
                LastName= "ბაღაშვილი",
                UserName = "jemala123",
                Password = "1234",
                IsAdmin = false,
             },
              new AuctioneerModel
              {
                  Id = 3,
                  FirstName = "მიხა",
                LastName= "მიხაშვილი",
                UserName = "mixa123",
                Password = "1234",
                IsAdmin = false,
              }
        };

        public async Task<AuctioneerModel> EditAuctioneer(AuctioneerModel auctioneerModel)
        {
            var auctioneer = auctioneers.FirstOrDefault(a => a.Id == auctioneerModel.Id);
            auctioneer.FirstName = auctioneerModel.FirstName;
            auctioneer.LastName = auctioneerModel.LastName;
            auctioneer.Password = auctioneerModel.Password;

            return auctioneer;
        }

        public async Task<IEnumerable<AuctioneerModel>> GetAuctioneers()
        {
            return auctioneers;
        }

        public async Task<AuctioneerModel> LoginAuctioneer(AuctioneerModel auctioneerModel)
        {
            throw new NotImplementedException();
        }

        public async Task<AuctioneerModel> RegisterAuctioneer(AuctioneerModel auctioneerModel)
        {
            if (auctioneers.Any(a => a.UserName == auctioneerModel.UserName))
                return null;
            else
            {
                auctioneers.Add(auctioneerModel);
                return auctioneerModel;
            }
        }

        public Task<AuctioneerModel> RemoveAuctioneer(AuctioneerModel auctioneerModel)
        {
            throw new NotImplementedException();
        }
    }
}
