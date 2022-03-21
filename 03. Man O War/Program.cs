using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Man_O_War
{
    internal class Program
    {
        static void Main()
        {
            List<int> pirateShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split('>').Select(int.Parse).ToList();
            int sectionMaxHealth = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "Retire")
            {
                if (command.Contains("Fire"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int index = int.Parse(cmd[1]);
                    int damage = int.Parse(cmd[2]);

                    if (index >= 0 && index < warShip.Count)
                    {
                        warShip[index] -= damage;

                        if (warShip[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                    }
                }
                else if (command.Contains("Defend"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int damage = int.Parse(cmd[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                else if (command.Contains("Repair"))
                {
                    string[] cmd = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int index = int.Parse(cmd[1]);
                    int health = int.Parse(cmd[2]);

                    if (index >= 0 && index < pirateShip.Count)
                    {
                        if (pirateShip[index] + health > sectionMaxHealth)
                        {
                            pirateShip[index] = sectionMaxHealth;
                        }
                        else
                        {
                            pirateShip[index] += health;
                        }
                    }
                }
                else if (command.Contains("Status"))
                {
                    double needsRepair = sectionMaxHealth * 0.2;

                    Console.WriteLine($"{pirateShip.Count(x => x < needsRepair)} sections need repair.");
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");

        }
    }
}
