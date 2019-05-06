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
                ID = 1,
                Name = "ლოტი N1",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            },
            new LotModel
            {
                ID = 2,
                Name = "ლოტი N2",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            },
              new LotModel
            {
                ID = 3,
                Name = "ლოტი N3",
                Description = "გაზის აუქციონი",
                StartingPrice = 230,
                MinimalBid = 2,
            }
        };
        public LotModel AddLot(LotModel lot)
        {
            if (lots.Any(a => a.ID == lot.ID) || lots.Any(a => a.Name == lot.Name) || lots.Any(a => a.AuctionDate == lot.AuctionDate))
                return null;
            else
            {
                lots.Add(lot);
                return lot;
            }
        }

        public LotModel EditLot(LotModel lot)
        {
            var Lot = lots.FirstOrDefault(a => a.ID == lot.ID);
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

        public IEnumerable<LotModel> GetLotByDate(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LotModel> GetLotByNameAndDate(string name, DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LotModel> GetLots()
        {
            throw new NotImplementedException();
        }

    }
}

