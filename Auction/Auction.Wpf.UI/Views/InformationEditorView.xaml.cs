using Auction.Wpf.UI.Utils;
using Auction.Wpf.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Unity;

namespace Auction.Wpf.UI.Views
{
    /// <summary>
    /// Interaction logic for InformationEditorView.xaml
    /// </summary>
    public partial class InformationEditorView : UserControl
    {
        public InformationEditorViewModel InformationEditorViewModel { get; set; }

        public InformationEditorView()
        {
            InitializeComponent();

            InformationEditorViewModel = ServiceContainer.Instance.Services.Resolve<InformationEditorViewModel>();

            DataContext = InformationEditorViewModel;
        }

        private void Grid_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            if(filterView.Visibility == Visibility.Collapsed)
            {
                filterView.Visibility = Visibility.Visible;
                expandButton.Visibility = Visibility.Hidden;
                collapseButton.Visibility = Visibility.Visible;
            }
            else
            {
                filterView.Visibility = Visibility.Collapsed;
                expandButton.Visibility = Visibility.Visible;
                collapseButton.Visibility = Visibility.Hidden;
            }
        }
    }
}
