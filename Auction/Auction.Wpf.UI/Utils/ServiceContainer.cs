using Auction.BL.Services;
using Auction.DL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Extension;

namespace Auction.Wpf.UI.Utils
{
   public sealed class ServiceContainer
    {
        public static ServiceContainer Instance => _instance;

        private static readonly ServiceContainer _instance = new ServiceContainer();

        public IUnityContainer Services { get; }

        static ServiceContainer()
        {
        }

        private ServiceContainer()
        {
            Services = new UnityContainer();

            Services.RegisterSingleton<IAuctioneerService, AuctioneerService>();
            Services.RegisterSingleton<ITraderService, TraderService>();
            Services.RegisterSingleton<ILotService, LotService>();
            Services.RegisterSingleton<ITradingHistoryService, TradingHistoryService>();

        }


    }

}
