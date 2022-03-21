using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Moving_Target
{
    internal class Program
    {
        static void Main()
        {
            List<int> targets = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("Shoot"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);
                    int power = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command.Contains("Add"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);
                    int value = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command.Contains("Strike"))
                {
                    int index = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[1]);
                    int radius = int.Parse(command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray()[2]);

                    if (index - radius >= 0 && index + radius < targets.Count && index >= 0 && index < targets.Count)
                    {
                        int elementsToRemove = 2 * radius + 1;
                        targets.RemoveRange(index - radius, elementsToRemove);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join('|', targets));
        }
    }
}
