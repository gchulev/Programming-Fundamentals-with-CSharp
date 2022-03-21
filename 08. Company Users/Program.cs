using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    internal class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            var companies = new Dictionary<string, List<string>>();

            while (command != "End")
            {
                string company = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[0];
                string employeeId = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries)[1];

                if (!companies.ContainsKey(company))
                {
                    companies.Add(company, new List<string> { employeeId });
                }
                else
                {
                    if (!companies.Any(x => x.Key == company && x.Value.Contains(employeeId)))
                    {
                        companies[company].Add(employeeId);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var company in companies)
            {
                Console.WriteLine($"{company.Key}");

                foreach (var item in company.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
