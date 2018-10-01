using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*TO-DO List
 * Further bug test 05/06/18
 *
 * 
 */


namespace AnimalForm
{
    public partial class Form1 : Form
    {
        //form level variables
        List<Animal> animal = new List<Animal>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayAnimal();
        }

        private void DisplayAnimal()
        {
            lstAnimal.Items.Clear(); // Clear Listbox
            foreach (Animal a in animal) // Display animal with overrode ToString() method
            {
                lstAnimal.Items.Add(a.ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate every data if legit.
            if  (string.IsNullOrEmpty(txtName.Text)) 
            {

                MessageBox.Show("Name cannot be empty.");
                txtName.Focus();

            }
            else if (Checker.IsInteger(txtDays, "Days Owned") &&
                     Checker.IsNonNegativeInt(txtDays, "Days Owned") &&
                     Checker.IsDouble(txtAcquire, "Acquiring Cost") && 
                     Checker.IsNonNegativeDouble(txtAcquire, "Acquiring Cost"))
            {
                // collect data and add new Animal.
                Animal a = new Animal(txtName.Text, Convert.ToInt32(txtDays.Text), Convert.ToDouble(txtAcquire.Text));
                animal.Add(a);
                EraseData(); // Prepare for next entry; Implemented for ease of use.


                //Re-display Update Animal List.
                DisplayAnimal();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstAnimal.Items.Clear();// Clear out listbox 
            animal.Clear(); // Clear out List<Animal> obj                              
            EraseData();
        }

        private void EraseData()
        {
            txtName.Text = "";
            txtDays.Text = "";
            txtAcquire.Text = "";
            txtName.Focus();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double grandTotal;
            grandTotal = animal.Sum(p => p.TotalCost()); // Adds Total of all animals in the list

            lstAnimal.Items.Add(""); 
            lstAnimal.Items.Add("Grand Total Cost of Animal/s:");
            lstAnimal.Items.Add(grandTotal.ToString("c")); // Converts to Currency then further display total to user
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
