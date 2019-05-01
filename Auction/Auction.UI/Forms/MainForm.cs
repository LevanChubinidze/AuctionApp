using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Forms
{
    public partial class MainForm : Form
    {
        bool Lessed = false;
        int MaxWidth = 220;
        int MinWidth = 50;
        int StepSize = 5;

        public MainForm(AuctioneerModel auctioneer)
        {
            InitializeComponent();
            FirstName_label.Text = auctioneer.FirstName;
            LastName_label.Text = auctioneer.LastName;

            CenterLabel(FirstName_label);
            CenterLabel(LastName_label);

        }

        private void CenterLabel(Label label)
        {
            var x = (label.Right - label.Left) / 2;
            label.Left = Menu_panel.Width / 2 - x;
        }

        private void SetAuctioneerInfoVisibility(bool visible)
        {
            FirstName_label.Visible = visible;
            LastName_label.Visible = visible;
            User_pictureBox.Visible = visible;
        }

        private void Menu_button_Click(object sender, EventArgs e)
        {
            MenuPanel_timer.Start();
        }

        private void MenuPanel_timer_Tick(object sender, EventArgs e)
        {
            if (Lessed)
            {
                SetAuctioneerInfoVisibility(true);
                GrowingMenuPanel();
            }
            else
            {
                SetAuctioneerInfoVisibility(false);
                LesseningMenuPanel();
            }
        }

        private void LesseningMenuPanel()
        {
            if (Menu_panel.Width > MinWidth)
                Menu_panel.Width -= StepSize;
            else
            {
                Lessed = true;
                MenuPanel_timer.Stop();
            }
        }

        private void GrowingMenuPanel()
        {
            if (Menu_panel.Width < MaxWidth)
                Menu_panel.Width += StepSize;
            else
            {
                Lessed = false;
                MenuPanel_timer.Stop();
            }
        }

    }
}
