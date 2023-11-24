using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int[] array = new int[10];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = rand.Next(1, 100);
    }

    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[minIndex])
        {
            minIndex = (i);
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine(array[i]);
    }
    Console.WriteLine("number of minimal:  "  +  (minIndex + 1));
  }
}