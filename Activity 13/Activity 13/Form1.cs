using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_13
{
    public partial class Form1 : Form
    {
        //Setting up array and related variables
        int[,] gameGridArray = new int[3, 3];
        int row;
        int column;

        //Bool values that determine gameplay behavior
        public bool gameOver = false;
        public bool playerTurn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //Clearing the board
            gameGrid1_1.Text = "";
            gameGrid1_2.Text = "";
            gameGrid1_3.Text = "";
            gameGrid2_1.Text = "";
            gameGrid2_2.Text = "";
            gameGrid2_3.Text = "";
            gameGrid3_1.Text = "";
            gameGrid3_2.Text = "";
            gameGrid3_3.Text = "";
            winLabel.Text = "";

            //make all elements in array -1
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameGridArray[i, j] = -1;
                }
            }
            //reset the bool values to allow for gameplay
            gameOver = false;
            playerTurn = true;

        }

        public void AddX(int row, int column, int[,] arr)
        {
            //if there is no X or O, place an X
            if (!(arr[row, column] == 0) && !(arr[row, column] == 1))
            {
                arr[row, column] = 1;
                ShowX(row, column);
                //Check to see if the change causes a win
                CheckForWin();
                playerTurn = false;
                ComputerTurn(gameGridArray);
            }
            else
            {
                //Lets user know that they can't place an X in that box
                winLabel.Text = "Invalid Choice";
            }
        }

        private void gameGrid1_1_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 0;
                column = 0;
                AddX(row, column, gameGridArray);
            }

        }

        private void gameGrid1_2_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 0;
                column = 1;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid1_3_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 0;
                column = 2;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid2_1_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 1;
                column = 0;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid2_2_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 1;
                column = 1;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid2_3_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 1;
                column = 2;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid3_1_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 2;
                column = 0;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid3_2_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 2;
                column = 1;
                AddX(row, column, gameGridArray);
            }
        }

        private void gameGrid3_3_Click(object sender, EventArgs e)
        {
            //If it's the players turn and the game isn't over
            //Checks row and column to see if an X can be placed there
            if (playerTurn && !(gameOver))
            {
                row = 2;
                column = 2;
                AddX(row, column, gameGridArray);
            }
        }

        public void ComputerTurn(int[,] arr)
        {
            //If the game isn't over
            if (!gameOver)
            {
                //Create a random object
                Random rand = new Random();
                //If it's not the players turn
                while (!playerTurn)
                {
                    //Generate two random numbers with 10 milliseconds in between to prevent them from being the same
                    row = rand.Next(1, 3);
                    System.Threading.Thread.Sleep(10);
                    column = rand.Next(0, 3);

                    //If there is no X or O, place an O, if not, then continue loop
                    if (!(arr[row, column] == 0) && !(arr[row, column] == 1))
                    {
                        arr[row, column] = 0;
                        ShowO(row, column);
                        //Check to see if the change causes a win
                        CheckForWin();
                        playerTurn = true;
                    }
                }
            }
            
        }
        public void ShowX(int row, int column)
        {
            //various if branches to show an X on the correct box
            if (row == 0 && column == 0)
            {
                gameGrid1_1.Text = "X";
            }
            if (row == 0 && column == 1)
            {
                gameGrid1_2.Text = "X";
            }
            if (row == 0 && column == 2)
            {
                gameGrid1_3.Text = "X";
            }
            if (row == 1 && column == 0)
            {
                gameGrid2_1.Text = "X";
            }
            if (row == 1 && column == 1)
            {
                gameGrid2_2.Text = "X";
            }
            if (row == 1 && column == 2)
            {
                gameGrid2_3.Text = "X";
            }
            if (row == 2 && column == 0)
            {
                gameGrid3_1.Text = "X";
            }
            if (row == 2 && column == 1)
            {
                gameGrid3_2.Text = "X";
            }
            if (row == 2 && column == 2)
            {
                gameGrid3_3.Text = "X";
            }
        }
        public void ShowO(int row, int column)
        {
            //various if branches to show an O on the correct box
            if (row == 0 && column == 0)
            {
                gameGrid1_1.Text = "O";
            }
            if (row == 0 && column == 1)
            {
                gameGrid1_2.Text = "O";
            }
            if (row == 0 && column == 2)
            {
                gameGrid1_3.Text = "O";
            }
            if (row == 1 && column == 0)
            {
                gameGrid2_1.Text = "O";
            }
            if (row == 1 && column == 1)
            {
                gameGrid2_2.Text = "O";
            }
            if (row == 1 && column == 2)
            {
                gameGrid2_3.Text = "O";
            }
            if (row == 2 && column == 0)
            {
                gameGrid3_1.Text = "O";
            }
            if (row == 2 && column == 1)
            {
                gameGrid3_2.Text = "O";
            }
            if (row == 2 && column == 2)
            {
                gameGrid3_3.Text = "O";
            }
        }
        public void CheckForWin()
        {
            //Various nested if branches to check for a win
            if (gameGridArray[0, 0] == gameGridArray[0, 1] && gameGridArray[0, 0] == gameGridArray[0, 2] && !(gameGridArray[0,0] == -1))
            {
                if (gameGridArray[0, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[0, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;

            }
            if (gameGridArray[0, 0] == gameGridArray[1, 1] && gameGridArray[0, 0] == gameGridArray[2, 2] && !(gameGridArray[0, 0] == -1))
            {
                if (gameGridArray[0, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[0, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[0, 2] == gameGridArray[1, 1] && gameGridArray[0, 2] == gameGridArray[2, 0] && !(gameGridArray[0, 2] == -1))
            {
                if (gameGridArray[0, 2] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[0, 2] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[1, 0] == gameGridArray[1, 1] && gameGridArray[1, 0] == gameGridArray[1, 2] && !(gameGridArray[1, 0] == -1))
            {
                if (gameGridArray[1, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[1, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[2, 0] == gameGridArray[2, 1] && gameGridArray[2, 0] == gameGridArray[2, 2] && !(gameGridArray[2, 0] == -1))
            {
                if (gameGridArray[2, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[2, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[0, 0] == gameGridArray[1, 0] && gameGridArray[0, 0] == gameGridArray[2, 0] && !(gameGridArray[0, 0] == -1))
            {
                if (gameGridArray[0, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[0, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[1, 0] == gameGridArray[1, 1] && gameGridArray[1, 0] == gameGridArray[1, 2] && !(gameGridArray[1, 0] == -1))
            {
                if (gameGridArray[1, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[1, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }
            if (gameGridArray[2, 0] == gameGridArray[2, 1] && gameGridArray[2, 0] == gameGridArray[2, 2] && !(gameGridArray[2, 0] == -1))
            {
                if (gameGridArray[2, 0] == 1)
                {
                    winLabel.Text = "X Wins!";
                }
                if (gameGridArray[2, 0] == 0)
                {
                    winLabel.Text = "O Wins!";
                }
                gameOver = true;
                playerTurn = false;
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Exit the form
            this.Close();
        }
    }
}
