using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class Form1 : Form
    {

        decimal quiz1, quiz2, quiz3, midTerm, finalExam, totalGrade, average;

        const int MAX_SIZE = 10;

        private void txtQuiz1_TextChanged(object sender, EventArgs e)
        {

        }

        int[] quizList = new int[MAX_SIZE]; // Array of 10 decimals.

        // Clear Button
        private void button1_Click(object sender, EventArgs e)
        {
            txtQuiz1.Text = "";
            txtQuiz1.Focus(); // Once cleared, cursor resets to prep for next entries.
            txtQuiz2.Text = "";
            txtQuiz3.Text = "";
            txtMidterm.Text = "";
            txtFinalEx.Text = "";
            txtAverage.Text = "";
            txtLowest.Text = "";
            txtLetter.Text = "";
        }

        // Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Conversion to specified percentages
            quiz1 = Convert.ToDecimal(txtQuiz1.Text) * Convert.ToDecimal(0.15);
            quiz2 = Convert.ToDecimal(txtQuiz2.Text) * Convert.ToDecimal(0.15);
            quiz3 = Convert.ToDecimal(txtQuiz3.Text) * Convert.ToDecimal(0.15);
            midTerm = Convert.ToDecimal(txtMidterm.Text) * Convert.ToDecimal(0.30);
            finalExam = Convert.ToDecimal(txtFinalEx.Text) * Convert.ToDecimal(0.40);

            // Calculated Total
            totalGrade = quiz1 + quiz2 + quiz3 + midTerm + finalExam;

            // Get the lowest value
            decimal lowest = (Math.Min(Math.Min(quiz1, quiz2), quiz3));

            // Get average without lowest grade.
            average = (totalGrade - lowest);

            //Print out Average.
            txtAverage.Text = Convert.ToString(average);

            // Reverts Value of lowest score back to original.
            decimal lowestScore = lowest / Convert.ToDecimal(0.15);

            // Print Out Lowest
            txtLowest.Text = Convert.ToString(lowestScore);

            // Conversion to letter grade based upon percentage.
            if (average >= 90)
            {
                txtLetter.Text = "A";
            }
            else if (average >= 80 && average <= 90)
            {
                txtLetter.Text = "B";
            }
            else if (average >= 70 && average <= 80)
            {
                txtLetter.Text = "C";
            }
            else if (average >= 60 && average <= 70)
            {
                txtLetter.Text = "D";
            }
            else
            {
                txtLetter.Text = "F";
            }
               
   

        }
    }
}
