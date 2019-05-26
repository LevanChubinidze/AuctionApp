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

namespace Auction.Wpf.UI.Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           new LoginWindow().Show();
        }

       
        private void CloseMenuButton_Click(object sender, RoutedEventArgs e)
        {
            //CloseMenuButton.Visibility = Visibility.Collapsed;
            //OpenMenuButton.Visibility = Visibility.Visible;
        }

        private void OpenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            //CloseMenuButton.Visibility = Visibility.Visible;
            //OpenMenuButton.Visibility = Visibility.Collapsed;
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }
       

        #region Helper Methods
        private void AddControl(Control control)
        {
            contentGrid.Children.RemoveAt(0);
            contentGrid.Children.Add(control);
        }

        #endregion
    
    }
}
