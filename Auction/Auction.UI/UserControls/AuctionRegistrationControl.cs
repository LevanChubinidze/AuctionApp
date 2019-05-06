using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auction.UI.UserControls
{
    public partial class AuctionRegistrationControl : UserControl
    {
        public AuctionRegistrationControl()
        {
            InitializeComponent();
            traderRegistrationPage.Controls.Add(new TraderControl());
            lotRegistrationPage.Controls.Add(new LotControl());
        }
    }
}
