using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Activity_12
{
    
    internal class Program
    {
        public static int Count(StreamReader file)
        {
            int wordCount;
            string currentChar = "";
            string prevChar;
            int wordLength;
            wordCount = 0;
            while (!file.EndOfStream)
            {
                prevChar = currentChar;
                currentChar = file.Read().ToString();
                wordLength = currentChar.Length;
                if (currentChar == "32")
                {
                    if (prevChar == "69" || prevChar == "84"|| prevChar == "101" || prevChar == "116")
                    {
                        wordCount++;
                    }
                }
            }
            return wordCount;
        }
        static void Main(string[] args)
        {
            StreamWriter outputFile = File.CreateText("file.txt");
            outputFile.WriteLine("Heart of ember autumntide cooling swiftly bleeding light smoldering softly biding time marching forward left behind");
            outputFile.Close();

            StreamReader inputFile = File.OpenText("file.txt");

            int numWords = Count(inputFile);

            Console.WriteLine("There are " + numWords.ToString() + " words that end in e or t.");

            inputFile.Close();
        }
    }
}
