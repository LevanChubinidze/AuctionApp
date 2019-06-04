using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Wpf.UI.ViewModels
{
    public class InformationRegistrationViewModel : BindableBase
    {
        public List<LotModel> Data { get; set; }

        public async void LoadLots()
        {
        }
    }
}
