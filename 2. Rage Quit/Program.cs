using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;

namespace _2._Rage_Quit
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(?<string>[^\n0-9]+)(?<digit>\d+)";
            int uniqueSymbolsCount = 0;
            MatchCollection matches = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                string stringToRepeat = match.Groups["string"].Value.ToUpper();
                int timesToReapeat = int.Parse(match.Groups["digit"].Value);
                sb.Append(string.Join(string.Empty, Enumerable.Repeat(stringToRepeat, timesToReapeat)));
            }
            uniqueSymbolsCount = sb.ToString().ToLower().Where(x => !char.IsDigit(x)).Distinct().Count();
            Console.WriteLine($"Unique symbols used: {uniqueSymbolsCount}");
            Console.WriteLine(sb);
        }
    }
}
