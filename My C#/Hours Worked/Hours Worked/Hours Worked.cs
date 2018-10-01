using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Program is designed to calculate work hours.
// Created by Gian Brioso
// Sep 2017.
// Revised last on Nov 2017.



namespace Hours_Worked
{
    public partial class HoursWorked : Form
    {

        // Hourly Rate, Total Pay, Total Hours and Overtime.
        decimal rate, totalPay, hours, overtimeRate, overtime, gross;
        const decimal BASE_HOURS = 37.5m; 
        const decimal OVERTIME_RATE = 1.5m;


        public HoursWorked()
        {
            InitializeComponent();
        }

        // Read Total Hours and Hourly rate then Calculate
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Total Calculation packaged w/ error handlers.
            totalCalculation();

        }

        private void totalCalculation()
        {

            if (string.IsNullOrEmpty(textBox1.Text) || (string.IsNullOrEmpty(textBox2.Text))) // check if empty input.
            {
                MessageBox.Show("Input cannot be empty.");
                clearInput();
            }
            else if (Decimal.TryParse(textBox1.Text, out hours) && Decimal.TryParse(textBox2.Text, out rate)) 
            {
                calculatePay(); 
            }
            else // if user inputs alphanumeric characters.
            {
                MessageBox.Show("Input must be in numeric digits.");
                clearInput();
            }


        }

        // Refactored method of calculation w/ Validation Function and verify input range.
        private void calculatePay()
        {
            // check if negative
            if (Checker.IsNonNegativeDecimal(textBox1, "Total Hours") && (Checker.IsNonNegativeDecimal(textBox2, "Hourly Rate"))) {
                hours = Convert.ToDecimal(textBox1.Text);
                rate = Convert.ToDecimal(textBox2.Text);

                if (hours > 100)
                {
                    MessageBox.Show("\"Total Hours\" must be between 0-100.");
                    clearInput();
                }
                else if (rate > 500)
                {
                    MessageBox.Show("\"Hourly Rate\" must be between 0-500.");
                    clearInput();
                }
                else if ((hours >= 0) && (hours <= 100) && (rate >= 0) && (rate <= 500))
                {
                    totalPay = calculateRate(hours, rate);
                    txtPay.Text = totalPay.ToString("c"); //Convert "Total Pay" to string and formats it in currency.
                }
            }

        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {

        }

        private decimal calculateRate(decimal hr, decimal rate)
        {
            if (hours <= BASE_HOURS)
            {

                totalPay = hours * rate;

            }
            else
            {
                // Calculate the usual pay rate
                gross = BASE_HOURS * rate;

                //Calculate overtime hours worked
                overtime = hours - BASE_HOURS;

                // Calculate overall overtime pay
                overtimeRate = overtime * (rate * OVERTIME_RATE);

                //Overall Calculation
                totalPay = gross + overtimeRate;
            }
            return totalPay;

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearInput();

        }

        // Clear inputs
        private void clearInput()
        {
            textBox1.Text = "";
            textBox1.Focus(); // Once cleared, cursor resets to prep for next entries.
            textBox2.Text = "";
            txtPay.Text = "";
        }

        // Close Program
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
