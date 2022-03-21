using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main()
        {
            var firstPlayerSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var secondPlayerSet = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            for (int i = 0; i < firstPlayerSet.Count; i++)
            {
                if (firstPlayerSet.Count != 0 && secondPlayerSet.Count != 0)
                {
                    if (firstPlayerSet[i] > secondPlayerSet[i])
                    {
                        int winningCard = firstPlayerSet[i];
                        int losingCard = secondPlayerSet[i];

                        firstPlayerSet.Add(winningCard);
                        firstPlayerSet.Add(losingCard);

                        firstPlayerSet.Remove(winningCard);
                        secondPlayerSet.Remove(losingCard);
                        i--;
                    }
                    else if (secondPlayerSet[i] > firstPlayerSet[i])
                    {
                        int winningCard = secondPlayerSet[i];
                        int losingCard = firstPlayerSet[i];

                        secondPlayerSet.Add(winningCard);
                        secondPlayerSet.Add(losingCard);

                        secondPlayerSet.Remove(winningCard);
                        firstPlayerSet.Remove(losingCard);
                        i--;
                    }
                    else
                    {
                        firstPlayerSet.Remove(firstPlayerSet[i]);
                        secondPlayerSet.Remove(secondPlayerSet[i]);
                        i--;
                    }
                }
            }
            if (firstPlayerSet.Count > 0)
            {
                int sum = firstPlayerSet.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (secondPlayerSet.Count > 0)
            {
                int sum = secondPlayerSet.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}
