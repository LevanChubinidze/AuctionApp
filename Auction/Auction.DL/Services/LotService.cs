using Auction.BL.Models;
using Auction.BL.Services;
using Auction.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Services
{
    public class LotService : ILotService
    {
        public async Task<LotModel> AddLot(LotModel lot)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            using (var db = new AuctionContext())
            {
                var lotEntity = new Lot
                {
                    Id = lot.Id,
                    Name = lot.Name,
                    Description = lot.Description,
                    Quantity = lot.Quantity,
                    Unit = lot.Unit,
                    StartingPrice = lot.StartingPrice,
                    CurrentPrice = lot.CurrentPrice,
                    MinimalBid = lot.MinimalBid,
                    BidCount = lot.BidCount,
                    AuctionDate = lot.AuctionDate
                };

                db.Lots.Add(lotEntity);
                await db.SaveChangesAsync();

                lot.Id = lotEntity.Id;
                return lot;
            }
        }

        public async Task<LotModel> EditLot(LotModel lot)
        {
            if (lot == null)
            {
                throw new ArgumentNullException(nameof(lot));
            }

            using (var db = new AuctionContext())
            {
                var lotEntity = db.Lots.FirstOrDefault(L => L.Id == lot.Id);
                if (lotEntity == null) return null;

                lotEntity.Name = lot.Name;
                lotEntity.Description = lot.Description;
                lotEntity.Quantity = lot.Quantity;
                lotEntity.Unit = lot.Unit;
                lotEntity.StartingPrice = lot.StartingPrice;
                lotEntity.CurrentPrice = lot.CurrentPrice;
                lotEntity.MinimalBid = lot.MinimalBid;
                lotEntity.BidCount = lot.BidCount;
                lotEntity.AuctionDate = lot.AuctionDate;

                await db.SaveChangesAsync();

                return lot;
            }
        }

        public async Task<IEnumerable<LotModel>> GetLotByDate(DateTime start, DateTime end)
        {
            using (var db = new AuctionContext())
            {
                var lots = db.Lots
                    .Where(L => L.AuctionDate >= start && L.AuctionDate <= end)
                    .Select(L => new LotModel
                    {
                        Id = L.Id,
                        Name = L.Name,
                        Description = L.Description,
                        Quantity = L.Quantity,
                        Unit = L.Unit,
                        StartingPrice = L.StartingPrice,
                        CurrentPrice = L.CurrentPrice,
                        MinimalBid = L.MinimalBid,
                        BidCount = L.BidCount,
                        AuctionDate = L.AuctionDate
                    })
                    .ToList();

                return lots;
            }

        }

        public async Task<IEnumerable<LotModel>> GetLotByNameAndDate(string name, DateTime start, DateTime end)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using (var db = new AuctionContext())
            {
                var lots = db.Lots
                    .Where(L =>
                         L.AuctionDate >= start
                         && L.AuctionDate <= end
                         && L.Name == name)
                    .Select(L => new LotModel
                    {
                        Id = L.Id,
                        Name = L.Name,
                        Description = L.Description,
                        Quantity = L.Quantity,
                        Unit = L.Unit,
                        StartingPrice = L.StartingPrice,
                        CurrentPrice = L.CurrentPrice,
                        MinimalBid = L.MinimalBid,
                        BidCount = L.BidCount,
                        AuctionDate = L.AuctionDate
                    })
                    .ToList();

                return lots;
            }
        }

        public async Task<IEnumerable<LotModel>> GetLots()
        {
            using (var db = new AuctionContext())
            {
                var lots = db.Lots.Select(L => new LotModel
                {
                    Id = L.Id,
                    Name = L.Name,
                    Description = L.Description,
                    Quantity = L.Quantity,
                    Unit = L.Unit,
                    StartingPrice = L.StartingPrice,
                    CurrentPrice = L.CurrentPrice,
                    MinimalBid = L.MinimalBid,
                    BidCount = L.BidCount,
                    AuctionDate = L.AuctionDate
                }).ToList();

                return lots;
            }

        }
    }
}
