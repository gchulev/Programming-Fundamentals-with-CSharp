using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shopping_List
{
    internal class Program
    {
        static void Main()
        {
            List<string> shoppingList = Console.ReadLine().Split('!', StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                if (command.Contains("Urgent"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string item = cmd[1];

                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command.Contains("Unnecessary"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string item = cmd[1];

                    shoppingList.Remove(item);
                }
                else if (command.Contains("Correct"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string oldItem = cmd[1];
                    string newItem = cmd[2];

                    if (shoppingList.Contains(oldItem))
                    {
                        shoppingList[shoppingList.IndexOf(oldItem)] = newItem;
                    }
                }
                else if (command.Contains("Rearrange"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string item = cmd[1];

                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
