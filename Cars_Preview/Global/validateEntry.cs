using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Cars_Preview.Global
{
    static class validateEntry
    {
        //Check if the string is a number
        public static void NumericOnly(System.Windows.Input.TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^0-9]");
            e.Handled = reg.IsMatch(e.Text);

        }

        public static void AlphaNumericOnly(System.Windows.Input.TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]");
            e.Handled = reg.IsMatch(e.Text);

        }
    }
}
