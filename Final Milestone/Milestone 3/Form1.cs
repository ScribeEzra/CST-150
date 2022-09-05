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

        //Switched from Array to List
        //public Game[] gamesListArray = new Game[numGames];
        //public List<Game> gamesList = new List<Game>(numGames);

        //Then switched from list to Library object containing List
        Library defaultLibrary = new Library();

        public gameLibraryForm()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------------------------------------------------//
        //                                       Classes                                                        //
        //------------------------------------------------------------------------------------------------------//
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
            public Image image;

            //keep track of how many are in stock
            public int quantity;
        }
        public class Library
        {
            public List<Game> gamesList = new List<Game>(numGames);
            public int currentGame;
            public int duplicateIndex;
            public int selectedGame;

            //------------------------------------------------------------------------------------------------------//
            //                               Library Class Methods                                                  //
            //------------------------------------------------------------------------------------------------------//
            public void AddGame(Game game)
            {
                //Add the game to the list
                gamesList.Add(game);
                //change index of current game
                currentGame++;
            }

            public void RemoveGame(int index)
            {

                //proceed only if a game is actually selected
                if (!(index == -1))
                {
                    //if there is at least one in quantity...
                    if (gamesList[index].quantity >= 1)
                    {
                        //lower quantity by 1
                        gamesList[index].quantity -= 1;
                    }
                }
                //otherwise, display a message explaining that a game needs to be selected
                else
                {
                    MessageBox.Show("Select a game to remove");
                }
            }
            public void RestockGame(int index)
            {
                //take note of the selected game's index
                if (!(index == -1))
                {
                    //adds 1 to the quantity
                    gamesList[index].quantity += 1;
                }
                else
                {
                    //alerts user to select a game to restock
                    MessageBox.Show("Select a game to restock");
                }
            }
            public string DisplayInfo(int index)
            {
                string gameInfo = "";
                try
                {
                    //display game information, showing that it's been stored properly
                    gameInfo = gamesList[index].title + "(" + gamesList[index].genre + ")" + " $" + gamesList[index].price +
                    " (" + gamesList[index].quantity + " copies)" + Environment.NewLine +
                    "published by " + gamesList[index].publisher + " for the " + gamesList[index].console +
                    ". " + gamesList[index].players + " player(s), In-Game Purchase: " + gamesList[index].inGamePurchases
                    + " Online: " + gamesList[index].onlineGameplay + Environment.NewLine +
                     Environment.NewLine + gamesList[index].description;
                }
                catch
                {
                    //if selected item is deleted, default to blank text
                    gameInfo = "";
                }
                return gameInfo;
            }
            public int SearchGame(int index, int criteria, string searchText)
            {
                int foundGame = -1;
                if (criteria == 0)
                {
                    //Search starting after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = index + 1; i < gamesList.Count; i++)
                    {
                        if (gamesList[i].title == searchText)
                        {
                            //if there is a match, select item
                            foundGame = i;
                            break;
                        }
                    }
                }
                else if (criteria == 1)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = index + 1; i < gamesList.Count; i++)
                    {
                        if (gamesList[i].genre == searchText)
                        {
                            //if there is a match, select item
                            foundGame = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else if (criteria == 2)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = index + 1; i < gamesList.Count; i++)
                    {
                        if (gamesList[i].console == searchText)
                        {
                            //if there is a match, select item
                            foundGame = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else if (criteria == 3)
                {
                    //Search startging after the selected index and end at last item
                    //The +1 also ensures that the selected index starts at the beginning if nothing selected
                    for (int i = index + 1; i < gamesList.Count; i++)
                    {
                        if (gamesList[i].publisher == searchText)
                        {
                            //if there is a match, select item
                            foundGame = i;
                            //break after first item found
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Nothing Found");
                }
                return foundGame;

            }
        }

        //------------------------------------------------------------------------------------------------------//
        //                                           Methods                                                    //
        //------------------------------------------------------------------------------------------------------//
        private bool CheckForDuplicate(Game game, Library library)
        {
            //this bool stays false if no duplicate is found
            bool hasDuplicate = false;
            SetDuplicateIndex(0, defaultLibrary);
            //Searches through all games in list
            for (int i = 0; i < library.currentGame; i++)
            {
                //Tests for 4 important duplicate criteria- doesn't require every single detail to be the same
                if ((game.title == library.gamesList[i].title) &&
                    (game.console == library.gamesList[i].console) &&
                    (game.publisher == library.gamesList[i].publisher) &&
                    (game.price == library.gamesList[i].price))
                {
                    //takes note of duplicate's index and sets hasDuplicate to true
                    SetDuplicateIndex(i, defaultLibrary);
                    hasDuplicate = true;
                }
            }

            return hasDuplicate;
        }
        private void SetDuplicateIndex(int i, Library library)
        {
            //takes note of duplicate's index
            library.duplicateIndex = i;
        }
        
        public void ChangeImage(Library library, int index)
        {
            try
            {
                if (!(library.gamesList[index].image == null))
                {
                    gameImage.BackgroundImage = library.gamesList[index].image;
                }
                else
                {
                    gameImage.BackgroundImage = Milestone_3.Properties.Resources.Game_Thumbnail;
                }
            }
            catch
            {
                gameImage.BackgroundImage = Milestone_3.Properties.Resources.Game_Thumbnail;
            }
        }

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
                quantity = 12,
                image = Milestone_3.Properties.Resources.SoulofAzrael
        };

            //Add game to the aray
            defaultLibrary.AddGame(defaultGame1);
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
                quantity = 12,
                image = Milestone_3.Properties.Resources.HeartoftheOcean
            };

            //Add game to the aray
            defaultLibrary.AddGame(defaultGame2);
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
                quantity = 12,
                image = Milestone_3.Properties.Resources.TheCatalyst
            };

            //Add game to the aray
            defaultLibrary.AddGame(defaultGame3);
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

                //Image uploads kept causing errors
                //It's too bad, I was hoping I could get it to function fully

                //string hasImage = gameToAdd.ReadLine();
                //Image gameImage;
                //if (hasImage == "1")
                //{
                //string image = gameToAdd.ReadLine();
                //gameImage = new Bitmap(image);
                //}
                //else
                //{
                //gameImage = null;
                //}
                gameToAdd.Close();

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
                    quantity = gameQuantity,
                    //image = gameImage
                };

                //Add game to the list
                if (CheckForDuplicate(game, defaultLibrary))
                {
                    defaultLibrary.gamesList[defaultLibrary.duplicateIndex].quantity += 1;
                }
                else
                {
                    defaultLibrary.AddGame(game);
                    //Add game title to listbox
                    gameListBox.Items.Add(game.title);
                    defaultLibrary.currentGame++;
                }
            }
            catch
            {
                MessageBox.Show("Game Not Added");
            }
            //Refreshes game information
            int index = gameListBox.SelectedIndex;
            gameInfo.Text = defaultLibrary.DisplayInfo(index).ToString();


        }

        private void removeGameButton_Click(object sender, EventArgs e)
        {
            //obtains index and redirects to RemoveGame() method
            int gameToDelete = gameListBox.SelectedIndex;
            defaultLibrary.RemoveGame(gameToDelete);
            //Refreshes game information
            int index = gameListBox.SelectedIndex;
            gameInfo.Text = defaultLibrary.DisplayInfo(index).ToString();
        }

        private void gameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Refreshes game information
            int selectedIndex = gameListBox.SelectedIndex;
            gameInfo.Text = defaultLibrary.DisplayInfo(selectedIndex).ToString();
            ChangeImage(defaultLibrary, selectedIndex);

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
                //takes note of current selection
                int index = gameListBox.SelectedIndex;

                //takes note of criteria chosen
                int criteria;
                if (searchingTitle.Checked)
                {
                    criteria = 0;
                }
                else if (searchingGenre.Checked)
                {
                    criteria = 1;
                }
                else if (searchingConsole.Checked)
                {
                    criteria = 2;
                }
                else
                {
                    criteria = 3;
                }
                //takes note of text endtere
                string searchText = gameSearch.Text;

                //Now redirects to SearchGame() method with noted information
                gameListBox.SelectedIndex = defaultLibrary.SearchGame(index, criteria, searchText);
            }
        }
        private void restockButton_Click(object sender, EventArgs e)
        {
            //obtains index and redirects to restock game
            int gameToRestock = gameListBox.SelectedIndex;
            defaultLibrary.RestockGame(gameToRestock);
            //Refreshes game information
            //Refreshes game information
            int index = gameListBox.SelectedIndex;
            gameInfo.Text = defaultLibrary.DisplayInfo(index).ToString();
        }
    }
}
