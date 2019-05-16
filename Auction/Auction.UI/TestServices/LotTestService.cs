using Auction.BL.Models;
using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.UI.TestServices
{

    public class LotTestService : ILotService
    {
        static List<LotModel> lots = new List<LotModel>
        {
            new LotModel
            {
                Id = 1,
                Name = "ლოტი N1",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            },
            new LotModel
            {
                Id = 2,
                Name = "ლოტი N2",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            },
              new LotModel
            {
                Id = 3,
                Name = "ლოტი N3",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            }
        };

        public async Task< LotModel> AddLot(LotModel lot)
        {
            if (lots.Any(a => a.Id == lot.Id) || lots.Any(a => a.Name == lot.Name) || lots.Any(a => a.AuctionDate == lot.AuctionDate))
                return null;
            else
            {
                lots.Add(lot);
                return lot;
            }
        }
        public async Task< LotModel> EditLot(LotModel lot)
        {
            var Lot = lots.FirstOrDefault(a => a.Id == lot.Id);
            Lot.Name = lot.Name;
            Lot.Description = lot.Description;
            Lot.Quantity = lot.Quantity;
            Lot.Unit = lot.Unit;
            Lot.StartingPrice = lot.StartingPrice;
            Lot.MinimalBid = lot.MinimalBid;
            Lot.BidCount = lot.BidCount;
            Lot.AuctionDate = lot.AuctionDate;

            return Lot;
        }
        public async Task< IEnumerable<LotModel>> GetLotByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
        public async Task< IEnumerable<LotModel>> GetLotByNameAndDate(string name, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }
        public async Task< IEnumerable<LotModel>> GetLots()
        {
            throw new NotImplementedException();
        }

    }
}

