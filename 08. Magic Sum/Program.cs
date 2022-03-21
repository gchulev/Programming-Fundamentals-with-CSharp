using System;
using System.Linq;

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(Console.ReadLine());
            int[] arrayInt = input.Select(int.Parse).ToArray();

            string pairs = String.Empty;

            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = i + 1; j < arrayInt.Length; j++)
                {
                    if (i != arrayInt.Length - 1)
                    {
                        string currentPair = $"{arrayInt[i]} {arrayInt[j]}\n";

                        if (arrayInt[i] + arrayInt[j] == n && !pairs.Contains(currentPair))
                        {
                            pairs += currentPair;
                        }
                    }
                }
            }

            Console.WriteLine(pairs);
        }
    }
}
