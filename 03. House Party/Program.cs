using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string name = command.Split(' ', StringSplitOptions.RemoveEmptyEntries)[0];

                if (command.Contains("is going!"))
                {
                    if (!guestList.Contains(name))
                    {
                        guestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else
                {
                    if (guestList.Contains(name))
                    {
                        guestList.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
