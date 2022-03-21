using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main()
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> originalSet = drumSet.ToList();
            string command = Console.ReadLine();

            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;
                }
                for (int j = 0; j < drumSet.Count; j++)
                {
                    if (drumSet[j] <= 0)
                    {
                        decimal setPrice = originalSet[j] * 3;

                        if (savings >= setPrice)
                        {
                            savings -= setPrice;
                            drumSet[j] = originalSet[j];
                        }
                        else
                        {
                            drumSet.RemoveAt(j);
                            originalSet.RemoveAt(j);
                            j--;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ', drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}
