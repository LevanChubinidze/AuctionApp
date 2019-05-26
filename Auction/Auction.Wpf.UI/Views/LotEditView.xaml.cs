﻿using Auction.Wpf.UI.Utils;
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
    /// Interaction logic for LotEditView.xaml
    /// </summary>
    public partial class LotEditView : UserControl
    {
        private readonly object LotEditViewModel;

        public LotEditView()
        {
            LotEditViewModel = ServiceContainer.Instance.Services.Resolve<LotEditViewModel>();
            InitializeComponent();
        }

     
    }
}
