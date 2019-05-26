using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class HistoryEditViewModel : BindableBase
    {
        private readonly ITradingHistoryService historyService;

        public HistoryEditViewModel(ITradingHistoryService historyService)
        {
            this.historyService = historyService;
        }
    }
}
