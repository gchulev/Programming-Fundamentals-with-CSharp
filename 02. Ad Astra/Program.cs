using System;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"(#|\|)(?<product>[a-zA-z\s]+)\1(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]|[1-9][0-9]|[1-9][0-9][0-9]|[1-9][0-9][0-9][0-9]|10000)\1";
            MatchCollection matches = Regex.Matches(input, pattern);
            int totalCalories = 0;

            foreach (Match product in matches)
            {
                int calories = int.Parse(product.Groups["calories"].Value);
                string productName = product.Groups["product"].Value;
                string date = product.Groups["date"].Value;

                totalCalories += calories;
            }
            int daysToLast = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {daysToLast} days!");

            if (matches.Count > 0)
            {
                foreach (Match product in matches)
                {
                    Console.WriteLine($@"Item: {product.Groups["product"].Value}, Best before: {product.Groups["date"].Value}, Nutrition: {int.Parse(product.Groups["calories"].Value)}");
                }
            }
        }
    }
}
