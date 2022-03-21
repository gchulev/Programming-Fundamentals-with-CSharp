using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, int> keyMats = new Dictionary<string, int>()
            {
                { "shards", 0 },
                { "motes", 0 },
                { "fragments", 0 }
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();
            bool itemCrafted = false;

            while (!itemCrafted)
            {
                string[] materials = Console.ReadLine().ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int i = 0; i < materials.Length; i += 2)
                {
                    int quantity = int.Parse(materials[i]);
                    string materialName = materials[i + 1];

                    if (keyMats.ContainsKey(materialName))
                    {
                        keyMats[materialName] += quantity;

                        if (keyMats["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMats["shards"] -= 250;
                            itemCrafted = true;
                            break;
                        }
                        else if (keyMats["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMats["motes"] -= 250;
                            itemCrafted = true;
                            break;
                        }
                        else if (keyMats["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMats["fragments"] -= 250;
                            itemCrafted = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(materialName))
                        {
                            junk.Add(materialName, 0);
                        }
                        junk[materialName] += quantity;
                    }
                }
            }

            foreach (var item in keyMats)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
