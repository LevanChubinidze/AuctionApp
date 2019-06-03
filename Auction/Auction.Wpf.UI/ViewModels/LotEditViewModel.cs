using Auction.BL.Models;
using Auction.BL.Services;
using Auction.Wpf.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Auction.Wpf.UI.ViewModels
{
    public class LotEditViewModel : BindableBase
    {
        #region Backing Fields
        private IEnumerable<LotModel> _data;
        private ICommand _loadedCommand;

        #endregion

        private readonly ILotService lotService;

        public IEnumerable<LotModel> Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }


        public LotEditViewModel(ILotService lotService)
        {
            this.lotService = lotService;

        }

        public async void LoadLots()
        {
            Data = await lotService.GetLots();
        }
    }
}
