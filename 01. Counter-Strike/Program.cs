using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main()
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int battlesWon = 0;

            while (command != "End of battle")
            {
                int currentDistance = int.Parse(command);

                if (energy >= currentDistance)
                {
                    battlesWon++;
                    energy -= currentDistance;

                    if (battlesWon % 3 == 0 && battlesWon >= 3)
                    {
                        energy += battlesWon;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWon} won battles and {energy} energy");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {battlesWon}. Energy left: {energy}");
            }
        }
    }
}
