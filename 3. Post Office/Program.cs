using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            string firstPart = input[0];
            string secondPart = input[1];
            string thirdPart = input[2];

            string firstPattern = @"([#%*&$])(?<capitalletters>[A-Z]+)\1";
            List<string> validWords = new List<string>();
            string capitalLetters = Regex.Match(firstPart, firstPattern).Groups["capitalletters"].Value;

            foreach (char letter in capitalLetters)
            {
                int charASCIIcode = (int)letter;
                string secondPattern = $@"{charASCIIcode}:(?<length>[0-1][0-9]|[2][0])";
                int length = int.Parse(Regex.Match(secondPart, secondPattern).Groups["length"].Value);

                string thirdPattern = $@"(?<=\s|^){letter}[^\s|]{{{length}}}(?=\s|$)";
                string validWord = Regex.Match(thirdPart, thirdPattern).Value;
               
                validWords.Add(validWord);
            }

            Console.WriteLine(string.Join($"{Environment.NewLine}", validWords));
        }
    }
}
