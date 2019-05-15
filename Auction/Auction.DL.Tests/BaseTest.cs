using Auction.BL.Services;
using Auction.DL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Auction.DL.Tests
{
   public abstract class BaseTest
    {
        protected readonly IUnityContainer container;

        public BaseTest()
        {
            container = new UnityContainer();

            container.RegisterSingleton<IAuctioneerService, AuctioneerService>();
        }

    }
}
