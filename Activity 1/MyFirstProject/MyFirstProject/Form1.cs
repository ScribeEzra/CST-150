using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class startupMenu : Form
    {
        public startupMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ezra, a scribe in the court of Babylia, who was sent after Princess Kira far away in another country.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aoi, Priestess of the mountain shrine, found hiding away in the Darkwood Grove to escape her unwanted fate.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void kiraBio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kira, Crown Princess of Babylia, gone on a journey to become strong enough to protect her Kingdom");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Anne, heiress to the pirate kingdom of Arabella, sworn to prove her worth to her father, the current Pirate Lord");
        }

        private void elvarBio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Elvar, a decendant from a long line of hunters who prides himself on his bard skills, journeying to find inspiration for his songs");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel, a half-demon ruler of a country neghboring Babylia,wishes to right the wrongs he has committed in a pointless war");
        }
    }
}
