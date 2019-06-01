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
        #region Backing Fields
        private BindableBase _currentViewModel;
        private bool expandButtonIsVisible = true;
        private bool collapseButtonIsVisible = false;

        #endregion

        public InformationEditorViewModel()
        {
            FilterVisibilityCommand = new RelayCommand(OnFilterViewVisibilityChange);
        }


        public ICommand FilterVisibilityCommand { get; set; }

        public bool ExpandButtonIsVisible
        {
            get => expandButtonIsVisible;
            set
            {
                SetProperty(ref expandButtonIsVisible, value);
                // Notify Mediator
            }
        }

        public bool CollapseButtonIsVisible
        {
            get => collapseButtonIsVisible;
            set
            {
                SetProperty(ref collapseButtonIsVisible, value);
                // Notify Mediator
            }
        }

        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private void OnFilterViewVisibilityChange()
        {
            var temp = ExpandButtonIsVisible;
            ExpandButtonIsVisible = CollapseButtonIsVisible;
            collapseButtonIsVisible = temp;
        }

    }
}
