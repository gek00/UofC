using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         Salary range:          Base tax:       Percent on excess:
         0 - 14,999.99          0.00            15%
         15,000 - 29,999.99     2,250.00        18%
         30,000 - 49,999.99     4,950.00        22%
         50,000 - 79,999.99     9,350.00        27%
         80,000 or more         17,450.00       33%
        */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // constants
            const decimal LEVEL0 = 0m;
            const decimal BASE0 = 0m;
            const decimal TAX_PCT0 = 0.15m; // 15%
            const decimal LEVEL1 = 15000m;
            const decimal BASE1 = 2250m;
            const decimal TAX_PCT1 = 0.18m; // 18%
            const decimal LEVEL2 = 30000m;
            const decimal BASE2 = 4950m;
            const decimal TAX_PCT2 = 0.22m; // 22%
            const decimal LEVEL3 = 50000m;
            const decimal BASE3 = 9350m;
            const decimal TAX_PCT3 = 0.27m; // 27%
            const decimal LEVEL4 = 80000m;
            const decimal BASE4 = 17450m;
            const decimal TAX_PCT4 = 0.33m; // 27%

            // variables
            decimal salary;     // input - annual salary
            decimal tax = 0m ;  // output - calculated tax

            // get salary
            salary = Convert.ToDecimal(txtSalary.Text);

            // calculate tax
            if (salary < LEVEL1)
                tax = BASE0 + (salary - LEVEL0) * TAX_PCT0;
            else if (salary < LEVEL2)
                tax = BASE1 + (salary - LEVEL1) * TAX_PCT1;
            else if (salary < LEVEL3)
                tax = BASE2 + (salary - LEVEL2) * TAX_PCT2;
            else if (salary < LEVEL4)
                tax = BASE3 + (salary - LEVEL3) * TAX_PCT3;
            else // salary >= LEVEL4
                tax = BASE4 + (salary - LEVEL4) * TAX_PCT4;

            // display tax
            lblTax.Text = tax.ToString("c");
        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
