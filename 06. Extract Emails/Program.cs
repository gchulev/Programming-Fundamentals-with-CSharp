using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s)([A-Za-z]+\.?-?_?\w+)@{1}(\w+-?\w+\.\w+\.?\w+)";
            MatchCollection matches = Regex.Matches(input, pattern);
            Console.WriteLine(string.Join($"{ Environment.NewLine}", matches));
        }
    }
}
