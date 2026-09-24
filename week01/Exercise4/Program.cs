using System;
using System.Globalization;
using System.Numerics;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        // This is exercise 4. This program will focus on list

        // This program will get the user input numbers and store in a list.
        // Then the program will compute the total of sum, the average and the biggest number

        // Create a list for user input number
        List<int> numbers = new List<int>();

        int userNum = 999999999;

        // This while loop will run until user enter 0
        while (userNum != 0)
        {
            // Get the number from user and store as integer
            Console.Write("Enter the number please: ");
            string userInput = Console.ReadLine();
            userNum = int.Parse(userInput);

            // Add the user input number to a list
            // Check the user enter 0 or not. If user enter 0,remove from the list
            if (userNum != 0)
            {
                numbers.Add(userNum);
            }
        }
        // Create a variable for total sum 
        int totalSum = 0;

        // Create a variable for the largest number in the list
        int largestNum = 0;

        // Stretch challenge 1 
        // Create a variable for the smallest positive number in the list
        int smallestPositiveNum = 999999999;

        // Use for loop to Iterate the numbers list
        foreach (int number in numbers)
        {
            // Get the total sum 
            totalSum += number;

            // Get the largest number in the list using if statement 
            if (number > largestNum)
            {
                largestNum = number;
            }

            // Get the smallest number in the list using if statement
            if ((number < smallestPositiveNum) && (number > 0 ))
            {
                smallestPositiveNum = number;
            }

        }
        // Get the average amount of the number in the list
        int average = totalSum / numbers.Count;

        Console.WriteLine("");  // Make the line clear and look good
        Console.WriteLine($"The total sum is {totalSum}");
        Console.WriteLine($"The average amount is {average}");
        Console.WriteLine($"The largest number is {largestNum}");
        Console.WriteLine($"The smallest number is {smallestPositiveNum}");

        Console.WriteLine("");  // Make the line clear and look good

        // Stretch challenge 2
        // Sort the list from smallest number to biggest number 
        numbers.Sort();

        // Display the sorted list 
        Console.WriteLine("This is the sorted list starting from smallest to biggest.");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}