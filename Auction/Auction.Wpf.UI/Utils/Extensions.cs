using System.Globalization;

namespace Auction.Wpf.UI.Utils
{
    public static class Extensions
    {
        public static bool CanAppendWithDigit(this string textNumber, string newSymbol)
        {
            var decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            if (textNumber.Contains(decimalSeparator) && newSymbol == decimalSeparator) return false;
            if (!char.IsDigit(char.Parse(newSymbol)) && newSymbol != decimalSeparator) return false;
            return true;
        }
    }
}
