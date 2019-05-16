using Auction.BL.Models;
using Auction.BL.Services;
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
        public Task<TradingHistoryModel> AddTradingHistory(TradingHistoryModel history)
        {
            throw new NotImplementedException();
        }

        public Task<TradingHistoryModel> EditTradingHistory(TradingHistoryModel history)
        {
            throw new NotImplementedException();
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
