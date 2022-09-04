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
    public partial class gameLibraryForm : Form
    {
        //variable for multiple methods to keep track of
        public const int numGames = 100;
        //Switching from Array to List
        //public Game[] gamesListArray = new Game[numGames];
        public List<Game> gamesList = new List<Game>(numGames);
        //Library defaultLibrary = new Library();

        public int currentGame = 0;

        //keep track of the index of discovered duplicates in array
        public int duplicateIndex;
        public gameLibraryForm()
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
        //starting to set up library class
        //public class Library
        //{
            //public List<Game> gamesList;
            //public int currentGame;
            //public int duplicateIndex;
            //public int selectedGame;
            
        //}

        //------------------------------------------------------------------------------------------------------//
        //                                           Methods                                                    //
        //------------------------------------------------------------------------------------------------------//
        public void AddGame(Game game, List<Game> gameList, int index)
        {
            //Add the game to the array
            gameList.Add(game);
            //change index of current game
            currentGame++;
            //Refreshes game information
            DisplayInfo();
        }
        public void RemoveGame()
        {
            //take note of the selected game's index and name
            int gameToDelete = gameListBox.SelectedIndex;
            string gameToDeleteName = gameListBox.SelectedItem.ToString();

            //proceed only if a game is actually selected
            if (!(gameToDelete == -1))
            {
                //if there is at least one in quantity...
                if (gamesList[gameToDelete].quantity >= 1)
                {
                    //lower quantity by 1
                    gamesList[gameToDelete].quantity -= 1;
                }
            }
            //otherwise, display a message explaining that a game needs to be selected
            else
            {
                MessageBox.Show("Select a game to remove");
            }
            //Refreshes game information
            DisplayInfo();
        }
        public void RestockGame()
        {
            //take note of the selected game's index
            int gameToRestock = gameListBox.SelectedIndex;
            if (!(gameToRestock == -1))
            {
                //adds 1 to the quantity
                gamesList[gameToRestock].quantity += 1;
            }
            else
            {
                //alerts user to select a game to restock
                MessageBox.Show("Select a game to restock");
            }
            //Refreshes game information
            DisplayInfo();
        }
        private bool CheckForDuplicate(Game game)
        {
            //this bool stays false if no duplicate is found
            bool hasDuplicate = false;
            SetDuplicateIndex(0);
            //Searches through all games in array
            for (int i = 0; i < currentGame; i++)
            {
                //Tests for 4 important duplicate criteria- doesn't require every single detail to be the same
                if ((game.title == gamesList[i].title) &&
                    (game.console == gamesList[i].console) &&
                    (game.publisher == gamesList[i].publisher) &&
                    (game.price == gamesList[i].price))
                {
                    //takes note of duplicate's index and sets hasDuplicate to true
                    SetDuplicateIndex(i);
                    hasDuplicate = true;
                }
            }

            return hasDuplicate;
        }
        private void SetDuplicateIndex(int i)
        {
            //takes note of duplicate's index
            duplicateIndex = i;
        }
        public void DisplayInfo()
        {
            try
            {
                //display game information, showing that it's been stored properly
                gameInfo.Text = gamesList[gameListBox.SelectedIndex].title + "(" + gamesList[gameListBox.SelectedIndex].genre + ")" + " $" + gamesList[gameListBox.SelectedIndex].price +
                " (" + gamesList[gameListBox.SelectedIndex].quantity + " copies)" + Environment.NewLine +
                "published by " + gamesList[gameListBox.SelectedIndex].publisher + " for the " + gamesList[gameListBox.SelectedIndex].console +
                ". " + gamesList[gameListBox.SelectedIndex].players + " player(s), In-Game Purchase: " + gamesList[gameListBox.SelectedIndex].inGamePurchases
                + " Online: " + gamesList[gameListBox.SelectedIndex].onlineGameplay + Environment.NewLine +
                 Environment.NewLine + gamesList[gameListBox.SelectedIndex].description;
            }
            catch
            {
                //if selected item is deleted, default to blank text
                gameInfo.Text = "";
            }
        }
        public void SearchGame()
        {
            if (searchingTitle.Checked)
            {
                //Search startging after the selected index and end at last item
                //The +1 also ensures that the selected index starts at the beginning if nothing selected
                for (int i = gameListBox.SelectedIndex + 1; i < currentGame; i++)
                {
                    if (gamesList[i].title == gameSearch.Text)
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
                    if (gamesList[i].console == gameSearch.Text)
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
                    if (gamesList[i].publisher == gameSearch.Text)
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
                    if (gamesList[i].genre == gameSearch.Text)
                    {
                        //if there is a match, select item
                        gameListBox.SelectedIndex = i;
                        //break after first item found
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Nothing Found");
            }

        }
        //public void SetSelectedGame(int index)
        //{
            //selectedGame = index;
        //}

        //------------------------------------------------------------------------------------------------------//
        //                                        Event Handlers                                                //
        //------------------------------------------------------------------------------------------------------//
        private void Form1_Load(object sender, EventArgs e)
        {
            //Clear any text on the game list, just in case
            gameListBox.Text = "";

            //Clear game.txt
            StreamWriter addGame = File.CreateText("game.txt");
            addGame.WriteLine("");
            addGame.Close();

            

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
                "Now Ezra must journey to find and retrieve the Babylian Princess in a far away land and search for a way to protect their beloved kingdom from a catastrophic demise.",
                quantity = 12
            };

            //Add game to the aray
            AddGame(defaultGame1, gamesList, currentGame);
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
                " One day, a group of new visitors arive on the island and they seem to be the key to Nathaniel's amnesiatic memories.",
                quantity = 12
            };

            //Add game to the aray
            AddGame(defaultGame2, gamesList, currentGame);
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
                " Is it truly the mutants that humanity must take refuge from? With three storylines to choose from, you can play as either Yuki, Iona, or Copper.",
                quantity = 12
            };

            //Add game to the aray
            AddGame(defaultGame3, gamesList, currentGame);
            //Add game title to listbox
            gameListBox.Items.Add(defaultGame3.title);
        }

        private void addGameButton_Click(object sender, EventArgs e)
        {
            //Now pops up a new window to allow user to add a game
            addAGameForm addGame = new addAGameForm();
            //ShowDialog pauses parent form as opposed to just Show
            addGame.ShowDialog(); 

            //Needed a try catch so that no game is added if no information is provided
            try
            {
                //Reads files from game.txt to create game
                StreamReader gameToAdd = File.OpenText("game.txt");
                string gameTitle = gameToAdd.ReadLine();
                string gameConsole = gameToAdd.ReadLine();
                string gamePublisher = gameToAdd.ReadLine();
                string gameGenre = gameToAdd.ReadLine();
                string boolTest = gameToAdd.ReadLine();
                bool gameInGamePurchases;
                if (boolTest == "1")
                {
                    gameInGamePurchases = true;
                }
                else
                {
                    gameInGamePurchases = false;
                }
                boolTest = gameToAdd.ReadLine();
                bool gameOnlineGameplay;
                if (boolTest == "1")
                {
                    gameOnlineGameplay = true;
                }
                else
                {
                    gameOnlineGameplay = false;
                }

                string gameDescription = gameToAdd.ReadLine();
                decimal gamePrice = decimal.Parse(gameToAdd.ReadLine());
                int gamePlayers = int.Parse(gameToAdd.ReadLine());
                int gameQuantity = int.Parse(gameToAdd.ReadLine());

                //creates game based on information read on game.txt
                Game game = new Game
                {
                    title = gameTitle,
                    console = gameConsole,
                    publisher = gamePublisher,
                    genre = gameGenre,
                    inGamePurchases = gameInGamePurchases,
                    onlineGameplay = gameOnlineGameplay,
                    description = gameDescription,
                    price = gamePrice,
                    players = gamePlayers,
                    quantity = gameQuantity
                };

                //Add game to the aray
                if (CheckForDuplicate(game))
                {
                    gamesList[duplicateIndex].quantity += 1;
                }
                else
                {
                    AddGame(game, gamesList, currentGame);
                    //Add game title to listbox
                    gameListBox.Items.Add(game.title);
                }
            }
            catch
            {
                MessageBox.Show("Game Not Added");
            }
            

        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            //simply redirects to RemoveGame() method
            RemoveGame();
        }

        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshed info every time there is a changed index
            int index = gameListBox.SelectedIndex;
            DisplayInfo();
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
                //Now redirects to SearchGame() method
                SearchGame();
            }
        }
        private void restockButton_Click(object sender, EventArgs e)
        {
            //Simply redirects to the RestockGame() method
            //Adds 1 to the quantity
            RestockGame();
        }
    }
}
