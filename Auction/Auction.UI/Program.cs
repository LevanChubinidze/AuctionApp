﻿using Auction.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using User.Forms;

namespace User
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm(new AuctioneerModel
            {
                FirstName = "ლევან",
                LastName = "ჩუბინიძე",
                IsAdmin = true,
            }));
        }
    }
}
