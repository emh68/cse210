using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for list of numbers and initialize list
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();

        // Continue to ask user for number until they enter 0
        while (true)

        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            
            // Add number to list if it is not 0
            if (number == 0)
                break;

            numbers.Add(number);
        }
        // Calculate the sum of numbers
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        
        // Calculate the average of the numbers
        double average = numbers.Average();
        Console.WriteLine(($"The average is: {average}"));
        
        // Calculate the largest number
        int max = numbers.Max();
        Console.WriteLine(($"The largest number is: {max}"));
    }
}