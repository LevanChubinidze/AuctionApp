using Auction.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class LotEditViewModel : BindableBase
    {
        private readonly ILotService lotService;

        public LotEditViewModel(ILotService lotService)
        {
            this.lotService = lotService;
            Visible = false;
        }
    }
}
