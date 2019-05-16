using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    public interface ITradingHistoryService
    {
        Task<IEnumerable<TradingHistoryModel>> GetTradingHistory();
        Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByLotId(int id);
        Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByTraderId(int id);
        Task<IEnumerable<TradingHistoryModel>> GetTradingHistoryByDate(DateTime start, DateTime end);
        Task<TradingHistoryModel> AddTradingHistory(TradingHistoryModel history);
        Task<TradingHistoryModel> EditTradingHistory(TradingHistoryModel history);
    }
}
