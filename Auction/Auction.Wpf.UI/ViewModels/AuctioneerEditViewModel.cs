using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class AuctioneerEditViewModel : BindableBase
    {
        private readonly IAuctioneerService auctioneerService;

        public AuctioneerEditViewModel(IAuctioneerService auctioneerService)
        {
            this.auctioneerService = auctioneerService;
            Visible = false;
        }
    }
}
