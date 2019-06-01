using Auction.Wpf.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Auction.Wpf.UI.ViewModels
{
    public class InformationEditorViewModel : BindableBase
    {
        public InformationEditorViewModel()
        {
        }


        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }


    }
}
