using System;

class Program
{
    static void Main(string[] args)
    {
        // activity 1 ask the user first name and last name. Then display is in one line

        // ask your first and last name stored them in a variable
        Console.Write("Please enter your first name : ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name : ");
        string lastName = Console.ReadLine();

        // display all of the user input as output in one line

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}