using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity8
{
    public partial class CalorieCounter : Form
    {
        public CalorieCounter()
        {
            InitializeComponent();
        }

        private void CalorieCounter_Load(object sender, EventArgs e)
        {
            //on load, clear all labels that display results
            displayCaloriesFromFat.Text = "";
            displayCaloriesFromCarbs.Text = "";
        }

        private void calculateFatCalories_Click(object sender, EventArgs e)
        {
            //use the FatCalories() method to obtain calories
            int calories = FatCalories();
            //display calories on form
            displayCaloriesFromFat.Text = calories.ToString();
        }

        private void calculateCarbCalories_Click(object sender, EventArgs e)
        {
            //use the CarbCalories() method to obtain calories
            int calories = CarbCalories();
            //display calories on form
            displayCaloriesFromCarbs.Text = calories.ToString();
        }

        private int FatCalories()
        {
            //defining the variable to put fatGramsInput.Text into
            int fatGrams;
            //defining return value "calories" (defaults to 0 if invalid input)
            int calories = 0;

            //TryParse used with if-else branches to test for valid input
            if (int.TryParse(fatGramsInput.Text, out fatGrams))
            {
                //calories from fat formula
                calories = fatGrams * 9;
            }

            else
            {
                //a MessageBox appears to let the user know if they entered an invalid input
                MessageBox.Show("Invalid Input");
            }

            //return the value of calories (0 if invalid input)
            return calories;
        }

        private int CarbCalories()
        {
            //defining the variable to put carbGramsInput.Text into
            int carbGrams;
            //defining return value "calories" (defaults to 0 if invalid input)
            int calories = 0;

            //TryParse used with if-else branches to test for valid input
            if (int.TryParse(carbGramsInput.Text, out carbGrams))
            {
                //calories from carbs formula
                calories = carbGrams * 4;
            }

            else
            {
                //a MessageBox appears to let the user know if they entered an invalid input
                MessageBox.Show("Invalid Input");
            }

            //return the value of calories (0 if invalid input)
            return calories;
        }
    }
}
