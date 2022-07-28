using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    public partial class tempConversionForm : Form
    {
        public tempConversionForm()
        {
            InitializeComponent();
        }

        private void tempConversionForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void convertButton1_Click(object sender, EventArgs e)
        {
            double userInput = double.Parse(userInputFahrenheit.Text);
            double convertedTemperature = (userInput - 32) * ((double)5 / 9);
            conversionDisplay1.Text = convertedTemperature.ToString() + " Degrees Celsius";

        }

        private void convertButton2_Click(object sender, EventArgs e)
        {
            double userInput = double.Parse(userInputCelsius.Text);
            double convertedTemperature = (userInput * ((double)9/5)) + 32;
            conversionDisplay2.Text = convertedTemperature.ToString() + " Degrees Fahrenheit";
        }
    }
}
