using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
    
{
    internal class Program
    {
        static void Main()
        {
            List<int> neighboorhood = Console.ReadLine().Split('@', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            int lastIndex = 0;

            while (command != "Love!")
            {
                string[] cmd = command.Split(' ').ToArray();
                int jumpIndex = int.Parse(cmd[1]);
                lastIndex += jumpIndex;

                if (lastIndex > neighboorhood.Count - 1)
                {
                    lastIndex = 0;
                }
                if (neighboorhood[lastIndex] == 0)
                {
                    Console.WriteLine($"Place {lastIndex} already had Valentine's day.");
                }
                else
                {
                    neighboorhood[lastIndex] -= 2;

                    if (neighboorhood[lastIndex] == 0)
                    {
                        Console.WriteLine($"Place {lastIndex} has Valentine's day.");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {lastIndex}.");

            if (neighboorhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {neighboorhood.Count(x => x > 0)} places.");
            }
        }
    }
}
