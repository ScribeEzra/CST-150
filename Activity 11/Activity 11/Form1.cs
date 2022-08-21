using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rollDieButton_Click(object sender, EventArgs e)
        {
            int diceSides;
            if (int.TryParse(diceSidesInput.Text, out diceSides))
            {
                if (!(diceSides >= 4) && !(diceSides <= 20))
                {
                    MessageBox.Show("Please choose a number from 4 through 20.");
                }
                else
                {
                    SnakeEyesRoll(diceSides);
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
        public class Die
        {
            private int numDieSides;

            public Die()
            {
                //creates a 6-sided die if no arguements
                numDieSides = 6;
            }
            public Die(int sides)
            {
                //Sets sides to user input
                numDieSides = sides;
            }
            public int RollDie(Die die)
            {
                //a Random object must be created first
                Random randVal = new Random();
                //this statement generates a number betwen 1 and the number of sides
                int dieVal = randVal.Next(1, die.numDieSides);
                //the random value is returned
                return dieVal;
            }
            
        }
        public void SnakeEyesRoll(int sides)
        {
            //this variable keeps track of the number of rolls
            int numRolls = 0;

            //these variables keep track of the die values
            //They can't start null due to the upcoming while loop so they start with values of -1
            int die1Val = -1;
            int die2Val = -1;

            //this defines two dice
            Die die1 = new Die(sides);
            Die die2 = new Die(sides);

            //clearing the information from the last run
            ClearDiceLog();

            string rollInfo = "Rolling for snake eyes...";
            LogDiceRoll(rollInfo);


            while (!(die1Val == 1 && die2Val == 1))
            {
                //add to number of rolls
                numRolls++;

                //roll both die to get values
                die1Val = die1.RollDie(die1);
                //Add ten millisecond delay between rolls as otherwise the pseudorandom numbers
                //are the same each time
                Thread.Sleep(10);
                die2Val = die2.RollDie(die2);

                //for some reason I couldn't get this to display the values until after the SnakeEyesRoll method
                //was over, even when adding a 1/4 second delay
                DisplayDice(die1Val, die2Val);

                rollInfo = "Roll " + numRolls + " - Die 1: " + die1Val + " Die 2: " + die2Val;
                LogDiceRoll(rollInfo);
                //pause for half of a second for effect
                //(to show the dice changing and the log filling up at high speed)
                //Thread.Sleep(250);
            }
            MessageBox.Show("It took " + numRolls + " rolls to roll snake eyes!");
        }
        public void LogDiceRoll(string log)
        {
            //adds info of dice roll to listbox
            diceRollLog.Items.Add(log);
        }
        public void DisplayDice(int val1, int val2)
        {
            //displays dice values
            die1Display.Text = val1.ToString();
            die2Display.Text = val2.ToString();
        }
        public void ClearDiceLog()
        {
            //clears listbox
            diceRollLog.Items.Clear();
        }
    }
}
