using Auction.Wpf.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Unity;

namespace Auction.Wpf.UI.ViewModels
{
    public class InformationEditorViewModel : BindableBase
    {
        private Dictionary<string, BindableBase> navigations;


        public InformationEditorViewModel()
        {
            Messenger.Instance.Register<string>(this, OnSelectedMenuItemRecived);

            navigations = new Dictionary<string, BindableBase>
            {
                ["lots"] = ServiceContainer.Instance.Services.Resolve<LotEditViewModel>(),
                ["traiders"] = ServiceContainer.Instance.Services.Resolve<TraderEditViewModel>(),
                ["auctioneers"] = ServiceContainer.Instance.Services.Resolve<AuctioneerEditViewModel>(),
                // ["registration"] = ServiceContainer.Instance.Services.Resolve<>(),
                ["history"] = ServiceContainer.Instance.Services.Resolve<HistoryEditViewModel>()
            };
        }

        private void OnSelectedMenuItemRecived(string selectedMenuItem)
        {
            if (navigations.ContainsKey(selectedMenuItem))
                CurrentViewModel = navigations[selectedMenuItem];
        }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }


    }
}
