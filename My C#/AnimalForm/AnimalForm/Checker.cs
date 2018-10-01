using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalForm
{
    public static class Checker
    {
        public static bool IsInteger(TextBox t, string name)
        {
            bool result = true; // Assume all good until proven otherwise
            int value;
            if (!Int32.TryParse(t.Text, out value)) // No good.           
            {
                MessageBox.Show(name + " should be an integer value");
                t.SelectAll(); // select all text for replacement
                t.Focus();
                result = false;
            }
            return result;
        }

        public static bool IsNonNegativeInt(TextBox t, string name)
        {
            bool result = true;
            int value = Convert.ToInt32(t.Text);
            if (value < 0)
            {
                MessageBox.Show(name + " should be positive or zero");
                t.SelectAll(); 
                t.Focus();
                result = false;
            }
            return result;
        }

        public static bool IsDouble(TextBox t, string name)
        {
            bool result = true;
            double value;
            if (!Double.TryParse(t.Text, out value))
            {
                MessageBox.Show(name + " should be greater than or equals to 0");
                t.SelectAll(); // select all text for replacement
                t.Focus();
                result = false;
            }
            return result;
        }

        public static bool IsNonNegativeDouble(TextBox t, string name)
        {
            bool result = true;
            double value = Convert.ToDouble(t.Text);
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
