using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main()
        {
            string[] racersList = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> raceRoster = new Dictionary<string, int>();
            string command = Console.ReadLine();

            Regex regexNames = new Regex(@"(?<letters>[A-Za-z])");
            Regex regexDistance = new Regex(@"(?<distance>[0-9])");

            while (command != "end of race")
            {
                var nameMatches = regexNames.Matches(command);
                var distanceMatches = regexDistance.Matches(command);

                StringBuilder currentRacerName = new StringBuilder();
                int racerDistance = 0;

                foreach (Match name in nameMatches)
                {
                    currentRacerName.Append(name.Value);
                }
                foreach (Match number in distanceMatches)
                {
                    racerDistance += int.Parse(number.Value);
                }
                string racerName = currentRacerName.ToString();

                if (racersList.Contains(racerName.ToString()))
                {
                    if (!raceRoster.ContainsKey(racerName))
                    {
                        raceRoster.Add(racerName.ToString(), 0);
                    }
                    raceRoster[racerName] += racerDistance;
                }

                command = Console.ReadLine();
            }

            Dictionary<string, int> result = raceRoster.OrderByDescending(x => x.Value).Take(3).ToDictionary(x => x.Key, x => x.Value);

            if (result.Count > 0)
            {
                Console.WriteLine($"1st place: {result.ElementAt(0).Key}");
                Console.WriteLine($"2nd place: {result.ElementAt(1).Key}");
                Console.WriteLine($"3rd place: {result.ElementAt(2).Key}");
            }

        }
    }
}
