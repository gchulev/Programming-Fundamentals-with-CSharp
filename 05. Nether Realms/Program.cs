using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries).Select(x => x.Replace(" ", "")).ToArray();
            SortedDictionary<string, Dictionary<int, double>> deamons = new SortedDictionary<string, Dictionary<int, double>>();

            string healthPattern = @"[^0-9+\-*/.]";
            string baseDamagePatternDigits = @"(-?\d*)(\d+(\.\d+)?)";
            string baseDamagePatternSpecialSimbols = @"[*/]";

            foreach (string daemon in input)
            {
                MatchCollection lettersCollection = Regex.Matches(daemon, healthPattern);
                MatchCollection damageCollection = Regex.Matches(daemon, baseDamagePatternDigits);
                MatchCollection divideOrMultyplyCollection = Regex.Matches(daemon, baseDamagePatternSpecialSimbols);

                int health = 0;

                foreach (string item in lettersCollection.Select(x => x.Value))
                {
                    char tempChar = char.Parse(item);
                    health += tempChar;
                }

                int powerOf2Count = divideOrMultyplyCollection.Count(x => x.Value == "*") - divideOrMultyplyCollection.Count(x => x.Value == @"/");
                double sumOfDmgNumbers = damageCollection.Sum(x => double.Parse(x.Value));
                double damage = sumOfDmgNumbers * Math.Pow(2, powerOf2Count);

                if (!deamons.ContainsKey(daemon))
                {
                    deamons.Add(daemon, new Dictionary<int, double>() { { health, damage } });
                }
            }

            foreach (var daemon in deamons)
            {
                Dictionary<int, double> daemonStats = daemon.Value;
                Console.Write(daemon.Key);
                foreach (var stat in daemonStats)
                {
                    Console.WriteLine($" - {stat.Key} health, {stat.Value:f2} damage");
                }
            }
        }
    }
}
