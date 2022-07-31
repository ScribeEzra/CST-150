using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class timeCalculationForm : Form
    {
        public timeCalculationForm()
        {
            InitializeComponent();
        }

        private void timeCalculationForm_Load(object sender, EventArgs e)
        {
            //I learned the hard way that deleting the text on the designer makes labels impossible to find
            //I just had to make new labels instead of using the ones I originally made
            //And decided I'd just delete the text upon form load.
            userInputLabel.Text = "";
            convertedDaysLabel.Text = "";
            convertedHoursLabel.Text = "";
            convertedMinutesLabel.Text = "";
            convertedSecondsLabel.Text = "";
        }

        private void timeConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                int userInput = int.Parse(userInputSeconds.Text);
                int days = 0;
                int hours = 0;
                int minutes = 0;
                int seconds = userInput;
                //Multiple "if" branches to search for certain conditions
                if (seconds >= 86400)
                {
                    //calculate days
                    days = seconds / 86400;
                    //delete used seconds from seconds
                    seconds -= (days * 86400);
                }
                if (seconds >= 3600)
                {
                    //calculate hours
                    hours = seconds / 3600;
                    //delete used seconds from seconds
                    seconds -= (hours * 3600);
                }
                if (seconds >= 60)
                {
                    //calculate minutes
                    minutes = seconds / 60;
                    //delete used seconds from seconds
                    seconds -= (minutes * 60);
                }
                //clear text box
                userInputSeconds.Text = "";
                //display original user input
                userInputLabel.Text = userInput + " seconds is converted to";
                //display converted days, hours, minutes, and lefover seconds
                convertedDaysLabel.Text = days + " Days";
                convertedHoursLabel.Text = hours + " Hours";
                convertedMinutesLabel.Text = minutes + " Minutes";
                convertedSecondsLabel.Text = "And " + seconds + " seconds.";
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
