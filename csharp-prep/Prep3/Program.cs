using System;

class Program
{
    static void Main(string[] args)

    {
        // While playAgain is true do the followwing
        bool playAgain;

        do
        {
            // Generate random number
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // While number has not been guessed continue prompting for guesses and count guesses
            bool guessedCorrectly = false;
            int numberOfGuesses = 0;

            while (!guessedCorrectly)
            {
                Console.WriteLine("What is your guess? ");
                int numberGuess = int.Parse(Console.ReadLine());
                numberOfGuesses++;

                // If number is guessed print you guessed it and end while loop
                if (magicNumber == numberGuess)
                {
                    Console.WriteLine("You guessed it! ");
                    guessedCorrectly = true;
                }

                else if (magicNumber > numberGuess)
                {
                    Console.WriteLine("The number is higher. ");
                }

                else
                {
                    Console.WriteLine("The number is lower. ");
                }
            }

            Console.WriteLine($"Total number of guesses: {numberOfGuesses}");

            Console.WriteLine("Do you want to play again? (yes/no)");
            string playAgainQuestion = Console.ReadLine().ToLower();
            playAgain = (playAgainQuestion == "yes");

        } while (playAgain);
    }
}