using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of numbers
        List<int> numbers = new List<int>();

        // Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        // Compute the sum, average, max, min of the numbers in the list.
        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;
        int count = 0;

        while (true)
        {
            Console.WriteLine("Enter a number (0 to quit)");
            int number = int.Parse(Console.ReadLine());

            if (number == 0) break;

            numbers.Add(number);
            sum += number;
            count++;

            if (number > max) max = number;
            if (number < min) min = number;
        }

        double average = (double)sum / count;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Min: {min}");

        // Sort the list of numbers and print it out
        numbers.Sort();
        Console.WriteLine("Sorted numbers:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}