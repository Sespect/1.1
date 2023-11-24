using System;
using System.Collections.Generic;
class Program
{
  static int[] GenerateRandomList(int start, int end, int count)
    {
        Random r = new Random();
        List<int> randomNumbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            randomNumbers.Add(r.Next(start, end + 1));
        }
        return randomNumbers.ToArray();
    }
    static void Main()
    {
        int[] randomNumbers = GenerateRandomList(1, 100, 10);
        foreach (int num in randomNumbers)
        {
            Console.Write(num + " ");
        }
    }
}