using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hours_Worked
{
    public static class Checker
    {
        public static bool IsNonNegativeDecimal(TextBox t, string name)
        {
            bool result = true;
            decimal value = Convert.ToDecimal(t.Text);
            if (value < 0)
            {
                MessageBox.Show(name + " should be greater than or equals to 0");
                t.SelectAll(); // select all text for replacement
                t.Focus();
                result = false;
            }
            return result;
        }
    }
}
