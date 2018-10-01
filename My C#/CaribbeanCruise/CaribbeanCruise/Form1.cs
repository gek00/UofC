using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Version 1 for Final Exam usage
 * Core Function added
 * 
 * 
 * Version 2 (Please ignore, notes for developer only)
 * revisit in the future as side project
 * To Do List:
 * Enhance UI (some more)
 * 
*/

namespace CaribbeanCruise
{
    public partial class Form1 : Form
    {

        const int MAX_ADULT = 4;
        const int MAX_CHILD = 5;
        const int MAX_FAM = 2; //each fam package instance has total 4 quantities.
        const int ADULT_PRICE = 1649;
        const int CHILD_PRICE = 1459;
        const int FAM_PRICE = 4599;

        // Arrays
        decimal[] adult_qty = new decimal[MAX_ADULT];
        decimal[] child_qty = new decimal[MAX_CHILD];
        decimal[] fam_qty = new decimal[MAX_FAM];

        int count = 0; // starting point
        decimal total;
        private int adult, child, family, totaladult, totalchild, totalfam;

        public Form1()
        {
            InitializeComponent();
        }

        // Calculate
        private void button1_Click(object sender, EventArgs e)
        {
            // Get necessary data
            adult_qty[count] = Convert.ToInt32(txtAdult.Text);
            child_qty[count] = Convert.ToInt32(txtChild.Text);
            fam_qty[count] = Convert.ToInt32(txtFamily.Text);

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Please input your name.");
            }
            else
            {
                total = (ADULT_PRICE * adult_qty[count]) + (CHILD_PRICE * child_qty[count])
                    + (FAM_PRICE * fam_qty[count]); // add ticket prices


                txtTotal.Text = total.ToString("c"); //display total

                DisableFunction(); // Viable solution to avoid "spur of the moment" changes once calculate button is triggered.
                MessageBox.Show("Press the \"Reset\" button to input new data.");
            }

        }

        private void DisableFunction()
        {
            txtAdult.Enabled = false;
            txtChild.Enabled = false;
            txtFamily.Enabled = false;
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        // Clear to 0
        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtAdult.Enabled = true;
            txtChild.Enabled = true;
            txtFamily.Enabled = true;
            txtAdult.Text = "0";
            txtChild.Text = "0";
            txtFamily.Text = "0";
            txtTotal.Text = "";
            totaladult = 0;
            totalchild = 0;
            totalfam = 0;
        }

        // Add quantity to adult
        private void btnAdd_Click(object sender, EventArgs e)
        {
            adult = 0;
            adult++;

            if (adult > 0)
            {
                totaladult++;
                txtAdult.Text = totaladult.ToString();
            }

            if (totaladult == MAX_ADULT)
            {
                txtAdult.Enabled = false;
                MessageBox.Show("Max allowed for ADULT tickets are 4");
            }

            
        }

        // Add quantity to child.
        private void btnChild_Click(object sender, EventArgs e)
        {
            child = 0;
            child++;

            if (child > 0)
            {
                totalchild++;
                txtChild.Text = totalchild.ToString();
            }

            if (totalchild == MAX_CHILD)
            {
                txtChild.Enabled = false;
                MessageBox.Show("Max allowed for CHILD tickets are 5");
            }
        }

        // Add quantity to family.
        private void btnFam_Click(object sender, EventArgs e)
        {
            family = 0;
            family++;

            if (family > 0)
            {
                totalfam++;
                txtFamily.Text = totalfam.ToString();
            }

            if (totalfam == MAX_FAM)
            {
                txtFamily.Enabled = false;
                MessageBox.Show("Max allowed for FAMILY tickets are 2");
            }
        }

    }
}
