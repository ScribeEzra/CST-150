using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class aproximatedPi : Form
    {
        public aproximatedPi()
        {
            InitializeComponent();
        }

        private void calcTermsOfPi_Click(object sender, EventArgs e)
        {
            int.TryParse(integerInput.Text, out int userTermsInput);
            if (userTermsInput <= 0)
            {
                //if the user inputs a zero or an invalid input, TryParse returns a 0
                //negative values are also invalid as pi isn't aproximated using negative numbers
                //plus, negative numbers would confuse the counter variable
                MessageBox.Show("Enter a Valid Input");
            }
            else
            {
                //a double that starts at 0 to start the calculations with
                double piAproxToTerms = 0.0;
                //a for loop that iterates to the user-defined number of terms
                for (int i = 0; i < (userTermsInput); ++i)
                {
                    //The first iteration is simply 4
                    if (i == 1)
                    {
                        piAproxToTerms = 4.0;
                    }
                    //even iterations subtract the formula
                    else if ((i % 2 == 0))
                    {
                        piAproxToTerms -= (4 / (double)((i * 2) - 1));
                    }
                    //odd iterations, aside from one, add the formula
                    else
                    {
                        piAproxToTerms += (4 / (double)((i * 2) - 1));
                    }
                    

                }
                //display pi aproximated to the user-defined term
                //in the piAproxValDisplay label
                piAproxValDisplay.Text = piAproxToTerms.ToString();
            }
        }

        private void aproximatedPi_Load(object sender, EventArgs e)
        {
            //erase label text on load
            piAproxValDisplay.Text = "";
        }
    }
}
