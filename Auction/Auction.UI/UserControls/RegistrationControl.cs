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
using User.Common;

namespace Auction.UI.UserControls
{

    public partial class RegistrationControl : UserControl
    {
        bool Isvalidinput = false;

        public RegistrationControl()
        {
            Name_textBox.Tag = Name_label;
            LastName_textBox.Tag = LastName_label;
            UserName_textBox.Tag = UserName_label;
            Password_textBox.Tag = Password_label;
            RepeatPassword_textBox.Tag = RepeatPassword_label;
        }

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

                if (_registrationMode)
                {
                    Registration_button.Text = "რეგისტრაცია";
                    Registration_button.BackColor = Color.FromArgb(10, 80, 150);
                }
                else
                {
                    Registration_button.Text = "რედაქტირება";
                    Registration_button.BackColor = Color.FromArgb(150, 80, 10);
                }
            }
        }


        public RegistrationControl(IAuctioneerService auctioneerService)
        {
            InitializeComponent();
            AuctioneerService = auctioneerService;

            PopulateData();
        }

        private async void PopulateData()
        {
            auctioners = (await AuctioneerService.GetAuctioneers()).ToList();
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
            Isvalidinput = Utils.ValidateInput(Name_textBox, Name_label);
            Isvalidinput = Utils.ValidateInput(LastName_textBox, LastName_label);
            Isvalidinput = Utils.ValidateInput(UserName_textBox, UserName_label);
            Isvalidinput = Utils.ValidateInput(Password_textBox, Password_label);
            Isvalidinput = Utils.ValidateInput(RepeatPassword_textBox, RepeatPassword_label);

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

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox text && text.Tag is Label label)
            {
                Utils.ValidateInput(text, label);
            }
        }
    }
}
