using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Space_Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> route = Console.ReadLine().Split("||", StringSplitOptions.RemoveEmptyEntries).ToList();
            int fuel = int.Parse(Console.ReadLine());
            int ammo = int.Parse(Console.ReadLine());

            for (int i = 0; i < route.Count; i++)
            {
                string[] cmd = route[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = cmd[0];

                if (command == "Travel")
                {
                    int distanceToTravel = int.Parse(cmd[1]);

                    if (fuel >= distanceToTravel && fuel > 0)
                    {
                        fuel -= distanceToTravel;
                        Console.WriteLine($"The spaceship travelled {distanceToTravel} light-years.");
                    }
                    else
                    {
                        Console.WriteLine("Mission failed.");
                        return;
                    }
                }
                else if (command == "Enemy")
                {
                    int armour = int.Parse(cmd[1]);

                    if (ammo >= armour)
                    {
                        ammo -= armour;
                        Console.WriteLine($"An enemy with {armour} armour is defeated.");
                    }
                    else
                    {
                        int fuelNeeded = armour * 2;

                        if (fuel >= fuelNeeded)
                        {
                            fuel -= fuelNeeded;
                            Console.WriteLine($"An enemy with {armour} armour is outmaneuvered.");
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                    }
                }
                else if (command == "Repair")
                {
                    int repairPoints = int.Parse(cmd[1]);
                    fuel += repairPoints;
                    ammo -= repairPoints * 2;

                    Console.WriteLine($"Ammunitions added: {repairPoints * 2}.");
                    Console.WriteLine($"Fuel added: {repairPoints}.");
                }
                else if (command == "Titan")
                {
                    Console.WriteLine("You have reached Titan, all passengers are safe.");
                    return;
                }
            }
        }
    }
}