using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main()
        {
            List<string> items = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Craft!")
            {
                string[] cmd = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Collect"))
                {
                    string item = cmd[1];

                    if (!items.Contains(item))
                    {
                        items.Add(item);
                    }
                }
                else if (command.Contains("Drop"))
                {
                    string item = cmd[1];

                    items.Remove(item);
                }
                else if (command.Contains("Combine"))
                {
                    string[] oldNewItemsList = cmd[1].Split(':', StringSplitOptions.RemoveEmptyEntries);
                    string oldItem = oldNewItemsList[0];
                    string newItem = oldNewItemsList[1];

                    if (items.Contains(oldItem))
                    {
                        int oldItemIndex = items.IndexOf(oldItem) + 1;
                        items.Insert(oldItemIndex, newItem);
                    }
                }
                else if (command.Contains("Renew"))
                {
                    string item = cmd[1];

                    if (items.Contains(item))
                    {
                        items.Remove(item);
                        items.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", items));
        }
    }
}
