using System;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        
        while (userNumber != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            string input = Console.ReadLine();
            userNumber = int.Parse(input); 
           
           if (userNumber != 0)
           {
                numbers.Add(userNumber);
           } 
        }
        // Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum} ");
        // Compute average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average} ");
        // Compute the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    
    }
}