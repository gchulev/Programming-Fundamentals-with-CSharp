using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main()
        {
            int health = 100;
            int bitcoins = 0;

            List<string> rooms = Console.ReadLine().Split('|').ToList();

            for (int i = 0; i < rooms.Count; i++)
            {
                string[] room = rooms[i].Split(' ');
                string command = room[0];
                int number = int.Parse(room[1]);

                if (room.Contains("potion"))
                {
                    int ammountHealed;

                    if (health + number > 100)
                    {
                        ammountHealed = 100 - health;
                        health = 100;
                    }
                    else
                    {
                        ammountHealed = number;
                        health += number;
                    }

                    Console.WriteLine($"You healed for {ammountHealed} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (room.Contains("chest"))
                {
                    bitcoins += number;
                    Console.WriteLine($"You found {number} bitcoins.");
                }
                else
                {
                    health -= number;

                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                }

            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: { health}");
        }
    }
}
