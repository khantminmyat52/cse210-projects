using System;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // This is activity 2 which is for if statement

        // First ask the user exam point and store as a int
        Console.Write("Please enter your grade percentage : ");
        string userGradeStr = Console.ReadLine();
        int userGrade = int.Parse(userGradeStr);

        // Create the new string variable to store a grade letter
        string letter = "";

        // Stretch Challenge number 1
        // Create a new string variable to store the + or - sign

        string sign = "";

        // Use if statement to check the user grade and return the grade which they got
        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";

        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else if (userGrade < 60)
        {
            letter = "F";
        }

        // Check the user got + sign or - sign
        if (userGrade % 10 >= 7)
        {
            sign = "+";
        }
        else if (userGrade % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // Stretch challenge 2
        // check the user got A or not then if define the sign

        if (letter == "A" && userGrade % 10 < 3)
        {
            sign = "-";
        }
        else if (letter == "F")
        {
            sign = "";
        }
        else if (letter == "A")
        {
            sign = "";
        }

        // Check the user got at least 70 percentage, if user get 70 or over 70 
        // display the congratulate message and if not display encourage message
        if (userGrade >= 70)
        {
            Console.WriteLine($"Your grade is {sign}{letter}.");
            Console.WriteLine("WOW! You made it! Congratulation!");
        }
        else
        {
            Console.WriteLine($"Your grade is {sign}{letter}.");
            Console.WriteLine("Sorry you did not make it. But DO NOT give up!");
        }
    }

}