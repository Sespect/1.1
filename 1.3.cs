using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<string> words = new List<string>();

        while (true)
        {
            Console.Write("Введите слово (для завершения введите пустую строку): ");
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                break;
            }

            words.Add(word);
        }

        string shortestWord = words[0];
        string longestWord = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }

            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое короткое слово: {shortestWord}");
        Console.WriteLine($"Самое длинное слово: {longestWord}");
    }
}