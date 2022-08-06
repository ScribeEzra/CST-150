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

namespace Activity_5
{
    public partial class fileInputTestForm : Form
    {
        public fileInputTestForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFromFile;
            StreamWriter outputToFile;
            openInputFileDialog.ShowDialog();
            if (openInputFileDialog.ShowDialog() == DialogResult.OK)
            {
                inputFromFile = File.OpenText(openInputFileDialog.FileName);
                outputToFile = File.CreateText("Test Output.txt");
                string dataFromFile = "";

                string wordList = "";

                string firstAlphabetizedWord = "";
                string lastAlphabetizedWord = "";
                string longestWord = "";

                int mostVowelsInMostVowelWord = 0;
                int vowelCount;
                string mostvowelWord = "";

                while (!inputFromFile.EndOfStream)
                {
                    //Obtain a line from the input file and convert it to lower case
                    dataFromFile = inputFromFile.ReadLine().ToLower();
                    //Show the line

                    wordList = (wordList + Environment.NewLine + dataFromFile);
                    wordListLabel.Text = wordList;

                    //Comparison tests
                    if (firstAlphabetizedWord == "")
                    {
                        firstAlphabetizedWord = dataFromFile;
                    }
                    else if (string.Compare(dataFromFile, firstAlphabetizedWord) == -1)
                    {
                        firstAlphabetizedWord = dataFromFile;
                    }
                    if (lastAlphabetizedWord == "")
                    {
                        lastAlphabetizedWord = dataFromFile;
                    }
                    else if (string.Compare(dataFromFile, lastAlphabetizedWord) == 1)
                    {
                        lastAlphabetizedWord = dataFromFile;
                    }
                    if (longestWord == "")
                    {
                        longestWord = dataFromFile;
                    }
                    else if (dataFromFile.Length > longestWord.Length)
                    {
                        longestWord = dataFromFile;
                    }
                    vowelCount = 0;
                    for (int i = 0; i < dataFromFile.Length; i++)
                    {
                        if (dataFromFile[i] == 'a' || dataFromFile[i] == 'e' ||
                            dataFromFile[i] == 'i' || dataFromFile[i] == 'o' ||
                            dataFromFile[i] == 'u')
                        {
                            vowelCount++;
                        }
                    }
                    if (mostVowelsInMostVowelWord == 0)
                    {
                        mostVowelsInMostVowelWord = vowelCount;
                        mostvowelWord = dataFromFile;
                    }
                    else if (vowelCount > mostVowelsInMostVowelWord)
                    {
                        mostVowelsInMostVowelWord = vowelCount;
                        mostvowelWord = dataFromFile;
                    }


                    //Output the lowercase string to a file
                    outputToFile.WriteLine(dataFromFile);
                }

                //Show comparison results
                firstAlphabetizedLabel.Text = ("First Alphabetically: " + firstAlphabetizedWord);
                lastAlphabetizedLabel.Text = ("Last Alphabetically: " + lastAlphabetizedWord);
                longestWordLabel.Text = ("Longest Word: " + longestWord);
                mostVowelsLabel.Text = ("Most Vowels: " + mostvowelWord);

                //Output Comparison Results
                outputToFile.WriteLine("First Alphabetically: " + firstAlphabetizedWord);
                outputToFile.WriteLine("Last Alphabetically: " + lastAlphabetizedWord);
                outputToFile.WriteLine("Longest Word: " + longestWord);
                outputToFile.WriteLine("Most Vowels: " + mostvowelWord);

                //Close files
                inputFromFile.Close();
                outputToFile.Close();
            }
            else
            {
                MessageBox.Show("Canceled File Load");
            }
        }

        private void fileInputTestForm_Load(object sender, EventArgs e)
        {
            //Clear Labels on Load
            wordListLabel.Text = "";
            firstAlphabetizedLabel.Text = "";
            lastAlphabetizedLabel.Text = "";
            longestWordLabel.Text = "";
            mostVowelsLabel.Text = "";
        }
    }
}
