using System;
using System.Globalization;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int userNumber = 99999999;
        while (userNumber != 0)
        {
            Console.Write("Enter the number(type 0 to quit) : ");
            string numberLetter = Console.ReadLine();
            userNumber = int.Parse(numberLetter);



            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int totalSum = 0;
        int largestNumber = 0;
        int smallestPositiveNum = 9999999;
            foreach (int number in numbers)
            {
                totalSum += number;
            if (number > largestNumber)
            {
                largestNumber = number;
            }
            else if ((number < smallestPositiveNum) && (number > 0))
            {
                smallestPositiveNum = number;
            } 
                
            }
        Console.WriteLine($"The sum is : {totalSum}");
        Console.WriteLine($"The average is : {((float)totalSum) / numbers.Count}");
        Console.WriteLine($"The largest number is  : {largestNumber}");
        Console.WriteLine($"The smallest number is : {smallestPositiveNum}");

        Console.WriteLine("Numbers in sorted is : ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}