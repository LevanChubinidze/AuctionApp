using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class TraderEditViewModel : BindableBase
    {
        private readonly ITraderService traderService;

        public TraderEditViewModel(ITraderService traderService)
        {
            this.traderService = traderService;
        }
    }
}
