using System;
using System.Text.RegularExpressions;

namespace _02._Encrypting_Password
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(.+)>(?<numbers>[\d]{3})\|(?<lowercase>[a-z]{3})\|(?<uppercase>[A-Z]{3})\|(?<symbols>[^<>]{3})<\1$";

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (Regex.IsMatch(input, pattern))
                {
                    string numbersGrp = Regex.Match(input, pattern).Groups["numbers"].Value;
                    string lowercaseGrp = Regex.Match(input, pattern).Groups["lowercase"].Value;
                    string uppercaseGrp = Regex.Match(input, pattern).Groups["uppercase"].Value;
                    string symbolcaseGrp = Regex.Match(input, pattern).Groups["symbols"].Value;
                    string encryptedPass = $"{numbersGrp}{lowercaseGrp}{uppercaseGrp}{symbolcaseGrp}";

                    Console.WriteLine($"Password: {encryptedPass}");
                }
                else
                {
                    Console.WriteLine($"Try another password!");
                }
            }
        }
    }
}
