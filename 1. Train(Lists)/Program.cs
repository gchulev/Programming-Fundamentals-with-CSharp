using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train_Lists_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command.Split()[0] == "Add")
                {
                    int addPassengers = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
                    wagons.Add(addPassengers);
                }
                else
                {
                    int passengers = int.Parse(command);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
    }
}
