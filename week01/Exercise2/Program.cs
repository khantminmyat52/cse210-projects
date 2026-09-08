using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter the the test score: ");
        String scorePoint = Console.ReadLine();

        int scorePointNumber = int.Parse(scorePoint);

        string letter = "";

        if (scorePointNumber >= 90)
        {
            letter = "A";
        }
        else if (scorePointNumber >= 80)
        {
            letter = "B";
        }
        else if (scorePointNumber >= 70)
        {
            letter = "C";
        }
        else if (scorePointNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";
        int lastDigit = scorePointNumber % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if ((lastDigit > 3) && (lastDigit < 7))
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if ((letter == "A") && (sign == "+"))
        {
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }
        


        Console.Write($"Your grade is {letter}{sign}. ");
        if (scorePointNumber >= 70)
        {
            Console.WriteLine("You passed the test, Congratulation!");
        }
        else if (scorePointNumber <= 69)
        {
            Console.WriteLine("Sorry, you did not pass the test. Do not give up until you pass!");
        }
    }

}