using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random rand = new Random();

        // Generate an array of 100 elements with random numbers between 20 and 40 (inclusive)
        int[] numbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(20, 41); // Generates a number between 20 and 40 inclusive
        }

        Console.WriteLine("Generated Numbers:");

        Console.WriteLine(string.Join(",", numbers.ToList()));
       

        // Calculate the occurrences of each unique number
        var occurrences = numbers.GroupBy(n => n)
                                  .ToDictionary(g => g.Key, g => g.Count());

        // Output the results
        Console.WriteLine("Number Occurrences:");
        foreach (var item in occurrences)
        {
            Console.WriteLine($"Number {item.Key} appears {item.Value} times.");
        }
    }
}
