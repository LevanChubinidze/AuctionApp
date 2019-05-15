using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    public interface ITraderService
    {
        Task<IEnumerable<TraderModel>> GetTraders();
        Task<IEnumerable<TraderModel>> GetTradersByDate(DateTime start, DateTime end);
        Task<IEnumerable<TraderModel>> GetTradersByNameAndDate(string name, DateTime start, DateTime end);
        Task<TraderModel> AddTrader(TraderModel trader);
        Task<TraderModel> EditTrader(TraderModel trader);
    }
}
