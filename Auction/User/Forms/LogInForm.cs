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
using User.Common;

namespace User
{
    public partial class LogInForm : Form
    {
        bool Isvalidinput = false;
        public LogInForm()
        {
            InitializeComponent();
            UserName_textBox.Tag = UserName_label;
            Password_textBox.Tag = Password_label;
        }

        private void LogIn_button_Click(object sender, EventArgs e)
        {
            Isvalidinput = Utils.ValidateInput(UserName_textBox, UserName_label);
            Isvalidinput = Utils.ValidateInput(Password_textBox, Password_label);

            if (Isvalidinput)
            {
                var user = new AuctioneerModel
                {
                    UserName = UserName_textBox.Text,
                    Password = Password_textBox.Text,
                };
                
            }
        }

        private void UserName_textBox_TextChanged(object sender, EventArgs e)
        {
            if(sender is TextBox text && text.Tag is Label label)
            {
                Utils.ValidateInput(text, label);
            }
        }

    }
}
