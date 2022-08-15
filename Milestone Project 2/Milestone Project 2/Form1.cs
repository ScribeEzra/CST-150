using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone_Project_2
{

    public partial class libraryOfGames : Form
    {
        //These variables and array are placed here to better keep track of them
        public const int numGames = 20;
        public Game[] gamesListArray = new Game[numGames];
        public int currentGame = 0;
        public libraryOfGames()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Clear any text on the game list, just in case
            gameList.Text = "";
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            //these variables are used to put the textbox information into
            string gameTitle;
            string gameConsole;
            string gamePublisher;
            decimal gamePrice;

            //if max number of games are in the array, display a message
            if (currentGame >= 20)
            {
                MessageBox.Show("No more games can be added at this time");
            }
            //if one or all of the textboxes are blank, display a message
            else if (inputTitle.Text == "" || inputConsole.Text == "" || inputPublisher.Text == "")
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
                else
                {
                    inputConsole.Focus();
                }
            }
            //if price can't be parsed, display a message
            else if (!(decimal.TryParse(inputPrice.Text, out gamePrice)))
            {
                MessageBox.Show("Invalid Input");
                inputPrice.Focus();
            }
            //if none of the previous issues occur, continue on to add the game
            else
            {
                //place information into the correct fields
                gameTitle = inputTitle.Text;
                gameConsole = inputConsole.Text;
                gamePublisher = inputPublisher.Text;

                //define game via collected information
                Game game = new Game { title = gameTitle, console = gameConsole, publisher = gamePublisher, price = gamePrice };
                //Add game to the aray
                AddGame(game, gamesListArray, currentGame);
                //Add game title to listbox
                gameList.Items.Add(game.title);

            }

        }

        public class Game
        {
            //Only four variables to kep track of for now
            //More will be added later
            public string title;
            public string publisher;
            public string console;
            public decimal price;

        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display game information, showing that it's been stored properly
                gameInfo.Text = gamesListArray[gameList.SelectedIndex].title + Environment.NewLine +
                "published by " + gamesListArray[gameList.SelectedIndex].publisher + " for the " +
                gamesListArray[gameList.SelectedIndex].console + "." + Environment.NewLine +
                "$" + gamesListArray[gameList.SelectedIndex].price;
            }
            catch
            {
                //if selected item is deleted, default to blank text
                gameInfo.Text = "";
            }
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
            int gameToDelete = gameList.SelectedIndex;
            //proceed only if a game is actually selected
            if (!(gameToDelete == -1))
            {
                //clear game information text
                gameInfo.Text = "";
                //starting with game to delete, move all items back one index
                for (int i = gameList.SelectedIndex; i < gamesListArray.Length - 1; i++)
                {
                    gamesListArray[i] = gamesListArray[i + 1];
                }
                //remove item from listbox
                gameList.Items.Remove(gameList.SelectedItem);
                //change index of current game
                currentGame--;
            }
            //otherwise, display a message explaining that a game needs to be selected
            else
            {
                MessageBox.Show("Select a game to remove");
            }
        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            //simply redirects to RemoveGame() method
            RemoveGame();
        }
    }
    
}
