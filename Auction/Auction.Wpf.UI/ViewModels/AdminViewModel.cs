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

        #endregion

        public RelayCommand<string> NavigationCommand
        {
            get => _navigationCommand;
            set => SetProperty(ref _navigationCommand, value);
        }


        public AdminViewModel()
        {
            NavigationCommand = new RelayCommand<string>(OnNavigation);
        }

        private void OnNavigation(string selectedMenuItem)
        {
            Messenger.Instance.Send(selectedMenuItem);
        }
    }
}
