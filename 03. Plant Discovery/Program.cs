using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = input[0];
                int rarity = int.Parse(input[1]);

                if (plants.Exists(x => x.PlantName.Equals(plantName)))
                {
                    var currentPlant = plants.Find(x => x.PlantName.Equals(plantName));
                    currentPlant.Rarity = rarity;
                }
                else
                {
                    plants.Add(new Plant(plantName, rarity));
                }
            }

            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] cmd = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (command.Contains("Rate"))
                {
                    string plantName = cmd[0].Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];
                    double rating = double.Parse(cmd[1]);

                    if (plants.Exists(x => x.PlantName.Equals(plantName)))
                    {
                        Plant currentPlant = plants.Find(x => x.PlantName.Equals(plantName));
                        currentPlant.Rating.Add(rating);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }

                }
                else if (command.Contains("Update"))
                {
                    string plantName = cmd[0].Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];
                    int rarity = int.Parse(cmd[1]);

                    if (plants.Exists(x => x.PlantName.Equals(plantName)))
                    {
                        Plant currentPlant = plants.Find(x => x.PlantName.Equals(plantName));
                        currentPlant.Rarity = rarity;
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (command.Contains("Reset"))
                {
                    string plantName = cmd[0].Split(": ", StringSplitOptions.RemoveEmptyEntries)[1];

                    if (plants.Exists(x => x.PlantName.Equals(plantName)))
                    {
                        Plant currentPlant = plants.Find(x => x.PlantName.Equals(plantName));
                        currentPlant.Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (Plant plant in plants)
            {
                double average = 0;

                if (plant.Rating.Count > 0)
                {
                    average = plant.Rating.Average();
                }
                else
                {
                    average = 0;
                }

                Console.WriteLine($"- {plant.PlantName}; Rarity: {plant.Rarity}; Rating: {average:f2}");
            }
        }
    }
    class Plant
    {
        public string PlantName { get; set; }
        public int Rarity { get; set; }
        public List<double> Rating { get; set; } = new List<double>();
        public Plant(string plantName, int rarity)
        {
            PlantName = plantName;
            Rarity = rarity;
        }
    }
}
