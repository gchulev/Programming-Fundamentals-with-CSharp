using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            List<string> destinations = new List<string>();
            Regex rgx = new Regex(@"(=|\/)(?<location>[A-Z][A-Za-z]{2,})\1");
            MatchCollection matches = rgx.Matches(input);
            int travelPoints = 0;

            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    string location = match.Groups["location"].Value;
                    destinations.Add(location);
                    travelPoints += location.Length;
                }
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
