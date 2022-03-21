using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string decriptionKeyPtrn = @"[star]";
            string decriptedMsgPattern = @"\@(?<planet>[A-z]+)[^@!:>-]*?:(?<population>\d+)[^@!:>-]*?!(?<attack>A|D)![^@!:>-]*?(->){1}(?<soldierCount>\d+)";
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                MatchCollection matches = Regex.Matches(message, decriptionKeyPtrn, RegexOptions.IgnoreCase);
                int count = matches.Count;

                string decriptedMessage = string.Empty;

                for (int j = 0; j < message.Length; j++)
                {
                    decriptedMessage += (char)(message[j] - count);
                }

                Match match = Regex.Match(decriptedMessage, decriptedMsgPattern);

                if (match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    string action = match.Groups["attack"].Value;
                    int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                    switch (action)
                    {
                        case "A":
                            attackedPlanets.Add(planet);
                            break;
                        case "D":
                            destroyedPlanets.Add(planet);
                            break;
                        default:
                            break;
                    }
                }
            }

            List<string> attackedPlanetsOrdered = attackedPlanets.OrderBy(x =>x).ToList();
            List<string> destroyedPlanetsOrdered = destroyedPlanets.OrderBy(x =>x).ToList();
            

            Console.WriteLine($"Attacked planets: {attackedPlanetsOrdered.Count}");
            if (attackedPlanetsOrdered.Count > 0)
            {
                Console.WriteLine($"-> {string.Join($"{Environment.NewLine}-> ", attackedPlanetsOrdered)}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanetsOrdered.Count}");
            if (destroyedPlanetsOrdered.Count > 0)
            {
                Console.WriteLine($"-> {string.Join($"{Environment.NewLine}-> ", destroyedPlanetsOrdered)}");
            }
        }
    }
}
