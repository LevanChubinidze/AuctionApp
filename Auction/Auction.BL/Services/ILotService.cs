using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    interface ILotService
    {
        IEnumerable<LotModel> GetLots();
        IEnumerable<LotModel> GetLotByDate(DateTime start, DateTime end);
        IEnumerable<LotModel> GetLotByNameAndDate(string name, DateTime start, DateTime end);
        LotModel AddLot(LotModel lot);
        LotModel EditLot(LotModel lot);
    }
}
