using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            string pattern = @"\%(?<customer>[A-Z]{1}[a-z]+)\%[^%&|.]*?\<(?<product>\w+)\>[^%&|.]*?\|(?<count>\d+)\|[^%&|.]*?(?<price>\d+(\.\d+)?)\$";
            decimal totalIncome = 0m;

            while (command != "end of shift")
            {
                Match match = Regex.Match(command, pattern);

                if (match.Success)
                {
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int productCount = int.Parse(match.Groups["count"].Value);
                    decimal price = decimal.Parse(match.Groups["price"].Value);
                    decimal currentTotal = price * productCount;

                    totalIncome += currentTotal;
                    Console.WriteLine($"{customer}: {product} - {currentTotal:f2}");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
