using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly IAuctioneerService auctioneerService;

        public LoginViewModel(IAuctioneerService auctioneerService)
        {
            this.auctioneerService = auctioneerService;
        }
    }
}
