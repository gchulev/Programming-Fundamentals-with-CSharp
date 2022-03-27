using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    internal class Program
    {
        static void Main()
        {
            List<City> cities = new List<City>();
            string sailInput = Console.ReadLine();

            while (sailInput != "Sail")
            {
                string cityName = sailInput.Split("||", StringSplitOptions.RemoveEmptyEntries)[0];
                int population = int.Parse(sailInput.Split("||", StringSplitOptions.RemoveEmptyEntries)[1]);
                int gold = int.Parse(sailInput.Split("||", StringSplitOptions.RemoveEmptyEntries)[2]);

                if (cities.Exists(x => x.Name.Equals(cityName)))
                {
                    City currentCity = cities.Find(x => x.Name.Equals(cityName));
                    currentCity.Population += population;
                    currentCity.Gold += gold;
                }
                else
                {
                    cities.Add(new City(cityName, population, gold));
                }

                sailInput = Console.ReadLine();
            }

            string eventCommand = Console.ReadLine();

            while (eventCommand != "End")
            {
                if (eventCommand.Contains("Plunder"))
                {
                    string townName = eventCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                    int people = int.Parse(eventCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2]);
                    int gold = int.Parse(eventCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries)[3]);
                    City currentTown = cities.Find(x => x.Name.Equals(townName));

                    currentTown.Population -= people;
                    currentTown.Gold -= gold;
                    Console.WriteLine($"{currentTown.Name} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (currentTown.Population <= 0 || currentTown.Gold <= 0)
                    {
                        cities.Remove(currentTown);
                        Console.WriteLine($"{currentTown.Name} has been wiped off the map!");
                    }
                }
                else if (eventCommand.Contains("Prosper"))
                {
                    string townName = eventCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries)[1];
                    int gold = int.Parse(eventCommand.Split("=>", StringSplitOptions.RemoveEmptyEntries)[2]);
                    City currentTown = cities.Find(x => x.Name.Equals(townName));

                    if (gold >= 0)
                    {
                        currentTown.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {currentTown.Name} now has {currentTown.Gold} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }
                eventCommand = Console.ReadLine();
            }

            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City town in cities)
                {
                    Console.WriteLine($"{town.Name} -> Population: {town.Population} citizens, Gold: {town.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
        class City
        {
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }

            public City(string name, int population, int gold)
            {
                Name = name;
                Population = population;
                Gold = gold;
            }
        }
    }
}
