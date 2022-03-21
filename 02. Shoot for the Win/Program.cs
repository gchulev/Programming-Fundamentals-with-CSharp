using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static void Main()
        {
            int[] targetSequence = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            int targetShotCntr = 0;

            while (command != "End")
            {
                int indexToShootAt = int.Parse(command);

                if (indexToShootAt >= 0 && indexToShootAt < targetSequence.Length && targetSequence[indexToShootAt] != -1)
                {
                    targetShotCntr++;

                    int targetValue = targetSequence[indexToShootAt];
                    targetSequence[indexToShootAt] = -1;

                    for (int i = 0; i < targetSequence.Length; i++)
                    {
                        if (i != indexToShootAt && targetSequence[i] != -1)
                        {
                            if (targetSequence[i] <= targetValue)
                            {
                                targetSequence[i] += targetValue;
                            }
                            else
                            {
                                targetSequence[i] -= targetValue;
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {targetShotCntr} -> {string.Join(' ', targetSequence)}");
        }
    }
}
