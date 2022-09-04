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

namespace Milestone_3
{
    public partial class addAGameForm : Form
    {
        public addAGameForm()
        {
            InitializeComponent();
        }
        public class Game
        {
            //Game Criteria
            public string title;
            public string genre;
            public int players;
            public string publisher;
            public string console;
            public bool onlineGameplay;
            public bool inGamePurchases;
            public decimal price;
            public string description;

            //keep track of how many are in stock
            public int quantity;
        }

        private void addAGameForm_Load(object sender, EventArgs e)
        {

        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            {
                //these variables are used to put the textbox information into
                string gameTitle;
                string gameGenre;
                int gamePlayers;
                string gameConsole;
                string gamePublisher;
                bool gameOnlineGameplay;
                bool gameInGamePurchases;
                decimal gamePrice;
                string gameDescription;
                int gameQuantity;

                //if one or all of the textboxes are blank, display a message
                if (inputTitle.Text == "" || inputConsole.Text == "" || inputPublisher.Text == "" || inputGenre.Text == "" || inputDescription.Text == "")
                {
                    MessageBox.Show("Must fill out all fields");
                    //change focus to first item that needs attention
                    if (inputTitle.Text == "")
                    {
                        inputTitle.Focus();
                    }
                    else if (inputConsole.Text == "")
                    {

                        inputConsole.Focus();
                    }
                    else if (inputPublisher.Text == "")
                    {
                        inputPublisher.Focus();
                    }
                    else if (inputGenre.Text == "")
                    {
                        inputGenre.Focus();
                    }
                    else
                    {
                        inputDescription.Focus();
                    }
                }
                //if price or players can't be parsed, display a message and focus on first that needs to be fixed
                else if (!(decimal.TryParse(inputPrice.Text, out gamePrice)) || !(int.TryParse(inputPlayers.Text, out gamePlayers))|| !(int.TryParse(inputQuantity.Text, out gameQuantity)))
                {
                    MessageBox.Show("Invalid Input");
                    if (!decimal.TryParse(inputPrice.Text, out gamePrice))
                    {
                        inputPrice.Focus();
                    }
                    else
                    {
                        inputPlayers.Focus();
                    }
                }
                //if none of the previous issues occur, continue on to add the game
                else
                {
                    //place information into the correct fields
                    gameTitle = inputTitle.Text;
                    gameConsole = inputConsole.Text;
                    gamePublisher = inputPublisher.Text;
                    gameGenre = inputGenre.Text;
                    gameInGamePurchases = inputInGamePurchases.Checked;
                    gameOnlineGameplay = inputOnlineGameplay.Checked;
                    gameDescription = inputDescription.Text;

                    //Writes information to game.txt
                    StreamWriter addGame = File.CreateText("game.txt");
                    addGame.WriteLine(gameTitle);
                    addGame.WriteLine(gameConsole);
                    addGame.WriteLine(gamePublisher);
                    addGame.WriteLine(gameGenre);
                    if (gameInGamePurchases)
                    {
                        addGame.WriteLine("1");
                    }
                    else
                    {
                        addGame.WriteLine("0");
                    }
                    if (gameOnlineGameplay)
                    {
                        addGame.WriteLine("1");
                    }
                    else
                    {
                        addGame.WriteLine("0");
                    }
                    addGame.WriteLine(gameDescription);
                    addGame.WriteLine(gamePrice);
                    addGame.WriteLine(gamePlayers);
                    addGame.WriteLine(gameQuantity);
                    addGame.Close();
                        
                    //Close this form and continue on parent form
                    this.Close();
                };

            }
        }
    }
}
