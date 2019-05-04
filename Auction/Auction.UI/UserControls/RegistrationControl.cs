using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Auction.BL.Models;
using Auction.BL.Services;

namespace Auction.UI.UserControls
{
    public partial class RegistrationControl : UserControl
    {
        private List<AuctioneerModel> auctioners;
        public IAuctioneerService AuctioneerService { get; }
        AuctioneerModel selectedAuctioneer;

        private bool _registrationMode;
        public bool RegistrationMode
        {
            get { return _registrationMode; }
            set
            {
                _registrationMode = value;
                UserName_textBox.Enabled = value;
                Registration_button.Text = _registrationMode ? "რეგისტრაცია" : "რედაქტირება";
            }
        }


        public RegistrationControl(IAuctioneerService auctioneerService)
        {
            InitializeComponent();
            AuctioneerService = auctioneerService;

            PopulateData();
        }

        private void PopulateData()
        {
            auctioners = AuctioneerService.GetAuctioneers().ToList();
            auctioners.Insert(0, new AuctioneerModel());

            Users_comboBox.DataSource = auctioners;

            RegistrationMode = Users_comboBox.SelectedIndex == 0;
        }

        private void Users_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistrationMode = Users_comboBox.SelectedIndex == 0;
            selectedAuctioneer = Users_comboBox.SelectedItem as AuctioneerModel;

            Name_textBox.Text = selectedAuctioneer.FirstName;
            LastName_textBox.Text = selectedAuctioneer.LastName;
            UserName_textBox.Text = selectedAuctioneer.UserName;
            Password_textBox.Text = selectedAuctioneer.Password;
            RepeatPassword_textBox.Text = selectedAuctioneer.Password;
        }

        private void Registration_button_Click(object sender, EventArgs e)
        {
            if (RegistrationMode)
            {
                AuctioneerService.RegisterAuctioneer(InitializeAuctioneer(new AuctioneerModel()));
            }
            else
            {
                AuctioneerService.EditAuctioneer(InitializeAuctioneer(selectedAuctioneer));
                Users_comboBox.SelectedIndex = 0;
            }
            PopulateData();
        }

        AuctioneerModel InitializeAuctioneer(AuctioneerModel auctioneer)
        {
            auctioneer.FirstName = Name_textBox.Text;
            auctioneer.UserName = UserName_textBox.Text;
            auctioneer.LastName = LastName_textBox.Text;
            auctioneer.Password = Password_textBox.Text;
            return auctioneer;
        }

      
    }
}
