using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace Hangman
{
    class Program
    {
        private static void printHangman(int wrong)
        {
            if (wrong == 0)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("     |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine("      |");
                Console.WriteLine("      |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 2)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine(" |    |");
                Console.WriteLine("      |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 3)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine("/|    |");
                Console.WriteLine("      |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 4)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine("/|\\   |");
                Console.WriteLine("      |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine("/|\\   |");
                Console.WriteLine("/     |");
                Console.WriteLine("    ===");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("\n+---+");
                Console.WriteLine(" O    |");
                Console.WriteLine("/|\\   |");
                Console.WriteLine("/ \\   |");
                Console.WriteLine("    ===");
            }

        }

        private static int printWord(List<char> guessedLetters, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }

        private static void printLines(String randomWord)
        {
            Console.Write("\r");
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305  ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hangman!");
            Console.WriteLine("-----------------------------------");

            Random random = new Random();
            List<String> wordDictionary = new List<String> { "house", "bedroom", "stairs", "balcony", "garden", "flower", "grass", "waves" };
            int index = random.Next(wordDictionary.Count);
            String randomWord = wordDictionary[index];

            foreach (char x in randomWord)
            {
                Console.WriteLine("_  ");
            }

            int lengthOfWordToGuess = randomWord.Length;
            int amountOfTimesWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;

            while (amountOfTimesWrong != 6 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }

                //prompt user for input
                Console.Write("\nGuess a letter: ");
                char LetterGuessed = Console.ReadLine()[0];
                //basically check if the letter has already been guessed
                if (currentLettersGuessed.Contains(LetterGuessed))
                {
                    Console.Write("\r\nYou have already guessed this letter.");
                    printHangman(amountOfTimesWrong);
                    currentLettersRight = printWord(currentLettersGuessed, randomWord);
                    printLines(randomWord);
                }
                else
                {
                    // check if letter is in the word
                    bool right = false;
                    for (int i = 0; i < randomWord.Length; i++)
                    {
                        if (LetterGuessed == randomWord[i]) { right = true; }
                        if (right)
                        {

                            printHangman(amountOfTimesWrong);
                            currentLettersGuessed.Add(LetterGuessed);
                            currentLettersRight = printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            printLines(randomWord);
                        }
                        else
                        {
                            amountOfTimesWrong++;
                            currentLettersGuessed.Add(LetterGuessed);
                            printHangman(amountOfTimesWrong);
                            currentLettersRight = printWord(currentLettersGuessed, randomWord);
                            Console.Write("\r\n");
                            printLines(randomWord);
                        }
                    }
                }
                Console.WriteLine("\r\nGame is Over! Thank you for playing :)");
            }
        }
    }
}
