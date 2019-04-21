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
        IEnumerable<TradingHistoryModel> GetTradingHistory();
        IEnumerable<TradingHistoryModel> GetTradingHistoryByLotId(int id);
        IEnumerable<TradingHistoryModel> GetTradingHistoryByTraderId(int id);
        IEnumerable<TradingHistoryModel> GetTradingHistoryByDate(DateTime start, DateTime end);
        TradingHistoryModel AddTradingHistory(TradingHistoryModel tradingHistoryModel);
        TradingHistoryModel EditTradingHistory(TradingHistoryModel tradingHistoryModel);
    }
}
