using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity_15
{
    public partial class luckyNumberForm : Form
    {
        //It's easier if all methods can access these numbers
        public int bloodTypeNum;
        public int horoscopeNum;
        public int fortuneCookieNum;
        public luckyNumberForm()
        {
            InitializeComponent();
        }

        private void luckyNumberForm_Load(object sender, EventArgs e)
        {
            //all numbers will be -1 until chosen otherwise
            bloodTypeNum = -1;
            horoscopeNum = -1;
            fortuneCookieNum = -1;

            //clear labels
            horoscopeLabel.Text = "";
            personalityLabel.Text = "";
        }
        private void fortuneCookie1_Click(object sender, EventArgs e)
        {
            //Chooses Fortune Cookie and shows which one is selected, clearing previous selections
            fortuneCookieNum = 1;
            fortuneCookie1.BorderStyle = BorderStyle.FixedSingle;
            fortuneCookie2.BorderStyle = BorderStyle.None;
            fortuneCookie3.BorderStyle = BorderStyle.None;
        }

        private void fortuneCookie2_Click(object sender, EventArgs e)
        {
            //Chooses Fortune Cookie and shows which one is selected, clearing previous selections
            fortuneCookieNum = 2;
            fortuneCookie1.BorderStyle = BorderStyle.None;
            fortuneCookie2.BorderStyle = BorderStyle.FixedSingle;
            fortuneCookie3.BorderStyle = BorderStyle.None;
        }

        private void fortuneCookie3_Click(object sender, EventArgs e)
        {
            //Chooses Fortune Cookie and shows which one is selected, clearing previous selections
            fortuneCookieNum = 3;
            fortuneCookie1.BorderStyle = BorderStyle.None;
            fortuneCookie2.BorderStyle = BorderStyle.None;
            fortuneCookie3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void birthYear_TextChanged(object sender, EventArgs e)
        {
            int birthYear;
            if (int.TryParse(birthYearTextbox.Text, out birthYear))
            {
                //Calculate horoscope
                horoscopeNum = birthYear % 12;
                //Retrieves horoscope animal based on horoscope number
                horoscopeLabel.Text = GenerateHoroscope(horoscopeNum);
            }
            else
            {
                //Clears label if error
                horoscopeLabel.Text = "";
            }
        }

        private void bloodTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            //bloodTypeNum assigned via selected bloodtype
            bloodTypeNum = bloodTypeSelect.SelectedIndex;
            //Retrieves personality type based on bloodTypeNum
            personalityLabel.Text = GeneratePersonality(bloodTypeNum);
        }
        private void generateNumberButton_Click(object sender, EventArgs e)
        {
            if (bloodTypeNum == -1 || horoscopeNum == -1 || fortuneCookieNum == -1)
            {
                //Alerts User to Fill Out All Criteria if one or more numbers are still -1
                MessageBox.Show("Please Fill Out All Criteria");
            }
            else
            {
                //Generates Lucky Number via formula that uses bloodTypeNum, horoscopeNum, and fortuneCookieNum
                int luckyNumber = GenerateLuckyNumber(bloodTypeNum, horoscopeNum, fortuneCookieNum);

                //Writes number to output file to be used in second form
                StreamWriter outputFile = File.CreateText("LuckyNumber.txt");
                outputFile.WriteLine(luckyNumber);
                outputFile.Close();
                //Creates instance of second form and calls second form
                luckyNumberPopupForm luckyNumPopup = new luckyNumberPopupForm();
                luckyNumPopup.ShowDialog();
            }
        }
        public string GenerateHoroscope(int horoscopeNum)
        {
            //Returns horoscope animal based on horoscopeNum
            string horoscope = "";
            if (horoscopeNum == 0)
            {
                horoscope = "Monkey";
            }
            else if (horoscopeNum == 1)
            {
                horoscope = "Rooster";
            }
            else if (horoscopeNum == 2)
            {
                horoscope = "Dog";
            }
            else if (horoscopeNum == 3)
            {
                horoscope = "Pig";
            }
            else if (horoscopeNum == 4)
            {
                horoscope = "Rat";
            }
            else if (horoscopeNum == 5)
            {
                horoscope = "Ox";
            }
            else if (horoscopeNum == 6)
            {
                horoscope = "Tiger";
            }
            else if (horoscopeNum == 7)
            {
                horoscope = "Rabbit";
            }
            else if (horoscopeNum == 8)
            {
                horoscope = "Dragon";
            }
            else if (horoscopeNum == 9)
            {
                horoscope = "Snake";
            }
            else if (horoscopeNum == 10)
            {
                horoscope = "Horse";
            }
            else if (horoscopeNum == 11)
            {
                horoscope = "Sheep";
            }
            else
            {
                horoscope = "Error";
            }
            return horoscope;
        }
        public string GeneratePersonality(int bloodTypeNum)
        {
            //Returns personality type based on bloodTypeNum
            string personality = "";
            if (bloodTypeNum == 0)
            {
                personality = "Well-Organized";
            }
            else if (bloodTypeNum == 1)
            {
                personality = "Optimistic";
            }
            else if (bloodTypeNum == 2)
            {
                personality = "Creative";
            }
            else if (bloodTypeNum == 3)
            {
                personality = "Eccentric";
            }
            else if (bloodTypeNum == 4)
            {
                personality = "Unique";
            }
            else
            {
                personality = "Error";
            }
            return personality;
        }
        public int GenerateLuckyNumber(int bloodTypeNum, int horoscopeNum, int fortuneCookieNum)
        {
            //Generates luckyNumber via formula and returns luckyNumber
            int luckyNumber = (horoscopeNum * fortuneCookieNum) + bloodTypeNum;
            return luckyNumber;
        }
    }
}
