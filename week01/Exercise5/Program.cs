using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Hello,Welcome to my program!");
        }
        static string PromptUserName()
        {
            Console.Write("Enter your name please! - ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number : ");
            string userNumber = Console.ReadLine();
            int userNumberInt = int.Parse(userNumber);
            return userNumberInt;
        }
        static int SquareNumber(int squareNum)
        {
            int finalNum = squareNum * squareNum;
            return finalNum;
        }
        static void DisplayResult(string para1, int para2)
        {
            Console.WriteLine($"{para1}, the square of your number is {para2}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int userFavNum = PromptUserNumber();
        int number = SquareNumber(userFavNum);
        DisplayResult(name, number);

        
    }
}