using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auction.UI.TestServices;

namespace Auction.UI.UserControls
{
    public partial class AdminControl : UserControl
    {
        public AdminControl()
        {
            InitializeComponent();

            RegistrationPage.Controls.Add(new RegistrationControl(new AuctioneerTestService()));
        }
    }
}
