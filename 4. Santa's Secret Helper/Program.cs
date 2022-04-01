using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main()
        {
            int decriptionKey = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            List<string> children = new List<string>();
            string pattern = @"(?<=@)(?<name>[A-Za-z]+)[^@\-!:>]+!(?<behaviour>N|G)!";

            while (inputString != "end")
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < inputString.Length; i++)
                {
                    char currentChar = (char)(inputString[i] - decriptionKey);
                    sb.Append(currentChar);
                }

                Match match = Regex.Match(sb.ToString(), pattern);
                if (match.Success)
                {
                    string childName = match.Groups["name"].Value;
                    string behaviour = match.Groups["behaviour"].Value;
                    if (behaviour == "G")
                    {
                        children.Add(childName);
                    }
                }
                inputString = Console.ReadLine();
            }
            Console.WriteLine(string.Join($"{Environment.NewLine}", children));
        }
    }
}
