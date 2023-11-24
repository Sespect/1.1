using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');
        int wordCount = words.Length;
        Console.WriteLine("Number of words: " + wordCount);
        string newString = "Start " + input + " End";
        Console.WriteLine(newString);
    }
}