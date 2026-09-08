using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string replay = "yes";

        while (replay == "yes")
        {
            Random randomGenerator = new Random();
            int numberRandom = randomGenerator.Next(1, 100);
            int guessCount = 0;

            int guessNumber = 0;
            while (numberRandom != guessNumber)
            {
                Console.Write("Enter the guess number : ");
                string userGuess = Console.ReadLine();
                int userGuessNumber = int.Parse(userGuess);
                guessNumber = userGuessNumber;
                guessCount += 1;

                if (guessNumber > numberRandom)
                {
                    Console.WriteLine("Lower!");
                }
                else if (guessNumber < numberRandom)
                {
                    Console.WriteLine("Higher!");
                }
            }
            Console.WriteLine($"You guessed the number! You took {guessCount} guess!");
            Console.Write("Do you want to play again? ");
            replay = Console.ReadLine();
        }
        Console.WriteLine("Thank you for your time! See you soon!");
    }
}