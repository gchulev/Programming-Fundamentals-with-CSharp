using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(@|#)(?<firstword>[A-Za-z]{3,})(\1)(\1)(?<secondword>[A-Za-z]{3,})(\1)?";
            MatchCollection matches = Regex.Matches(input, pattern);

            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                List<string> mirrorWords = new List<string>();

                foreach (Match match in matches)
                {
                    string firstWord = match.Groups["firstword"].Value;
                    string secondWord = match.Groups["secondword"].Value;
                    string reversedSecondWord = string.Join("", secondWord.Reverse());

                    if (firstWord == reversedSecondWord)
                    {
                        mirrorWords.Add($"{firstWord} <=> {secondWord}");
                    }
                }
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }
    }
}
