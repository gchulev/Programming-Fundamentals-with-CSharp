using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main()
        {
            List<string> treasureChest = Console.ReadLine().Split('|').ToList();
            string command = Console.ReadLine();

            while (command != "Yohoho!")
            {
                if (command.Contains("Loot"))
                {
                    List<string> items = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    items.RemoveAt(0);

                    for (int i = 0; i < items.Count; i++)
                    {
                        if (!treasureChest.Contains(items[i]))
                        {
                            treasureChest.Insert(0, items[i]);
                        }
                    }
                }
                else if (command.Contains("Drop"))
                {
                    List<string> items = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    int index = int.Parse(items[1]);

                    if (index >= 0 && index < treasureChest.Count)
                    {
                        string removedItem = treasureChest[index];
                        treasureChest.RemoveAt(index);
                        treasureChest.Add(removedItem);
                    }
                }
                else if (command.Contains("Steal"))
                {
                    List<string> items = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
                    int stolenItemsCount = int.Parse(items[1]);
                    var stolenItems = treasureChest.TakeLast(stolenItemsCount).ToList();

                    if (stolenItemsCount > treasureChest.Count)
                    {
                        treasureChest.Clear();
                    }
                    else
                    {
                        treasureChest = treasureChest.Except(stolenItems).ToList();
                    }
                    Console.WriteLine(string.Join(", ", stolenItems));
                }

                command = Console.ReadLine();
            }

            if (treasureChest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double avgTreasureGain = treasureChest.Sum(x => x.Length) / (double)treasureChest.Count;
                Console.WriteLine($"Average treasure gain: {avgTreasureGain:f2} pirate credits.");
            }
        }
    }
}
