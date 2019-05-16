using Auction.BL.Models;
using Auction.BL.Services;
using Auction.DL.Models;
using Auction.DL.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.DL.Services
{
    public class TradingHistoryService : ITradingHistoryService
    {
        public async Task<TradingHistoryModel> AddTradingHistory(TradingHistoryModel history)
        {
            if (history == null)
            {
                throw new ArgumentNullException(nameof(history));
            }

            using (var db = new AuctionContext())
            {
                //var trader = db.Traders.FirstOrDefault(t => t.Id == (history.Trader == null ? 0 : history.Trader.Id));
                //var lot = db.Lots.FirstOrDefault(L => L.Id == (history.Lot == null ? 0 : history.Lot.Id));
                //var Aunctioneer = db.Lots.FirstOrDefault(a => a.Id == (history.Auctioneer == null ? 0 : history.Auctioneer.Id));

                var trader = db.Traders.FirstOrDefault(t => t.Id == history.Trader.Id);
                var lot = db.Lots.FirstOrDefault(L => L.Id == history.Lot.Id);
                var auctioneer = db.Auctioneers.FirstOrDefault(a => a.Id == history.Auctioneer.Id);

                var newRecord = new TradingHistory
                {
                    Lot = lot,
                    Trader = trader,
                    Auctioneer = auctioneer,
                    LotId = lot.Id,
                    TraderId = trader.Id,
                    AuctioneerId = auctioneer.Id,
                    BidTime = history.BidTime,
                    BidOrder = history.BidOrder,
                    RecordedPrice = history.RecordedPrice,
                };

                db.TradingHistories.Add(newRecord);
                await db.SaveChangesAsync();

                history.Id = newRecord.Id;
                return history;
            }
        }

        public async Task<TradingHistoryModel> EditTradingHistory(TradingHistoryModel history)
        {
            if (history == null)
            {
                throw new ArgumentNullException(nameof(history));
            }

            using (var db = new AuctionContext())
            {
                var modifiedRecord = db.TradingHistories.FirstOrDefault(h => h.Id == history.Id);
                if (modifiedRecord == null) return null;

                var trader = db.Traders.FirstOrDefault(t => t.Id == (history.Trader == null ? 0 : history.Trader.Id)) ?? modifiedRecord.Trader;
                var lot = db.Lots.FirstOrDefault(L => L.Id == (history.Lot == null ? 0 : history.Lot.Id)) ?? modifiedRecord.Lot;
                var auctioneer = db.Auctioneers.FirstOrDefault(a => a.Id == (history.Auctioneer == null ? 0 : history.Auctioneer.Id)) ?? modifiedRecord.Auctioneer;


                modifiedRecord.Lot = lot;
                modifiedRecord.Trader = trader;
                modifiedRecord.Auctioneer = auctioneer;
                modifiedRecord.LotId = lot.Id;
                modifiedRecord.TraderId = trader.Id;
                modifiedRecord.AuctioneerId = auctioneer.Id;
                modifiedRecord.BidTime = history.BidTime;
                modifiedRecord.BidOrder = history.BidOrder;
                modifiedRecord.RecordedPrice = history.RecordedPrice;

                await db.SaveChangesAsync();

                return history;
            }
        }

        public async Task<IEnumerable<TradingHistoryModel>> GetTradingHistory()
        {
            using (var db = new AuctionContext())
            {
                var history = db.TradingHistories
                    .Select(h => h.ToTradingHistoryModel())
                    .ToList();

                return history;
            }
        }

        public async Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByDate(DateTime start, DateTime end)
        {
            using (var db = new AuctionContext())
            {
                var history = db.TradingHistories
                    .Where(h => h.BidTime >= start && h.BidTime <= end)
                    .Select(h => h.ToTradingHistoryModel())
                    .ToList();

                return history;
            }
        }

        public async Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByLotId(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "must be more than zero");

            using (var db = new AuctionContext())
            {
                var history = db.TradingHistories
                    .Where(h => h.Lot.Id == id)
                    .Select(h => h.ToTradingHistoryModel())
                    .ToList();

                return history;
            }
        }

        public async Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByTraderId(int id)
        {
            if (id <= 0) throw new ArgumentOutOfRangeException(nameof(id), "must be more than zero");

            using (var db = new AuctionContext())
            {
                var history = db.TradingHistories
                    .Where(h => h.Trader.Id == id)
                    .Select(h => h.ToTradingHistoryModel())
                    .ToList();

                return history;
            }
        }
    }
}
