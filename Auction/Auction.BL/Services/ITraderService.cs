using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    interface ITraderService
    {
        IEnumerable<TraderModel> GetTraders();
        IEnumerable<TraderModel> GetTradersByDate(DateTime start, DateTime end);
        IEnumerable<TraderModel> GetTradersByModelAndDate(string name, DateTime start, DateTime end);
        TraderModel AddTrader(TraderModel trader);
        TraderModel EditTrader(TraderModel trader);
    }
}
