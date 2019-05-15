using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.BL.Services
{
    public interface ILotService
    {
        Task<IEnumerable<LotModel>> GetLots();
        Task<IEnumerable<LotModel>> GetLotByDate(DateTime start, DateTime end);
        Task<IEnumerable<LotModel>> GetLotByNameAndDate(string name, DateTime start, DateTime end);
        Task<LotModel> AddLot(LotModel lot);
        Task<LotModel> EditLot(LotModel lot);
    }
}
