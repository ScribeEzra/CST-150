using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_14
{
    public partial class tacoCentral : Form
    {
        public tacoCentral()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            //create a blank string
            string order = "";
            //add checked items to string
            if (cTortillaRadio.Checked)
            {
                order += "Corn Tortilla";
            }
            else
            {
                order += "Flour Tortilla";
            }
            if (beefCheck.Checked)
            {
                order += ", Beef";
            }
            if (beansCheck.Checked)
            {
                order += ", Beans";
            }
            if (chickenCheck.Checked)
            {
                order += ", Chicken";
            }
            if (tomatoCheck.Checked)
            {
                order += ", Tomato";
            }
            if (lettuceCheck.Checked)
            {
                order += ", Lettuce";
            }
            if (onionCheck.Checked)
            {
                order += ", Onion";
            }
            if (cheeseCheck.Checked)
            {
                order += ", Cheese";
            }
            if (avocadoCheck.Checked)
            {
                order += ", Avocado";
            }
            if (sourCreamCheck.Checked)
            {
                order += ", Sour Cream";
            }
            if (jalapenoCheck.Checked)
            {
                order += ", Japapeno ";
            }
            if (cilantroCheck.Checked)
            {
                order += ", Cilantro ";
            }
            if (salsaCheck.Checked)
            {
                order += ", Salsa ";
            }
            if (quesoCheck.Checked)
            {
                order += ", Queso ";
            }
            if (picoCheck.Checked)
            {
                order += ", Pico ";
            }
            //display order selections
            orderDisplay.Text = order;
        }
    }
}
