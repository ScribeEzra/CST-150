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
    public partial class luckyNumberPopupForm : Form
    {
        public luckyNumberPopupForm()
        {
            InitializeComponent();
        }

        private void luckyNumberPopupForm_Load(object sender, EventArgs e)
        {
            //Opens and reads lucky number to display it
            StreamReader inputFile = File.OpenText("LuckyNumber.txt");
            string luckyNumber = inputFile.ReadLine();
            inputFile.Close();
            luckyNumDisplay.Text = luckyNumber;
        }
    }
}
