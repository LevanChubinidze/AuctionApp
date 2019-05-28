using Auction.Wpf.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Auction.Wpf.UI.ViewModels
{
    public class AdminViewModel : BindableBase
    {
        #region BackingFields
        private RelayCommand<string> _navigationCommand;
        private InformationEditorViewModel _informationEditorViewModel;

        #endregion

        readonly Dictionary<string, BindableBase> navigations;

        public RelayCommand<string> NavigationCommand
        {
            get => _navigationCommand;
            set => SetProperty(ref _navigationCommand, value);
        }


        public InformationEditorViewModel InformationEditorViewModel
        {
            get => _informationEditorViewModel;
            set => SetProperty(ref _informationEditorViewModel, value);
        }

        public AdminViewModel()
        {
            InformationEditorViewModel = ServiceContainer.Instance.Services.Resolve<InformationEditorViewModel>();

            NavigationCommand = new RelayCommand<string>(OnNavigation);
            navigations = new Dictionary<string, BindableBase>
            {
                ["lots"] = ServiceContainer.Instance.Services.Resolve<LotEditViewModel>(),
                ["traiders"] = ServiceContainer.Instance.Services.Resolve<TraderEditViewModel>(),
                ["auctioneers"] = ServiceContainer.Instance.Services.Resolve<AuctioneerEditViewModel>(),
               // ["registration"] = ServiceContainer.Instance.Services.Resolve<>(),
                ["history"] = ServiceContainer.Instance.Services.Resolve<HistoryEditViewModel>()
            };
        }

        private void OnNavigation(string destionation)
        {
            if (navigations.ContainsKey(destionation))
                InformationEditorViewModel.CurrentViewModel = navigations[destionation];
        }
    }
}
