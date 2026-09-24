using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        // This is exercise 5
        // In this program, the main focus is about function

        // Create DisplayWelcome function
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        // Create PromptUserName function
        static string PromptUserName()
        {
            // Get the user name 
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();
            return userName;
        }

        // Create PromptUserNumber function
        static int PromptUserNumber()
        {
            // Get the user number and return
            Console.Write("Enter your favorite number : ");
            string favoriteLetter = Console.ReadLine();
            int favoriteNum = int.Parse(favoriteLetter);
            return favoriteNum;
        }

        // Create SquareNumber function
        static int SquareNumber(int number)
        {
            // Get the user favorite number and square it. Then return it
            int squareNum = number * number;
            return squareNum;
        }

        // Create DisplayResult function
        static void DisplayResult(string userName , int squareNumber)
        {
            // Display the square number and your name 
            Console.WriteLine($"{userName}, the square of your favorite number is {squareNumber}");
        }

        // Call of the function
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}