using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_3
{
    public partial class Form1 : Form
    {
        public const int numGames = 20;
        public Game[] gamesListArray = new Game[numGames];
        public int currentGame = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public class Game
        {
            //Variables to keep track of
            public string title;
            public string genre;
            public int players;
            public string publisher;
            public string console;
            public bool onlineGameplay;
            public bool inGamePurchases;
            public decimal price;
            public string description;

        }
        public void AddGame(Game game, Game[] gameList, int index)
        {
            //Add the game to the array
            gameList[index] = game;
            //change index of current game
            currentGame++;
        }
        public void RemoveGame()
        {
            int gameToDelete = gameListBox.SelectedIndex;
            //proceed only if a game is actually selected
            if (!(gameToDelete == -1))
            {
                //clear game information text
                gameInfo.Text = "";
                //starting with game to delete, move all items back one index
                for (int i = gameListBox.SelectedIndex; i < gamesListArray.Length - 1; i++)
                {
                    gamesListArray[i] = gamesListArray[i + 1];
                }
                //remove item from listbox
                gameListBox.Items.Remove(gameListBox.SelectedItem);
                //change index of current game
                currentGame--;
            }
            //otherwise, display a message explaining that a game needs to be selected
            else
            {
                MessageBox.Show("Select a game to remove");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Clear any text on the game list, just in case
            gameListBox.Text = "";
            //Add some default games
            Game defaultGame1 = new Game
            {
                title = "Soul of Azrael",
                publisher = "ScribeEzra",
                genre = "RPG",
                console = "PC",
                players = 1,
                price = 15.00m,
                onlineGameplay = false,
                inGamePurchases = false,
                description = "Ezra has always been a loyal scribe in the royal court of Babylia until an ancient enemy, believed to be long dead, made a sudden return. " +
                "Now Ezra must journey to find and retrieve the Babylian Princess in a far away land and search for a way to protect their beloved kingdom from a catastrophic demise."
            };

            //Add game to the aray
            AddGame(defaultGame1, gamesListArray, currentGame);
            //Add game title to listbox
            gameListBox.Items.Add(defaultGame1.title);

            Game defaultGame2 = new Game
            {
                title = "Heart of the Ocean",
                publisher = "ScribeEzra",
                genre = "Point-And-Click",
                console = "PC",
                players = 1,
                price = 15.00m,
                onlineGameplay = false,
                inGamePurchases = false,
                description = "It's been years since Nathaniel was found washed up on the shore of the island. Ever since then, he's been building up a new life for himself." +
                " One day, a group of new visitors arive on the island and they seem to be the key to Nathaniel's amnesiatic memories."
            };

            //Add game to the aray
            AddGame(defaultGame2, gamesListArray, currentGame);
            //Add game title to listbox
            gameListBox.Items.Add(defaultGame2.title);

            Game defaultGame3 = new Game
            {
                title = "The Catalyst",
                publisher = "ScribeEzra",
                genre = "Visual Novel",
                console = "PC",
                players = 1,
                price = 15.00m,
                onlineGameplay = false,
                inGamePurchases = false,
                description = "The world is full of fortresses in which citizens take refuge from mutated beings, but the fortresses themselves have dark secrets." +
                " Is it truly the mutants that humanity must take refuge from? With three storylines to choose from, you can play as either Yuki, Iona, or Copper."
            };

            //Add game to the aray
            AddGame(defaultGame3, gamesListArray, currentGame);
            //Add game title to listbox
            gameListBox.Items.Add(defaultGame3.title);
        }

        private void addGameButton_Click(object sender, EventArgs e)
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

            //if max number of games are in the array, display a message
            if (currentGame >= 20)
            {
                MessageBox.Show("No more games can be added at this time");
            }
            //if one or all of the textboxes are blank, display a message
            else if (inputTitle.Text == "" || inputConsole.Text == "" || inputPublisher.Text == "" || inputGenre.Text == "" || inputDescription.Text == "")
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
            else if (!(decimal.TryParse(inputPrice.Text, out gamePrice)) || !(int.TryParse(inputPlayers.Text, out gamePlayers)))
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

                //define game via collected information
                Game game = new Game { title = gameTitle, console = gameConsole, publisher = gamePublisher, price = gamePrice, players = gamePlayers, genre = gameGenre, inGamePurchases = gameInGamePurchases, onlineGameplay = gameOnlineGameplay, description = gameDescription };
                //Add game to the aray
                AddGame(game, gamesListArray, currentGame);
                //Add game title to listbox
                gameListBox.Items.Add(game.title);
            };
            
        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            //simply redirects to RemoveGame() method
            RemoveGame();
        }

        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display game information, showing that it's been stored properly
                gameInfo.Text = gamesListArray[gameListBox.SelectedIndex].title + "(" + gamesListArray[gameListBox.SelectedIndex].genre + ")" + " $" + gamesListArray[gameListBox.SelectedIndex].price  + Environment.NewLine +
                "published by " + gamesListArray[gameListBox.SelectedIndex].publisher + " for the " + gamesListArray[gameListBox.SelectedIndex].console +
                ". " + gamesListArray[gameListBox.SelectedIndex].players + " player(s), In-Game Purchase: " + gamesListArray[gameListBox.SelectedIndex].inGamePurchases
                + " Online: " + gamesListArray[gameListBox.SelectedIndex].onlineGameplay + Environment.NewLine +
                 Environment.NewLine + gamesListArray[gameListBox.SelectedIndex].description;
            }
            catch
            {
                //if selected item is deleted, default to blank text
                gameInfo.Text = "";
            }
        }

        private void gameSearchButton_Click(object sender, EventArgs e)
        {
            //User must type something
            if (gameSearch.Text == "")
            {
                MessageBox.Show("Invalid input");
            }
            else
            {
                if (searchingTitle.Checked)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = gameListBox.SelectedIndex + 1; i < currentGame; i++)
                    {
                        if (gamesListArray[i].title == gameSearch.Text)
                        {
                            //if there is a match, select item
                            gameListBox.SelectedIndex = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else if (searchingConsole.Checked)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = gameListBox.SelectedIndex + 1; i < currentGame; i++)
                    {
                        if (gamesListArray[i].console == gameSearch.Text)
                        {
                            //if there is a match, select item
                            gameListBox.SelectedIndex = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else if (searchingPublisher.Checked)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = gameListBox.SelectedIndex + 1; i < currentGame; i++)
                    {
                        if (gamesListArray[i].publisher == gameSearch.Text)
                        {
                            //if there is a match, select item
                            gameListBox.SelectedIndex = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else if (searchingGenre.Checked)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = gameListBox.SelectedIndex + 1; i < currentGame; i++)
                    {
                        if (gamesListArray[i].genre == gameSearch.Text)
                        {
                            //if there is a match, select item
                            gameListBox.SelectedIndex = i;
                            //break after first item found
                            break;
                        }
                    }
                }
            }
        }
    }
}
