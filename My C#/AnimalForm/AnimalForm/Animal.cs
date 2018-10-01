using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalForm
{
    public class Animal
    {
        const double COST_PER_DAY = 8.50;

        // private Data.
        private string name;
        private double acquireCost;
        private int daysOwned;

        // Constructor that setups properties
        public Animal(string n, int d, double a)
        {
            Name = n;
            DaysOwned = d;
            AcquireCost = a;
        }

        // Calculate Total Cost of Animal.
        public double TotalCost()
        {
            double total = COST_PER_DAY * daysOwned + acquireCost;
            return total;
        }

        //Override ToString method.
        public override String ToString()
        {
            return name + "\t" + daysOwned.ToString() + "\t" + acquireCost.ToString("c") + "\tTOTAL: " + TotalCost().ToString("c");
        }

        public string Name
        {
            get // Allows access to the name property.
            {
                return name;
            }
            set // Allows changing to the name property.
            {
                if (value != null && value != "")
                {
                    name = value;
                }
            }
        }

        public int DaysOwned
        {
            get // Allows access to the days owned property.
            {
                return daysOwned;
            }
            set // Allows changing to the days owned property
            {
                if (value >= 0) // Verify for Non-negative values
                {
                    daysOwned = value;
                }
            }
        }

        public double AcquireCost
        {
            get // Allows access to the acquire cost property.
            {
                return acquireCost;
            }
            set // Allows changing to the acquire cost property
            {
                if (value >= 0) // If negative, no change.
                {
                    acquireCost = value;
                }
            }
        }

        public String DisplayData()
        {
            return name.ToString() + daysOwned.ToString() + " at " + acquireCost.ToString("c");
        }
    }
}
