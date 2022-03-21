using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Coffee_Lover
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = Console.ReadLine().Split(' ').ToList();
            int cmdCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < cmdCount; i++)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();

                if (command.Contains("Include"))
                {
                    string coffee = command[1];
                    coffeeList.Add(coffee);
                }
                else if (command.Contains("Remove"))
                {
                    string subCommand = command[1];
                    int numToRemove = int.Parse(command[2]);

                    if (subCommand == "first")
                    {
                        if (numToRemove <= coffeeList.Count)
                        {
                            coffeeList.RemoveRange(0, numToRemove);
                        }
                    }
                    else if (subCommand == "last")
                    {
                        if (numToRemove <= coffeeList.Count)
                        {
                            coffeeList.RemoveRange(coffeeList.Count - numToRemove, numToRemove);
                        }
                    }
                }
                else if (command.Contains("Prefer"))
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);

                    if (indexOne >= 0 && indexOne < coffeeList.Count && indexTwo >= 0 && indexTwo < coffeeList.Count)
                    {
                        string firstItem = coffeeList[indexOne];
                        string secondItem = coffeeList[indexTwo];

                        coffeeList.RemoveAt(indexOne);
                        coffeeList.Insert(indexOne, secondItem);
                        coffeeList.RemoveAt(indexTwo);
                        coffeeList.Insert(indexTwo, firstItem);
                    }
                }
                else if (command.Contains("Reverse"))
                {
                    coffeeList.Reverse();
                }
            }

            Console.WriteLine($"Coffees: {Environment.NewLine}{string.Join(' ', coffeeList)}");
        }
    }
}
