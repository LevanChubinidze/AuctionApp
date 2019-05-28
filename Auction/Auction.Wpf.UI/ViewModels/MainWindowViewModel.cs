using Auction.Wpf.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Auction.Wpf.UI.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        Dictionary<string, BindableBase> navigations;
        public AdminViewModel AdminViewModel { get; set; }

        public RelayCommand<string> NavCommand
        {
            get => navCommand;
            set => SetProperty(ref navCommand, value);
        }


        private BindableBase currentViewModel;
        private RelayCommand<string> navCommand;

        public BindableBase CurrentViewModel
        {
            get => currentViewModel;
            set => SetProperty(ref currentViewModel, value);
        }

        public MainWindowViewModel()
        {
            navigations = new Dictionary<string, BindableBase>();
            navigations["Admin"] = ServiceContainer.Instance.Services.Resolve<AdminViewModel>();
            NavCommand = new RelayCommand<string>(OnNavigation);
        }

        private void OnNavigation(string destination)
        {
            if (navigations.ContainsKey(destination))
                CurrentViewModel = navigations[destination];
        }
    }
}
