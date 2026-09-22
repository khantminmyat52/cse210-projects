using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        // This program is activity 3 which we will use while loop

        // Stretch Challenge 

        // 1. Create a new variable to track how many guess user take
        int guessCount = 0;

        // stretch Challenge 2
        // Create another loop until user do not want to play
        string playAgain = "yes";

        // This while loop will loop until user enter no 
        while (playAgain == "yes")
        {
             // Get the magic number as a random number
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 100);

            // Create a new variable for user guess number and store in it
            int userGuess = -1;
            // Check the user guess number is correct or not 
            // if user guess is wrong this loop will keep looping until user guess it right
            while (magicNum != userGuess)
            {
                // Get the user input guess number and store is as integer to userGuess variable
                Console.Write("Enter the guess number (1 to 100): ");
                string guessLetter = Console.ReadLine();
                userGuess = int.Parse(guessLetter);

                // Plus 1 to guessCount every time user take guess
                guessCount += 1;

                // Start checking the user guess is correct or wrong. Then display a hint
                if (userGuess > magicNum)
                {
                    Console.WriteLine("Lower");
                }
                else if (userGuess < magicNum)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine($"Wow! You guessed it! The magic number is {magicNum}");
                }
            }
            Console.WriteLine($"You took {guessCount} to guess the number correctly.");
            Console.WriteLine();

            // ask the user for playing again or not
            Console.Write("Would you like to play again(yes or no) : ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thank you for your time. Have a good day! ");
    }
}