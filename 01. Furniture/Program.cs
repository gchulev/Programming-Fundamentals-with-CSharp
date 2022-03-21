using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double totalSum = 0;

            string pattern = @"^>{2}(?<item>[A-z]{1,})<{2}(?<price>\d+\.*\d+)!(?<quantity>\d+)";
            Regex regex = new Regex(pattern);
            List<string> items = new List<string>();

            while (command != "Purchase")
            {

                if (regex.IsMatch(command))
                {
                    MatchCollection matchCollection = regex.Matches(command);

                    foreach (Match match in matchCollection)
                    {
                        string name = match.Groups["item"].Value;
                        double prc = double.Parse(match.Groups["price"].Value);
                        int qty = int.Parse(match.Groups["quantity"].Value);

                        items.Add(name);
                        totalSum += prc * qty;
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine(string.Join($"{Environment.NewLine}", items));
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
