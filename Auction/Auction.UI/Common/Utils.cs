using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User.Common
{
    internal static class Utils
    {
        public static bool ValidateInput(TextBox textbox, Label label)
        {
            if (string.IsNullOrWhiteSpace(textbox.Text))
            {
                label.ForeColor = Color.FromArgb(140, 10, 10);
                return false;
            }
            else
            {
                label.ForeColor = Color.FromArgb(10, 80, 150);
                return true;
            }
        }
    }
}

