using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        int num;
        while ((num = Convert.ToInt32(Console.ReadLine())) != 0)
        {
            Console.Write("Enter a number (enter 0 to finish): ");
            numbers.Add(num);
        }
        int totalSum = 0;
        int product = 1;

        for (int i = 0; i < numbers.Count; i++)
        {
            totalSum += numbers[i];
            product *= numbers[i];
        }

        double average = (double)totalSum / numbers.Count;

        Console.WriteLine($"Total sum of all numbers: {totalSum}");
        Console.WriteLine($"Product of all numbers: {product}");
        Console.WriteLine($"Average value: {average}");
    }
}